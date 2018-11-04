using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    struct AETRange
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public AETRange(double x1, double x2)
        {
            X1 = (int)x1;
            X2 = (int)x2;
        }
    }
}
