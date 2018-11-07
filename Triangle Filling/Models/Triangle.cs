using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling.Models
{
    class Triangle
    {
        public Vertex V1 { get; set; }
        public Vertex V2 { get; set; }
        public Vertex V3 { get; set; }

        public List<Edge> Edges => new List<Edge>
        {
            new Edge() { X1 = V1.X, Y1 = V1.Y, X2 = V2.X, Y2 = V2.Y },
            new Edge() { X1 = V2.X, Y1 = V2.Y, X2 = V3.X, Y2 = V3.Y },
            new Edge() { X1 = V3.X, Y1 = V3.Y, X2 = V1.X, Y2 = V1.Y }
        };

        public bool GetClickedVertex(Point p, out Vertex v)
        {
            int eps = 10;
            if (V1.P.DistanceToPoint(p) <= eps)
            {
                v = V1;
                return true;
            }
            if (V2.P.DistanceToPoint(p) <= eps)
            {
                v = V2;
                return true;
            }
            if (V3.P.DistanceToPoint(p) <= eps)
            {
                v = V3;
                return true;
            }
            v = null;
            return false;
        }
    }
}
