using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling.Models
{
    class Vertex
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point P => new Point(X, Y);

        public Vertex(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
