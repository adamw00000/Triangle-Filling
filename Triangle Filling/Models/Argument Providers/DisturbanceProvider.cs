using PixelMapSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class DisturbanceProvider
    {
        public static Func<Vector3D, int, int, Vector3D> HeightMapDisturbance = (N, x, y) =>
        {
            PixelMap HeightMap = FillConfig.HeightMapTexture;

            x %= HeightMap.Width;
            y %= HeightMap.Height;

            Color c = HeightMap[x, y].Color;
            Color cx = HeightMap[(x + 1) % HeightMap.Width, y].Color;
            Color cy = HeightMap[x, (y + 1) % HeightMap.Height].Color;

            Vector3D T = new Vector3D(1, 0, -N.X);
            Vector3D B = new Vector3D(0, 1, -N.Y);

            double dhx = (cx.R - c.R) / 255d;
            double dhy = (cy.R - c.R) / 255d;

            Vector3D D = T * dhx + B * dhy;

            return D;
        };

        public static Func<Vector3D, int, int, Vector3D> ConstantDisturbance = (N, x, y) =>
        {
            return new Vector3D(0, 0, 0);
        };
    }
}
