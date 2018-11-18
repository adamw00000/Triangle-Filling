using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class LightVectorProvider
    {
        static readonly double alphaChange = Math.PI / FillConfig.AnimationFrames;

        public static int Step = 0;

        public static Func<int, int, Vector3D> ConstantVector = (x, y) =>
        {
            return new Vector3D(0, 0, 1);//(0 - x, -(0 - y), 400);
        };

        public static Func<int, int, Vector3D> SphereVector = (x, y) =>
        {
            double R = FillConfig.AnimationRadius;
            double alpha = (Step % (FillConfig.AnimationFrames * 2)) * alphaChange;

            return new Vector3D(Constants.ImageWidth / 2 + R * Math.Cos(alpha) - x,
                    -(Constants.ImageHeight / 2 + R * Math.Sin(alpha) - y), FillConfig.AnimationLightHeight);
        };
    }
}
