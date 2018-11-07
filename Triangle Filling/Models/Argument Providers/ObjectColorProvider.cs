using PixelMapSharp;
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
        public static Func<int, int, int, Color> ConstantColor = (id, x, y) => 
            id % 2 == 0 ? FillConfig.ObjectColor : FillConfig.SecondObjectColor;

        public static Func<int, int, int, Color> TextureColor = (id, x, y) =>
        {
            PixelMap ObjectTexture = id % 2 == 0 ? FillConfig.ObjectTexture : FillConfig.SecondObjectTexture;
            x %= ObjectTexture.Width;
            y %= ObjectTexture.Height;

            return ObjectTexture[x, y].Color;
        };
    }
}
