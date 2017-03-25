using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TrapezoidalMap
{
    public class TMANode : TMNode
    {
        public TMTrapezoid Trap { get; set; }

        public TMANode(TMTrapezoid A)
        {
            this.Trap = A;
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
            string s = string.Format("A_Node: {0}", Trap);
            return s;
        }
    }
}
