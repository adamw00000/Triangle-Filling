using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    class ETTable
    {
        readonly AETEntry[] ET;

        public ETTable(List<Edge> edges)
        {
            ET = new AETEntry[(int)edges.Max(e => e.Y1) + 1];

            FillET(edges);
        }

        private void FillET(List<Edge> edges)
        {
            foreach (var e in edges)
            {
                if ((int)e.Y1 == (int)e.Y2)
                    continue;

                int index = (int)Math.Min(e.Y1, e.Y2);
                AETEntry entry = new AETEntry(e, ET[index]);
                ET[index] = entry;
            }
        }

        public int GetLowestY()
        {
            for (int i = 0; i < ET.Length; i++)
                if (ET[i] != null)
                    return i;

            return -1;
        }

        public int GetHighestY()
        {
            for (int i = ET.Length - 1; i >= 0; i--)
                if (ET[i] != null)
                    return i;

            return -1;
        }

        public AETEntry this[int i] => ET[i];
    }
}
