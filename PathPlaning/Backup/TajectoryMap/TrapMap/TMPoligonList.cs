using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMPoligonList
    {
        protected List<TMPoligon> poligons;
        public List<TMPoligon> Poligons 
        { 
            get { return this.poligons; }
        }

        public TMPoligonList(List<TMPoligon> poligons)
        {
            this.poligons = poligons;
        }

        public List<TMSegment> GetAllSegments()
        {
            List<TMSegment> segs = new List<TMSegment>();
            foreach (TMPoligon p in poligons)
                foreach(TMSegment s in p.Segments)
                    segs.Add(s);
            return segs;
        }

        public List<TMSegment> GetRandomPermutationOfSegments()
        {
            List<TMSegment> l = this.GetAllSegments();
            if (l.Count >= 2)
            {
                Random r = new Random(System.Environment.TickCount);
                for (int i = 0; i < l.Count - 1; i++)
                {
                    int pos = r.Next(i, l.Count); // inclusivo, exclusivo
                    TMSegment temp = l[i];
                    l[i] = l[pos];
                    l[pos] = temp;
                }
            }
            return l;
        }        
    }
}
