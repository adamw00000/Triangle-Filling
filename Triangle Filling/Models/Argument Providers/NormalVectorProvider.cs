using PixelMapSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class NormalVectorProvider
    {
        public static Func<int, int, Vector3D> NormalMapVector = (x, y) =>
        {
            PixelMap NormalMap = FillConfig.NormalMapTexture;

            x %= NormalMap.Width;
            y %= NormalMap.Height;

            Color c = NormalMap[x, y].Color;
            double X = c.R * 2 / 255d - 1;
            double Y = c.G * 2 / 255d - 1;
            double Z = c.B / 255d;
            Vector3D N = new Vector3D(X, Y, Z);
            N.NormalizeByZ();

            return N;
        };

        public static Func<int, int, Vector3D> ConstantVector = (x, y) =>
        {
            return new Vector3D(0, 0, 1);
        };
    }
}
