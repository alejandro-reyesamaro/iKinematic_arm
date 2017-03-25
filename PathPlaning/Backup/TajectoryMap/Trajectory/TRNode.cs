using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrapezoidalMap;

namespace TrajectoryMap
{
    public class TRNode
    {        

        #region Propiedades
        private TRNode upper;
        private TRNode lower;
        private bool obj;
        private TMPoint point;
        private TRRange rango;
        
        public TRRange Y_Range
        {
            get { return this.rango; }
            set { this.rango = value; }
        }
        public bool IsObjetive
        {
            get { return this.obj; }
            set { this.obj = value; }
        }
        public TRNode Upper 
        {
            get { return this.upper; }
            set { this.upper = value; } 
        }
        public TRNode Lower
        {
            get { return this.lower; }
            set { this.lower = value; }
        }
        public TMPoint Point
        {
            get { return this.point; }
        }
        public TRNode Next
        {
            get
            {
                if (this.Doble)
                    return (this.state == Node_State.Free || this.state == Node_State.In) ? this.upper : this.lower;
                else 
                    return (this.upper != null) ? this.upper : this.lower;
            }
        }
        public bool EndNode
        {
            get { return this.lower == null && this.upper == null; }
        }
        public bool Doble
        {
            get { return this.lower != null && this.upper != null; }
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
            this.lower = l;
            this.upper = u;
            this.point = p;
            this.state = Node_State.Free;
            this.rango = r;
            this.obj = false;
        }
        public TRNode(TMPoint p, TRRange r)
            : this(p, null, null, r)
        { }
        public TRNode(TMPoint p)
            : this(p, null, null, new TRRange(p.Y, p.Y))
        { }

        public override string ToString()
        {
            return point.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            else
                return base.Equals(obj);
        }
        public void ResetMarcs()
        {
            this.state = Node_State.Free;
            if (this.lower != null)
                this.lower.ResetMarcs();
            if (this.upper != null)
                this.upper.ResetMarcs();
        }
        
    }
    public enum Node_State { Free, In, JustPop}
}
