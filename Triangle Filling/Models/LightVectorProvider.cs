using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    static class LightVectorProvider
    {
        public static Func<int, int, FillConfig, Vector3D> ConstantVector = (x, y, config) =>
        {
            return new Vector3D(0, 0, 1);
        };

        public static Func<int, int, FillConfig, Vector3D> SphereVector = (x, y, config) =>
        {
            return new Vector3D(0, 0, 1);
        };
    }
}
