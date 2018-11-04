using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    class AETEntry
    {
#pragma warning disable IDE1006 // Naming Styles
        public double yMax { get; }
        public double xMin { get; set; }
        public double dxdy { get; }
#pragma warning restore IDE1006 // Naming Styles
        public AETEntry Next { get; set; }

        public AETEntry(Edge e, AETEntry next = null)
        {
            yMax = Math.Max(e.Y1, e.Y2);
            xMin = yMax == e.Y1 ? e.X2 : e.X1;
            dxdy = (e.X2 - e.X1) / (e.Y2 - e.Y1);
            Next = next;
        }
    }
}
