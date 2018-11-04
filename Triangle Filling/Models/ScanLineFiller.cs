using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    class ScanLineFiller
    {
        ETTable ET;
        AETTable AET;
        readonly List<Edge> edges;
        readonly Bitmap bitmap;

        readonly FillConfig config;

        public Func<Vector3D, int, int, FillConfig, Vector3D> CalculateDisturbance { get; set; } = DisturbanceProvider.ConstantDisturbance;
        public Func<int, int, FillConfig, Vector3D> CalculateNormalVector { get; set; } = NormalVectorProvider.ConstantVector;
        public Func<FillConfig, Color> GetLightColor { get; set; } = LightColorProvider.StaticLigthing;
        public Func<int, int, FillConfig, Vector3D> GetLightVector { get; set; } = LightVectorProvider.ConstantVector;
        public Func<int, int, FillConfig, Color> GetObjectColor { get; set; } = ObjectColorProvider.ConstantColor;

        public ScanLineFiller(Bitmap bitmap, List<Edge> edges, FillConfig config)
        {
            this.edges = edges;
            this.bitmap = bitmap;
            this.config = config;
        }

        public void Fill()
        {
            PrepareStructures();

            int y = ET.GetLowestY();
            int yMax = ET.GetHighestY();

            if (y == -1)
                return;

            while (y <= yMax || !AET.IsEmpty)
            {
                if (y <= yMax)
                    AET.Add(ET[y]);

                AET.Sort();

                foreach (var range in AET.GetRanges())
                {
                    FillRange(y, range);
                }

                AET.DeleteY(y);
                y++;
                AET.DeleteY(y); // ????????????????????????????????????
                AET.UpdateX();
            }
        }

        private void PrepareStructures()
        {
            ET = new ETTable(edges);
            AET = new AETTable();
        }

        private void FillRange(int y, AETRange range)
        {
            //bitmap.DrawLine(range.X1, y, range.X2, y, GetColor());
            for (int x = range.X1; x <= range.X2; x++)
            {
                bitmap.SetPixel(x, y, GetColor(x, y));
            }
        }

        private Color GetColor(int x, int y)
        {
            Color IL = GetLightColor(config);
            Color IO = GetObjectColor(x, y, config);

            Vector3D L = GetLightVector(x, y, config);
            L.Normalize();
            Vector3D N = GetNormalVector(x, y);
            double cosine = Vector3D.DotProduct(N, L);

            byte R = (byte)(IL.R * IO.R * cosine / 255d);
            byte G = (byte)(IL.G * IO.G * cosine / 255d);
            byte B = (byte)(IL.B * IO.B * cosine / 255d);
            return Color.FromArgb(255, R, G, B);
        }

        private Vector3D GetNormalVector(int x, int y)
        {
            Vector3D N = CalculateNormalVector(x, y, config);
            Vector3D D = CalculateDisturbance(N, x, y, config);

            N = N + D;
            N.Normalize();

            return N;
        }
    }
}
