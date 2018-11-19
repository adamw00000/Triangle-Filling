using System;
using System.Drawing;

namespace Triangle_Filling
{
    static class FanLightProvider
    {
        static readonly double alphaChange = 2 * Math.PI / FillConfig.AnimationFrames;
        public static int Step = 0;

        static readonly Color[] colorFrames = new Color[FillConfig.AnimationFrames];

        static FanLightProvider()
        {
            colorFrames[0] = Color.Red;
            for (int i = 1; i <= FillConfig.AnimationFrames / 6; i++)
            {
                int G = colorFrames[i - 1].G + (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(colorFrames[i - 1].R, G, colorFrames[i - 1].B);
            }
            for (int i = FillConfig.AnimationFrames / 6 + 1; i <= 2 * FillConfig.AnimationFrames / 6; i++)
            {
                int R = colorFrames[i - 1].R - (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(R, colorFrames[i - 1].G, colorFrames[i - 1].B);
            }
            for (int i = 2 * FillConfig.AnimationFrames / 6 + 1; i <= 3 * FillConfig.AnimationFrames / 6; i++)
            {
                int B = colorFrames[i - 1].B + (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(colorFrames[i - 1].R, colorFrames[i - 1].G, B);
            }
            for (int i = 3 * FillConfig.AnimationFrames / 6 + 1; i <= 4 * FillConfig.AnimationFrames / 6; i++)
            {
                int G = colorFrames[i - 1].G - (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(colorFrames[i - 1].R, G, colorFrames[i - 1].B);
            }
            for (int i = 4 * FillConfig.AnimationFrames / 6 + 1; i <= 5 * FillConfig.AnimationFrames / 6; i++)
            {
                int R = colorFrames[i - 1].R + (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(R, colorFrames[i - 1].G, colorFrames[i - 1].B);
            }
            for (int i = 5 * FillConfig.AnimationFrames / 6 + 1; i < 6 * FillConfig.AnimationFrames / 6; i++)
            {
                int B = colorFrames[i - 1].B - (255 / (FillConfig.AnimationFrames / 6));
                colorFrames[i] = Color.FromArgb(colorFrames[i - 1].R, colorFrames[i - 1].G, B);
            }
        }

        public static Func<int, int, Color> NoColor = (x, y) =>
        {
            return Color.Black;
        };

        public static Func<int, int, Color> RedColorAnimation = (x, y) =>
        {
            return colorFrames[Step];
        };

        public static Func<int, int, Color> GreenColorAnimation = (x, y) =>
        {
            return colorFrames[(Step + FillConfig.AnimationFrames / 3) % FillConfig.AnimationFrames];
        };

        public static Func<int, int, Color> BlueColorAnimation = (x, y) =>
        {
            return colorFrames[(Step + 2 * FillConfig.AnimationFrames / 3) % FillConfig.AnimationFrames];
        };

        public static Func<int, int, Vector3D> FirstVector = (x, y) =>
        {
            double R = FillConfig.AnimationRadius;
            double alpha = (Step % FillConfig.AnimationFrames) * alphaChange;

            return new Vector3D(Constants.ImageWidth / 2 + R * Math.Cos(alpha) - x,
                    -(Constants.ImageHeight / 2 + R * Math.Sin(alpha) - y), 50);
        };

        public static Func<int, int, Vector3D> SecondVector = (x, y) =>
        {
            double R = FillConfig.AnimationRadius;
            double alpha = (Step % FillConfig.AnimationFrames) * alphaChange + 2d / 3 * Math.PI;

            return new Vector3D(Constants.ImageWidth / 2 + R * Math.Cos(alpha) - x,
                    -(Constants.ImageHeight / 2 + R * Math.Sin(alpha) - y), 50);
        };

        public static Func<int, int, Vector3D> ThirdVector = (x, y) =>
        {
            double R = FillConfig.AnimationRadius;
            double alpha = (Step % FillConfig.AnimationFrames) * alphaChange + 4d / 3 * Math.PI;

            return new Vector3D(Constants.ImageWidth / 2 + R * Math.Cos(alpha) - x,
                    -(Constants.ImageHeight / 2 + R * Math.Sin(alpha) - y), 50);
        };
    }
}