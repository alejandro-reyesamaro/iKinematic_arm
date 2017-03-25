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
            if (seg.porEncimaDe(p))
                return this.node_rigth.buscar(p, s);
            if(s.Pendiente < seg.Pendiente)
                return this.node_rigth.buscar(p, s);
            return this.node_left.buscar(p, s);
        }

        public override TMNode buscar(TMPoint p)
        {
            if (seg.porDebajoDe(p))
                return this.node_left.buscar(p);
            return this.node_rigth.buscar(p);
        }

        public override string ToString()
        {
            string s = string.Format("S_Node: {0}", seg);
            return s;
        }
    }
}
