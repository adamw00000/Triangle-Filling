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
        public static Bitmap NormalMapTexture = new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/normal_map.jpg");
        public static Bitmap NormalMapBrickTexture = new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/brick_normalmap.png");
        public static Bitmap HeightMapTexture = new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/brick_heightmap.png");
        public static Bitmap ObjectTexture = new Bitmap($"{Directory.GetCurrentDirectory()}/Textures/object_texture.jpg");
    }
}
