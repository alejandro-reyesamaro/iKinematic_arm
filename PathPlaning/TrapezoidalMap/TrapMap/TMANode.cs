using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrapezoidalMap
{
    public class TMANode : TMNode
    {
        protected TMTrapezoid a;
        public TMTrapezoid Trap 
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public TMANode(TMTrapezoid A)
        {
            this.a = A;
        }

        public override TMNode buscar(TMPoint p, TMSegment s)
        {
            return this;
        }
        public override TMNode buscar(TMPoint p)
        {
            return this;
        }

        public override string ToString()
        {
            string s = "A_Node: " + a.ToString();
            return s;
        }
    }
}
