using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Filling
{
    class AETTable: IEnumerable<AETEntry>
    {
        AETEntry head;

        public void Add(AETEntry entry)
        {
            if (head == null)
            {
                head = entry;
                return;
            }

            AETEntry p = head, pp = null;
            while (p != null)
            {
                pp = p;
                p = p.Next;
            }

            pp.Next = entry;
        }

        public void Sort()
        {
            AETEntry sortedHead = null;
            AETEntry currentEntry = head;

            while (currentEntry != null)
            {
                head = currentEntry.Next;
                if (sortedHead == null || currentEntry.xMin < sortedHead.xMin)
                {
                    currentEntry.Next = sortedHead;
                    sortedHead = currentEntry;
                }
                else
                {
                    AETEntry p = sortedHead;
                    AETEntry pp = null;
                    while (p != null && p.xMin <= currentEntry.xMin)
                    {
                        pp = p;
                        p = p.Next;
                    }
                    
                    pp.Next = currentEntry;
                    currentEntry.Next = p;
                }
                currentEntry = head;
            }

            head = sortedHead;
        }

        public void DeleteY(int y)
        {
            AETEntry p = head, pp = null;

            while (p != null)
            {
                if ((int)p.yMax == y)
                {
                    if (p == head)
                        head = head.Next;
                    else
                        pp.Next = p.Next;
                }
                pp = p;
                p = p.Next;
            }
        }

        public void UpdateX()
        {
            foreach (var entry in this)
                entry.xMin += entry.dxdy;
        }

        public bool IsEmpty => head == null;

        public IEnumerable<AETRange> GetRanges()
        {
            AETEntry p = head;
            while (p != null)
            {
                double X1 = p.xMin;
                p = p.Next;
                double X2 = p.xMin;
                yield return new AETRange(X1, X2);
                p = p.Next;
            }
        }
        
        public IEnumerator<AETEntry> GetEnumerator()
        {
            AETEntry p = head;
            while (p != null)
            {
                yield return p;
                p = p.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
