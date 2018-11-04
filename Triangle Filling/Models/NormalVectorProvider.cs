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
        public static Func<int, int, FillConfig, Vector3D> NormalMapVector = (x, y, config) =>
        {
            Bitmap NormalMap = config.NormalMapTexture;

            x %= NormalMap.Width;
            y %= NormalMap.Height;

            Color c = NormalMap.GetPixel(x, y);
            double X = c.R * 2 / 255d;
            double Y = c.G * 2 / 255d;
            double Z = c.B / 127d;
            Vector3D N = new Vector3D(X, Y, Z); //?????????????????????
            N.NormalizeByZ();

            return N;
        };

        public static Func<int, int, FillConfig, Vector3D> ConstantVector = (x, y, config) =>
        {
            return new Vector3D(0, 0, 1);
        };
    }
}
