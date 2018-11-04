using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    struct LambertColor
    {
        public double R { get; }
        public double G { get; }
        public double B { get; }

        public LambertColor(Color c)
        {
            R = (double)c.R / 255;
            G = (double)c.G / 255;
            B = (double)c.B / 255;
        }

        public static explicit operator Color(LambertColor lc) => Color.FromArgb(255, (byte)(lc.R * 255), (byte)(lc.G * 255), (byte)(lc.B * 255));
    }
}
