using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMPNode : TMNode
    {
        protected TMPoint point;
        public TMPoint Point 
        {
            get { return this.point; }
            set { this.point = value; } 
        }

        public TMPNode(TMPoint p)
        {
            this.point = p;
        }

        public override TMNode buscar(TMPoint p)
        {
            if (p.alaDerechaDe(this.point) || p.Equals(point))
                return this.node_rigth.buscar(p);
            else return this.node_left.buscar(p);
        }
        public override TMNode buscar(TMPoint p, TMSegment s)
        {
            if (p.alaDerechaDe(this.point) || p.Equals(point))
                return this.node_rigth.buscar(p, s);
            else return this.node_left.buscar(p, s);
        }

        public override string ToString()
        {
            string s = "P_Node: " + point.ToString();
            return s;
        }
    }
}
