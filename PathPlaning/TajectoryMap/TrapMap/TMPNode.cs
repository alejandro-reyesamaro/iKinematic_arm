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
            return this.node_left.buscar(p);
        }

        public override TMNode buscar(TMPoint p, TMSegment s)
        {
            if (p.alaDerechaDe(this.point) || p.Equals(point))
                return this.node_rigth.buscar(p, s);
            return this.node_left.buscar(p, s);
        }

        public override string ToString()
        {
            string s = string.Format("P_Node: {0}", point);
            return s;
        }
    }
}
