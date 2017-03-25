using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    /// <summary>
    /// Nodo que representa un segmento
    /// </summary>
    public class TMSNode : TMNode
    {
        protected TMSegment seg;
        public TMSegment Segment
        {
            get { return this.seg; }
            set { this.seg = value; }
        }
        public TMSNode(TMSegment segment)
        {
            this.seg = segment;
        }
        public override TMNode buscar(TMPoint p, TMSegment s)
        {
            if (seg.porDebajoDe(p))
                return this.node_left.buscar(p, s);
            else if (seg.porEncimaDe(p))
                return this.node_rigth.buscar(p, s);
            else 
            { 
                if(s.Pendiente < seg.Pendiente)
                    return this.node_rigth.buscar(p, s);
                else return this.node_left.buscar(p, s);
            }
        }
        public override TMNode buscar(TMPoint p)
        {
            if (seg.porDebajoDe(p))
                return this.node_left.buscar(p);
            else 
                return this.node_rigth.buscar(p);
        }
        public override string ToString()
        {
            string s = "S_Node: " + seg.ToString();
            return s;
        }
    }
}
