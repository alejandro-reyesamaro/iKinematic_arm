using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using TrapezoidalMap;

namespace TrajectoryMap
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
        public TRTrajectoryGraph(TMSearchGraph D, TMPoint end_efector, TMPoint objetivo, double seps)
        {
            this.stack = new Stack<TRNode>();
            this.current = null;
            this.separacion = seps;
            initGraph(D, end_efector, objetivo);            
        }

        protected void initGraph(TMSearchGraph D, TMPoint end_efector, TMPoint objetivo)
        {
            TMANode tr_inicio = (TMANode)D.Root.buscar(end_efector);
            TMANode tr_fin = (TMANode)D.Root.buscar(objetivo);
            init_recursivo(null, D, tr_inicio, tr_fin, objetivo);
        }

        protected void init_recursivo(TRNode anterior, TMSearchGraph D, TMANode tr, TMANode tr_fin, TMPoint objetivo)
        {
            TMPoint centro = tr.Trap.Centro;
            TRNode node_centro = (anterior == null) ? 
                  new TRNode(centro, new TRRange(centro.Y, centro.Y)) 
                : new TRNode(centro, rango_del_centro(tr.Trap, centro.Y));
            if (anterior != null)
            {
                if (anterior.Upper == null) anterior.Upper = node_centro;
                else anterior.Lower = node_centro;
            }
            else this.root = node_centro;

            if (tr.Equals(tr_fin))
            {
                //TRNode node_objetivo = new TRNode(objetivo, new TRRange(objetivo.Y, objetivo.Y));
                //node_objetivo.IsObjetive = true;
                //node_centro.Upper = node_objetivo;
                TRNode node_objetivo = new TRNode(objetivo, new TRRange(objetivo.Y, objetivo.Y));
                node_objetivo.IsObjetive = true;
                if (anterior.Upper.Equals(node_centro)) anterior.Upper = node_objetivo;
                else anterior.Lower = node_objetivo;
            }
            else
            {
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
                                             (lower_right.Equals(upper_right) && tr.Trap.RightP.Y < tr.Trap.Top_Right.Y));

                bool se_construye_el_lower = (upper_right != null || lower_right != null)
                                                &&
                                             (((lower_right != null) && (upper_right == null || !lower_right.Equals(upper_right)))
                                                ||
                                             (upper_right.Equals(lower_right) && tr.Trap.RightP.Y > tr.Trap.Bottom_Right.Y));


                if (se_construye_el_upper)
                {
                    double xpu = tr.Trap.RightP.X;
                    double ypu = (tr.Trap.RightP.Y + tr.Trap.Top_Right.Y) / 2;
                    TMPoint pu = new TMPoint(xpu, ypu);
                    TRNode node_upper = new TRNode(pu, rango_derecho(tr.Trap, ypu));
                    node_centro.Upper = node_upper;
                    init_recursivo(node_upper, D, upper_right, tr_fin, objetivo);
                }
                if (se_construye_el_lower)
                {
                    double xpw = tr.Trap.RightP.X;
                    double ypw = (tr.Trap.RightP.Y + tr.Trap.Bottom_Right.Y) / 2;
                    TMPoint pw = new TMPoint(xpw, ypw);
                    TRNode node_lower = new TRNode(pw, rango_derecho(tr.Trap, ypw));
                    node_centro.Lower = node_lower;
                    init_recursivo(node_lower, D, lower_right, tr_fin, objetivo);
                }
                if (!se_construye_el_upper && !se_construye_el_lower)
                {
                    node_centro.Y_Range = new TRRange(centro.Y, centro.Y);
                }
            }
        }

        protected TRRange rango_derecho(TMTrapezoid t, double y_del_nodo)
        {
            double x_centro = t.RightP.X;
            double y_max = 0, y_min = 0;
            if (y_del_nodo > t.RightP.Y)
            {
                y_max = (t.Top_Right.Y - separacion > y_del_nodo) ? t.Top_Right.Y - separacion : y_del_nodo;
                y_min = (t.RightP.Y + separacion < y_del_nodo) ? t.RightP.Y + separacion : y_del_nodo;
            }
            else 
            {
                y_max = (t.RightP.Y - separacion > y_del_nodo) ? t.RightP.Y - separacion : y_del_nodo;
                y_min = (t.Bottom_Right.Y + separacion < y_del_nodo) ? t.Bottom_Right.Y + separacion : y_del_nodo;
            }
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
            if (!verifica_trayectoria())
                MoveNext();
        }

        private bool verifica_trayectoria()
        {
            foreach (TRNode node in this.current)
            {
                if (node.IsObjetive) return true;
            }
            return false;
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
            do
            {
                if (verifica_trayectoria())
                    return true;
            } while (MoveNext());
            return false;
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
