using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class ReflectorLightProvider
    {
        public static Func<int, int, Color> RReflector = (x, y) =>
            GetReflectorColor(x, y, Color.Red, FillConfig.RReflectorPos);

        public static Func<int, int, Color> GReflector = (x, y) => 
            GetReflectorColor(x, y, Color.Green, FillConfig.GReflectorPos);

        public static Func<int, int, Color> BReflector = (x, y) => 
            GetReflectorColor(x, y, Color.Blue, FillConfig.BReflectorPos);

        public static Func<int, int, Color> NoReflector = (x, y) => Color.Black;

        private static Color GetReflectorColor(int x, int y, Color baseColor, Point3D reflectorPos)
        {
            Color c = baseColor;

            Vector3D ReflectorVector = FillConfig.MiddleImagePos - reflectorPos;
            Vector3D PointVector = new Point3D(x, y, 0) - reflectorPos;
            ReflectorVector.Normalize();
            PointVector.Normalize();

            double cosine = Vector3D.DotProduct(ReflectorVector, PointVector);
            if (cosine < 0)
                cosine = 0;

            double intensity = Math.Pow(cosine, FillConfig.ReflectorCosinePower);

            return Color.FromArgb((int)(c.R * intensity), (int)(c.G * intensity), (int)(c.B * intensity));
        }
    }
}
