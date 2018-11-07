using PixelMapSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    public static class Constants
    {
        public static int ImageWidth { get; } = 800;
        public static int ImageHeight { get; } = 600;

        public static PixelMap NormalMapTexture = PixelMap.SlowLoad(new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/normal_map.jpg"));
        public static PixelMap NormalMapBrickTexture = PixelMap.SlowLoad(new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/brick_normalmap.png"));
        public static PixelMap HeightMapTexture = PixelMap.SlowLoad(new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/brick_heightmap.png"));
        public static PixelMap ObjectTexture = PixelMap.SlowLoad(new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/object_texture.jpg"));
    }
}
