using PixelMapSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    public static class FillConfig
    {
        public static PixelMap HeightMapTexture { get; set; } = Constants.HeightMapTexture;
        public static PixelMap NormalMapTexture { get; set; } = Constants.NormalMapTexture;
        public static PixelMap ObjectTexture { get; set; } = Constants.ObjectTexture;
        public static PixelMap SecondObjectTexture { get; set; } = Constants.ObjectTexture;
        public static Color ObjectColor { get; set; } = Color.LimeGreen;
        public static Color SecondObjectColor { get; set; } = Color.Crimson;
        public static Color LightColor { get; set; } = Color.White;
        public static double Radius { get; set; } = 100;
        public static double ReflectorHeight { get; set; } = 100;
        public static double ReflectorCosinePower { get; set; } = 100;

        public static Point3D RReflectorPos =>
            new Point3D(0, Constants.ImageHeight, ReflectorHeight);
        public static Point3D GReflectorPos =>
            new Point3D(Constants.ImageWidth / 2, 0, ReflectorHeight);
        public static Point3D BReflectorPos =>
            new Point3D(Constants.ImageWidth, Constants.ImageHeight, ReflectorHeight);
        public static Point3D MiddleImagePos =>
            new Point3D(Constants.ImageWidth / 2, Constants.ImageHeight / 2, 0);

        //public static double[,] Cosines { get; set; } = new double[800, 600];
        //public static Color[,] Colors { get; set; } = new Color[800, 600];
    }
}
