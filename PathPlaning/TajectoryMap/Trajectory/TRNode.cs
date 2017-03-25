using TrapezoidalMap;

namespace TrajectoryMap
{
    public class TRNode
    {        

        #region Propiedades

        public TRRange Y_Range { get; set; }

        public bool IsObjetive { get; set; }

        public TRNode Upper { get; set; }

        public TRNode Lower { get; set; }

        public TMPoint Point { get; private set; }

        public TRNode Next
        {
            get
            {
                if (this.Doble)
                    return (this.state == Node_State.Free || this.state == Node_State.In) ? this.Upper : this.Lower;
                return this.Upper ?? this.Lower;
            }
        }
        public bool EndNode
        {
            get { return this.Lower == null && this.Upper == null; }
        }
        public bool Doble
        {
            get { return this.Lower != null && this.Upper != null; }
        }
        #endregion

        #region Estado del nodo
        private Node_State state;
        public Node_State State
        {
            get { return this.state; }
        }
        public void Pop()
        { this.state = Node_State.JustPop; }
        public void Free()
        { this.state = Node_State.Free; }
        public void GetIn()
        { this.state = Node_State.In; }
        #endregion

        public TRNode(TMPoint p, TRNode u, TRNode l, TRRange r)
        {
            this.Lower = l;
            this.Upper = u;
            this.Point = p;
            this.state = Node_State.Free;
            this.Y_Range = r;
            this.IsObjetive = false;
        }
        public TRNode(TMPoint p, TRRange r)
            : this(p, null, null, r)
        { }
        public TRNode(TMPoint p)
            : this(p, null, null, new TRRange(p.Y, p.Y))
        { }

        public override string ToString()
        {
            return Point.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return base.Equals(obj);
        }

        public void ResetMarcs()
        {
            this.state = Node_State.Free;
            if (this.Lower != null)
                this.Lower.ResetMarcs();
            if (this.Upper != null)
                this.Upper.ResetMarcs();
        }
        
    }
    public enum Node_State { Free, In, JustPop}
}
