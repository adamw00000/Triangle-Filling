using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangle_Filling.Models;

namespace Triangle_Filling
{
    class ScanLineFiller
    {
        ETTable ET;
        AETTable AET;
        Triangle triangle;
        readonly int id;
        //readonly Bitmap bitmap;

        public static Func<Vector3D, int, int, Vector3D> CalculateDisturbance { get; set; } = DisturbanceProvider.ConstantDisturbance;
        public static Func<int, int, Vector3D> CalculateNormalVector { get; set; } = NormalVectorProvider.ConstantVector;
        public static Func<Color> GetLightColor { get; set; } = LightColorProvider.StaticLigthing;
        public static Func<int, int, Color> GetRedReflectorColor { get; set; } = ReflectorLightProvider.NoReflector;
        public static Func<int, int, Color> GetGreenReflectorColor { get; set; } = ReflectorLightProvider.NoReflector;
        public static Func<int, int, Color> GetBlueReflectorColor { get; set; } = ReflectorLightProvider.NoReflector;
        public static Func<int, int, Vector3D> GetLightVector { get; set; } = LightVectorProvider.ConstantVector;
        public static Func<int, int, int, Color> GetObjectColor { get; set; } = ObjectColorProvider.ConstantColor;
        public static Func<int, int, int, Color> GetSecondObjectColor { get; set; } = ObjectColorProvider.ConstantColor;

        public static Func<int, int, Color> GetFirstFanColor { get; set; } = FanLightProvider.NoColor;
        public static Func<int, int, Color> GetSecondFanColor { get; set; } = FanLightProvider.NoColor;
        public static Func<int, int, Color> GetThirdFanColor { get; set; } = FanLightProvider.NoColor;
        public static Func<int, int, Vector3D> GetFirstFanVector { get; set; } = FanLightProvider.FirstVector;
        public static Func<int, int, Vector3D> GetSecondFanVector { get; set; } = FanLightProvider.SecondVector;
        public static Func<int, int, Vector3D> GetThirdFanVector { get; set; } = FanLightProvider.ThirdVector;

        public ScanLineFiller(int id, Triangle triangle)
        {
            this.triangle = triangle;
            this.id = id;
        }

        public void Fill(DirectBitmap bitmap)
        {
            PrepareStructures();

            int y = ET.GetLowestY();
            int yMax = ET.GetHighestY();

            if (y == -1)
                return;

            while (y <= yMax || !AET.IsEmpty)
            {
                AET.DeleteY(y);

                if (y <= yMax)
                    AET.Add(ET[y]);

                AET.Sort();

                foreach (var range in AET.GetRanges())
                {
                    FillRange(bitmap, y, range);
                }

                y++;
                AET.UpdateX();
            }
        }

        private void PrepareStructures()
        {
            ET = new ETTable(triangle.Edges);
            AET = new AETTable();
        }

        private void FillRange(DirectBitmap bitmap, int y, AETRange range)
        {
            for (int x = range.X1; x <= range.X2; x++)
            {
                bitmap.SetPixel(x, y, GetColor(x, y));
            }
        }

        public Color GetColor(int x, int y)
        {
            Color IL = GetLightColor();
            Color ILR = GetRedReflectorColor(x, y);
            Color ILG = GetGreenReflectorColor(x, y);
            Color ILB = GetBlueReflectorColor(x, y);
            Color IF1 = GetFirstFanColor(x, y);
            Color IF2 = GetSecondFanColor(x, y);
            Color IF3 = GetThirdFanColor(x, y);

            Color IO;
            if (id % 2 == 0)
                IO = GetObjectColor(id, x, y);
            else
                IO = GetSecondObjectColor(id, x, y);

            Vector3D L = GetLightVector(x, y);
            L.Normalize();
            Vector3D N = GetNormalVector(x, y);
            N.Normalize();

            double cosine = Vector3D.DotProduct(N, L);

            Vector3D RedPointVector = FillConfig.RReflectorPos - new Point3D(x, y, 0);
            Vector3D GreenPointVector = FillConfig.RReflectorPos - new Point3D(x, y, 0);
            Vector3D BluePointVector = FillConfig.RReflectorPos - new Point3D(x, y, 0);
            RedPointVector.Normalize();
            GreenPointVector.Normalize();
            BluePointVector.Normalize();
            double redCosine = Math.Max(Vector3D.DotProduct(N, RedPointVector), 0);
            double greenCosine = Math.Max(Vector3D.DotProduct(N, GreenPointVector), 0);
            double blueCosine = Math.Max(Vector3D.DotProduct(N, BluePointVector), 0);

            var firstFanVector = GetFirstFanVector(x, y);
            firstFanVector.Normalize();
            var secondFanVector = GetSecondFanVector(x, y);
            secondFanVector.Normalize();
            var thirdFanVector = GetThirdFanVector(x, y);
            thirdFanVector.Normalize();
            double firstFanCosine = Math.Max(Vector3D.DotProduct(N, firstFanVector), 0);
            double secondFanCosine = Math.Max(Vector3D.DotProduct(N, secondFanVector), 0);
            double thirdFanCosine = Math.Max(Vector3D.DotProduct(N, thirdFanVector), 0);

            if (cosine < 0)
                cosine = 0;

            byte R = (byte)(Math.Min(IL.R * IO.R * cosine / 255d + ILR.R * IO.R * redCosine / 255d +
                IF1.R * IO.R * firstFanCosine / 255d +
                IF2.R * IO.R * secondFanCosine / 255d +
                IF3.R * IO.R * thirdFanCosine / 255d, 255));
            byte G = (byte)(Math.Min(IL.G * IO.G * cosine / 255d + ILG.G * IO.G * greenCosine / 255d +
                IF1.G * IO.G * firstFanCosine / 255d +
                IF2.G * IO.G * secondFanCosine / 255d +
                IF3.G * IO.G * thirdFanCosine / 255d, 255));
            byte B = (byte)(Math.Min(IL.B * IO.B * cosine / 255d + ILB.B * IO.B * blueCosine / 255d +
                IF1.B * IO.B * firstFanCosine / 255d +
                IF2.B * IO.B * secondFanCosine / 255d +
                IF3.B * IO.B * thirdFanCosine / 255d, 255));
            return Color.FromArgb(255, R, G, B);
        }

        public static Vector3D GetNormalVector(int x, int y)
        {
            Vector3D N = CalculateNormalVector(x, y);
            Vector3D D = CalculateDisturbance(N, x, y);

            N = N + 10*D;
            return N;
        }
    }
}
