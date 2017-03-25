using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TrapezoidalMap
{
    public class TRTrajectoryGraph : IEnumerable<List<TRNode>>, IEnumerator<List<TRNode>>
    {
        protected TRNode root;
        protected Stack<TRNode> stack;
        protected List<TRNode> current;
        protected double separacion;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="D"></param>
        /// <param name="end_efector"></param>
        /// <param name="seps">rango que se tomará en cuenta para no acercar el nodo al obstáculo</param>
        public TRTrajectoryGraph(TMSearchGraph D, TMPoint end_efector, double seps)
        {
            this.stack = new Stack<TRNode>();
            this.current = null;
            this.separacion = seps;
            initGraph(D, end_efector);            
        }

        protected void initGraph(TMSearchGraph D, TMPoint end_efector)
        {
            TMANode tr_inicio = (TMANode)D.Root.buscar(end_efector);
            init_recursivo(null, D, tr_inicio);
        }

        protected void init_recursivo(TRNode anterior, TMSearchGraph D, TMANode tr)
        {
            TMPoint centro = tr.Trap.Centro;
            TRNode node_centro = new TRNode(centro, rango_del_centro(tr.Trap, centro.Y));
            if (anterior != null)
            {
                if (anterior.Upper == null) anterior.Upper = node_centro;
                else anterior.Lower = node_centro;
            }
            else this.root = node_centro;
            
            TMANode lower_right = D.lower_right(tr);
            TMANode upper_right = D.upper_right(tr);

            // Se verifica que alguno de ellos no es null
            // Y 
            // [
            // Upper_Right no es null y si el otro no es null entonces no son iguales
            // O
            // Son iguales y el top del trapecio entonces es mayor que el rightp
            // ]
            bool se_construye_el_upper = (upper_right != null || lower_right != null) 
                                            &&
                                         (((upper_right != null) && (lower_right == null || !lower_right.Equals(upper_right)))
                                            ||
                                         ( lower_right.Equals(upper_right) && tr.Trap.RightP.Y < tr.Trap.Top_Right.Y));

            bool se_construye_el_lower = (upper_right != null || lower_right != null) 
                                            &&
                                         (((lower_right != null) && (upper_right == null || !lower_right.Equals(upper_right)))
                                            ||
                                         ( upper_right.Equals(lower_right) && tr.Trap.RightP.Y > tr.Trap.Bottom_Right.Y));

                        
            if (se_construye_el_upper)
            {
                double xpu = tr.Trap.RightP.X;
                double ypu = (tr.Trap.RightP.Y + tr.Trap.Top_Right.Y) / 2;
                TMPoint pu = new TMPoint(xpu, ypu);
                TRNode node_upper = new TRNode(pu, rango_derecho(tr.Trap, ypu));
                node_centro.Upper = node_upper;
                init_recursivo(node_upper, D, upper_right);
            }
            if (se_construye_el_lower)
            {
                double xpw = tr.Trap.RightP.X;
                double ypw = (tr.Trap.RightP.Y + tr.Trap.Bottom_Right.Y) / 2;
                TMPoint pw = new TMPoint(xpw, ypw);
                TRNode node_lower = new TRNode(pw, rango_derecho(tr.Trap, ypw));
                node_centro.Lower = node_lower;
                init_recursivo(node_lower, D, lower_right);
            }
        }

        protected TRRange rango_derecho(TMTrapezoid t, double y_del_nodo)
        {
            double x_centro = t.RightP.X;
            double y_max = (t.Top_Right.Y - separacion > y_del_nodo)? t.Top_Right.Y - separacion : y_del_nodo;
            double y_min = (t.Bottom_Right.Y + separacion < y_del_nodo) ? t.Bottom_Right.Y + separacion : y_del_nodo;
            return new TRRange(y_min, y_max);
        }

        protected TRRange rango_del_centro(TMTrapezoid t, double y_del_nodo)
        {
            double x_centro = t.Centro.X;
            double y_max = (t.Top.eval(x_centro) - separacion > y_del_nodo)? t.Top.eval(x_centro) - separacion : y_del_nodo;
            double y_min = (t.Bottom.eval(x_centro) + separacion < y_del_nodo) ? t.Bottom.eval(x_centro) + separacion : y_del_nodo;
            return new TRRange(y_min, y_max);
        }

        #region IEnumerable<List<TMPoint>> Members 

        public IEnumerator<List<TRNode>> GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerable Members 

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerator<List<TMPoint>> Members 

        public List<TRNode> Current
        {
            get { return this.GetCurrent(); }
        }

        #endregion

        #region IDisposable Members 

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Members

        object IEnumerator.Current
        {
            get
            { return this.GetCurrent(); }
        }

        private List<TRNode> GetCurrent()
        {
            if (current == null)
                this.setCurrent();
            return this.current;
        }


        private void setCurrent()
        {
            this.current = new List<TRNode>();
            TRNode aux = this.root;
            while (aux != null)
            {
                current.Add(aux);
                if (aux.Doble)
                {
                    this.stack.Push(aux);
                    aux.GetIn();
                    aux = aux.Next;
                }
                else
                    aux = aux.Next;
            }
        }

        public bool MoveNext()
        {
            // El tope de la pila fue el nodo que genero la bifurcacion.
            if (this.stack.Count == 0) return false;
            TRNode actual = this.stack.Pop();
            if (actual == null) return false;
            actual.Pop();
            this.current = new List<TRNode>();
            TRNode aux = this.root;
            while (aux != null)
            {
                current.Add(aux);
                if (aux.Doble)
                {
                    switch (aux.State)
                    {
                        case Node_State.Free:
                            this.stack.Push(aux);
                            aux.GetIn();
                            aux = aux.Next;
                            break;
                        case Node_State.In:
                            aux = aux.Next;
                            break;
                        case Node_State.JustPop:
                            aux = aux.Next;
                            aux.Free();
                            break;
                    }
                }
                else
                    aux = aux.Next;
            }
            return true;
        }

        public void Reset()
        {
            this.stack = new Stack<TRNode>();
            this.current = null;
            this.root.ResetMarcs();
            setCurrent();
        }
        #endregion
    }
}
