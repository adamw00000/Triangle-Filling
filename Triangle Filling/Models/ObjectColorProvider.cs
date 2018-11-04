using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    class ObjectColorProvider
    {
        public static Func<int, int, FillConfig, Color> ConstantColor = (x, y, config) => config.ObjectColor;

        public static Func<int, int, FillConfig, Color> TextureColor = (x, y, config) =>
        {
            Bitmap ObjectTexture = config.ObjectTexture;
            x %= ObjectTexture.Width;
            y %= ObjectTexture.Height;

            return ObjectTexture.GetPixel(x, y);
        };
    }
}
