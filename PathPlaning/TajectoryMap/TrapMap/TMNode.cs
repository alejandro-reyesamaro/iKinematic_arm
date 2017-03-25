using System.Collections.Generic;

namespace TrapezoidalMap
{
    public abstract class TMNode
    {
        protected TMNode node_rigth;
        protected TMNode node_left;
        protected List<TMNode> fathers;
        //protected NodeType node_type;        
        //public NodeType node_type 
        //{
        //    get { return this.node_type; }
        //}
        public NodeType node_type(TMNode node)
        {
            if(node.Equals(this.node_left)) return NodeType.Left;
            if(node.Equals(this.node_rigth)) return NodeType.Right;
            return NodeType.None;
        }

        public List<TMNode> Fathers
        {
            get { return this.fathers; }            
        }

        public TMNode Node_Rigth 
        {
            get { return this.node_rigth; }
            set 
            { 
                this.node_rigth = value;
                if (value.fathers == null)
                    value.fathers = new List<TMNode>();
                value.Fathers.Add(this);
            }
        }

        public TMNode Node_Left
        {
            get { return this.node_left; }
            set 
            { 
                this.node_left = value;
                if (value.fathers == null)
                    value.fathers = new List<TMNode>();
                value.Fathers.Add(this);
            }
        }

        public TMNode this[NodeType s]
        {
            get 
            {
                switch (s)
                {
                    case NodeType.Left:
                        return this.node_left;
                    case NodeType.Right:
                        return this.node_rigth;
                    case NodeType.None:
                        return null;
                    default:
                        return null;
                }
            }
            set 
            {
                switch (s)
                {
                    case NodeType.Left:
                        this.Node_Left = value;
                        break;
                    case NodeType.Right:
                        this.Node_Rigth = value;
                        break;
                    case NodeType.None:
                        break;
                    default:
                        break;
                }
            }
        }

        public abstract TMNode buscar(TMPoint p, TMSegment s);
        public abstract TMNode buscar(TMPoint p);
    }

    public enum NodeType{ Left, Right, None}
}
