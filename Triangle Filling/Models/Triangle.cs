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

        float Sign(Point p1, Point p2, Point p3)
        {
            return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
        }

        public bool IsPointInTriangle(Point P)
        {
            float d1, d2, d3;
            bool has_neg, has_pos;

            d1 = Sign(P, V1.P, V2.P);
            d2 = Sign(P, V2.P, V3.P);
            d3 = Sign(P, V3.P, V1.P);

            has_neg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            has_pos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(has_neg && has_pos);
        }

        internal Vector Move(Vector deltaPos)
        {
            if (deltaPos.X > 0)
            {
                deltaPos.X = Math.Min(Constants.ImageWidth - V1.X, Math.Min(Constants.ImageWidth - V2.X, Math.Min(Constants.ImageWidth - V3.X, deltaPos.X)));
            }
            else
            {
                deltaPos.X = Math.Max(-V1.X, Math.Max(- V2.X, Math.Max(-V3.X, deltaPos.X)));
            }
            if (deltaPos.Y > 0)
            {
                deltaPos.Y = Math.Min(Constants.ImageHeight - V1.Y, Math.Min(Constants.ImageHeight - V2.Y, Math.Min(Constants.ImageHeight - V3.Y, deltaPos.Y)));
            }
            else
            {
                deltaPos.Y = Math.Max(-V1.Y, Math.Max(-V2.Y, Math.Max(-V3.Y, deltaPos.Y)));
            }
            V1.X += deltaPos.X;
            V1.Y += deltaPos.Y;
            V2.X += deltaPos.X;
            V2.Y += deltaPos.Y;
            V3.X += deltaPos.X;
            V3.Y += deltaPos.Y;

            return deltaPos;
        }
    }
}
