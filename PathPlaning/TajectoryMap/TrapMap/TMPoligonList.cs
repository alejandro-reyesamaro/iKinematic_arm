using System;
using System.Collections.Generic;
using System.Linq;

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
            return poligons.SelectMany(p => p.Segments).ToList();
        }

        public List<TMSegment> GetRandomPermutationOfSegments()
        {
            List<TMSegment> l = this.GetAllSegments();
            if (l.Count >= 2)
            {
                var r = new Random(Environment.TickCount);
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
