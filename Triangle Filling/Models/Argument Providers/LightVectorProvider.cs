using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class LightVectorProvider
    {
        const double R = 200;
        const double alphaChange = Math.PI / 12;

        public static int Step = 0;

        public static Func<int, int, Vector3D> ConstantVector = (x, y) =>
        {
            return new Vector3D(0 - x, -(0 - y), 400);//(0, 0, 1);
        };

        public static Func<int, int, Vector3D> SphereVector = (x, y) =>
        {
            return new Vector3D(Constants.ImageWidth / 2 + R * Math.Cos(Step * alphaChange) - x,
                -(Constants.ImageHeight / 2 + R * Math.Sin(Step * alphaChange) - y), FillConfig.Radius);
        };
    }
}
