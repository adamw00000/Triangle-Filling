using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    public class FillConfig
    {
        public Bitmap HeightMapTexture { get; set; } = Constants.HeightMapTexture;
        public Bitmap NormalMapTexture { get; set; } = Constants.NormalMapTexture;
        public Bitmap ObjectTexture { get; set; } = Constants.ObjectTexture;
        public Color ObjectColor { get; set; } = Color.FromKnownColor(KnownColor.LimeGreen);
        public Color LightColor { get; set; } = Color.FromKnownColor(KnownColor.White);
    }
}
