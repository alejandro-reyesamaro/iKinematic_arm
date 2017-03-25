using System.Collections.Generic;

namespace TrapezoidalMap
{
    public class TMSearchGraph
    {
        public TMNode Root { get; set; }

        public TMSearchGraph(TMNode root)
        {
            this.Root = root;
        }

        public TMANode lower_right(TMANode A)
        { 
            return lower_right_recursivo(A, Root);
        }

        private static TMANode lower_right_recursivo(TMANode A, TMNode D)
        {
            if (D is TMANode)
            {
                var D_ = (TMANode)D;
                TMPoint a = A.Trap.RightP;
                TMPoint l = D_.Trap.LeftP;
                TMPoint bl = D_.Trap.Bottom_Left;
                TMPoint bla = A.Trap.Bottom_Right;
                // el trapecio lower_right vecino de A es el que tenga como leftp, el
                // mismo punto de rightp de A, pero además sea su top_left.
                if (a.Equals(l) && bl.Equals(bla))
                    return D_;
                return null;
            }
            TMANode T = lower_right_recursivo(A, D.Node_Left) ?? lower_right_recursivo(A, D.Node_Rigth);
            return T;
        }

        public TMANode upper_right(TMANode A)
        {
            return upper_right_recursivo(A, Root);
        }

        private static TMANode upper_right_recursivo(TMANode A, TMNode D)
        {
            if (D is TMANode)
            {
                var D_ = (TMANode)D;
                TMPoint a = A.Trap.RightP;
                TMPoint l = D_.Trap.LeftP;
                TMPoint bl = D_.Trap.Top_Left;
                TMPoint bla = A.Trap.Top_Right;
                // el trapecio lower_right vecino de A es el que tenga como leftp, el
                // mismo punto de rightp de A, pero además sea su top_left.
                if (a.Equals(l) && bl.Equals(bla))
                    return D_;
                return null;
            }
            TMANode T = upper_right_recursivo(A, D.Node_Left) ?? upper_right_recursivo(A, D.Node_Rigth);
            return T;
        }

        public List<TMNode> follow_segment(TMSegment S)
        {//function Delta = followSegment(D, T, S)
            var Delta = new List<TMNode>();
            //% Puntos extremos del segmento.
            TMPoint p = S.Point_1;
            TMPoint q = S.Point_2;
            var A_ = (TMANode)this.Root.buscar(p, S);
            Delta.Add(A_);
            int j = 0;
            // mientras q esté a la derecha de la frontera derecha de A_
            while (q.X > A_.Trap.RightP.X)
            {
                // Si el rightp(A_) está por encima de S(i)
                TMANode A_1 = A_.Trap.RightP.Y > S.eval(A_.Trap.RightP.X) ? lower_right(A_) : upper_right(A_);
                if (A_1 == null) break;
                Delta.Add(A_1);
                A_ = A_1;                
                j++;
            }
            return Delta; 
        }
        

        public void actualiza_grafo_busqueda(List<TMNode> Delta, TMSegment S)//, out TMNode primero) // el primero ese hay que eliminarlo
        {
            //primero = null;
            TMTrapezoid A1 = null, A2 = null; 
            List<TMNode> a1_padres = null, a2_padres = null;

            for (int i = 0; i < Delta.Count; i++)
            {
                // Trapecio actual a analizar
                TMTrapezoid T = ((TMANode)Delta[i]).Trap;
                // Nodo actual a analizar
                TMNode Delta_node = Delta[i];
                // Conjunto de padres del nodo actual
                List<TMNode> padres = Delta[i].Fathers;

                #region left-end-poit de Si dentro del primer trapecio
                if (i == 0 && S.Point_1.X > T.LeftP.X)
                {
                    /*
                     * En este bloque se construirá un trapecio a la izquierda del punto 
                     * y otro a la derecha. El izquierdo se añadirá al grafo de busqueda
                     * y se proseguirá como si el derecho fuera el trapecio (nodo) actual
                     */

                    // Dividiendo el trapecio actual
                    TMPoint leftp_A = T.LeftP;
                    TMPoint rightp_A = S.Point_1;
                    TMPoint top_left_A = T.Top_Left;
                    var top_rigth_A = new TMPoint(S.Point_1.X, T.Top.eval(S.Point_1.X), T.Top_Left.ID);
                    TMPoint bottom_left_A = T.Bottom_Left;
                    var bottom_right_A = new TMPoint(S.Point_1.X, T.Bottom.eval(S.Point_1.X), T.LeftP.ID);
                    
                    // Creando el nodo P que tendrá a la derecha el nuevo trapecio actual 
                    // y a la izquierda el que no se analizará mas
                    TMNode P = new TMPNode(S.Point_1);
                    var A = new TMTrapezoid(leftp_A, rightp_A, top_left_A, top_rigth_A, bottom_left_A, bottom_right_A);
                    P.Node_Left = new TMANode(A);
                    if (padres != null)
                    {                        
                        foreach(TMNode padre in padres)
                            // El nodo padre en la posicion que esta Delta_node, pon a P
                            padre[padre.node_type(Delta_node)] = P;
                        padres = new List<TMNode> {P};
                    }// else Hay que ver el caso de que Delta sea el primer trapecio, que este:
                    else 
                    { 
                        // luego se conectará con Q y se retornarán a traves de "primero"
                        padres = new List<TMNode> {P};
                        this.Root = P;
                    }
                    // Dejar en T en trapecio que se analizará ahora.
                    T = new TMTrapezoid(S.Point_1, T.RightP, top_rigth_A, T.Top_Right, bottom_right_A, T.Bottom_Right);
                    // El ndodo actual es el trapecio de la derecha
                    Delta_node = new TMANode(T);
                    P.Node_Rigth = Delta_node;
                }
                #endregion
                #region right-end-point de Si dentro del ultimo trapecio
                if (i == Delta.Count - 1 && S.Point_2.X < T.RightP.X)
                {
                    /*
                     * En este bloque se construirá un trapecio a la izquierda del punto 
                     * y otro a la derecha. El derecho se añadirá al grafo de busqueda
                     * y se proseguirá como si el izquierdo fuera el trapecio (nodo) actual
                     */
                    TMPoint rightp_D = T.RightP;
                    TMPoint leftp_D = S.Point_2;
                    TMPoint top_right_D = T.Top_Right;
                    var top_left_D = new TMPoint(S.Point_2.X, T.Top.eval(S.Point_2.X), T.Top_Right.ID);
                    TMPoint bottom_right_D = T.Bottom_Right;
                    var bottom_left_D = new TMPoint(S.Point_2.X, T.Bottom.eval(S.Point_2.X), T.Bottom_Right.ID);
                 
                    TMNode Q = new TMPNode(S.Point_2);
                    var D = new TMTrapezoid(leftp_D, rightp_D, top_left_D, top_right_D, bottom_left_D, bottom_right_D);
                    Q.Node_Rigth = new TMANode(D);
                    if (padres != null)
                    {
                        foreach (TMNode padre in padres)
                            // El nodo padre en la posicion que esta Delta_node, pon a Q
                            padre[padre.node_type(Delta_node)] = Q;
                        padres = new List<TMNode> {Q};
                    }// else Hay que ver el caso de que Delta sea el primer trapecio, que es este:
                    else 
                    {
                        padres = new List<TMNode> {Q};
                        //padre.Node_Rigth = Q; 
                    }

                    // Dejar en T en trapecio que se analizará ahora.
                    T = new TMTrapezoid(T.LeftP, S.Point_2, T.Top_Left, top_left_D, T.Bottom_Left, bottom_left_D);
                    Delta_node = new TMANode(T);
                    Q.Node_Left = Delta_node;
                }
                #endregion

                // El trapecio actual se remplazará por el segmento S
                // Hay que actualizar ese cambio en todos los padres del trapecio 
                var Sn = new TMSNode(S);
                foreach (TMNode padre in padres)
                {
                    padre[padre.node_type(Delta_node)] = Sn;
                }
                //Delta_node = Sn;
                
                // A1 y A2 son los trapecios que se iran construyendo mientras pasamos por los trapecios DELTA
                // La informacion d ela izquierda es la que se llena al principio (aqui)
                // Cuando ya un trapecio esta completo, se le actualiza la parte derecha en (*)
                if (A1 == null || A2 == null)
                {
                    TMPoint top_left_arriba = T.Top_Left;
                    TMPoint top_right_arriba = T.Top_Right;
                    TMPoint intercept_left = (T.LeftP != null && T.LeftP.Equals(S.Point_1)) ? T.LeftP : new TMPoint(T.LeftP.X, S.eval(T.LeftP.X), S.Point_1.ID);
                    TMPoint intercept_right = (T.RightP != null && T.RightP.Equals(S.Point_2)) ? T.RightP : new TMPoint(T.RightP.X, S.eval(T.RightP.X), S.Point_1.ID);
                    TMPoint bottom_left_abajo = T.Bottom_Left;
                    TMPoint bottom_right_abajo = T.Bottom_Right;

                    TMPoint leftp_arriba = (intercept_left.Y > T.LeftP.Y) ? null : T.LeftP;     //intercept_left : T.LeftP;
                    TMPoint leftp_abajo = (intercept_left.Y < T.LeftP.Y) ? null : T.LeftP;      //intercept_left : T.LeftP;
                    TMPoint rightp_arriba = (intercept_right.Y > T.RightP.Y) ? null : T.RightP; //intercept_right : T.RightP;
                    TMPoint rightp_abajo = (intercept_right.Y < T.RightP.Y) ? null : T.RightP;  //intercept_right;

                    if (A1 == null)
                    {
                        A1 = new TMTrapezoid(leftp_arriba, rightp_arriba, top_left_arriba, top_right_arriba, intercept_left, intercept_right);
                        a1_padres = new List<TMNode>();
                    }
                    if (A2 == null)
                    {
                        A2 = new TMTrapezoid(leftp_abajo, rightp_abajo, intercept_left, intercept_right, bottom_left_abajo, bottom_right_abajo);
                        a2_padres = new List<TMNode>();
                    }
                }

                // En este bloque se verifica que trapecio está completo ya
                bool a1_completo = (A1.LeftP != null && 
                                    ((S.porDebajoDe(A1.LeftP) || A1.LeftP.Equals(S.Point_1))&&
                                     (S.porDebajoDe(T.RightP) || T.RightP.Equals(S.Point_2))));
                bool a2_completo = (A2.LeftP != null && 
                                    ((S.porEncimaDe(A2.LeftP) || A2.LeftP.Equals(S.Point_1))&&
                                     (S.porEncimaDe(T.RightP) || T.RightP.Equals(S.Point_2))));


                if (a1_completo) //(*)
                {
                    A1.RightP = T.RightP;
                    A1.Top_Right = T.Top_Right;
                    A1.Bottom_Right = new TMPoint(T.RightP.X, S.eval(T.RightP.X), S.Point_2.ID);
                    a1_padres.Add(Sn); 
                    // Asignarlo como hijo izquierdo del nodo correspondiente;                    
                    var A1_node = new TMANode(A1);
                    foreach (TMNode padre in a1_padres)
                        padre.Node_Left = A1_node;
                    A1 = null;
                }
                else a1_padres.Add(Sn);

                if (a2_completo) //(*)
                {
                    A2.RightP = T.RightP;
                    A2.Bottom_Right = T.Bottom_Right;
                    A2.Top_Right = new TMPoint(T.RightP.X, S.eval(T.RightP.X), S.Point_2.ID);
                    a2_padres.Add(Sn);
                    // Asignarlo como hijo derecho del nodo correspondiente;                    
                    var A2_node = new TMANode(A2);
                    foreach (TMNode padre in a2_padres)
                        padre.Node_Rigth = A2_node;
                    A2 = null;
                }
                else a2_padres.Add(Sn);
            }
        }

        /// <summary>
        /// Este método retorna los trapecios que estan en la estructura, pero discriminando los que caracterizan el 
        /// interior de los obstáculos
        /// </summary>
        /// <returns></returns>
        public List<TMTrapezoid> lista_trapecios_exteriores()
        {
            var trapecios = new List<TMTrapezoid>();
            lista_trapecios_exteriores_recursivo(this.Root, trapecios);
            return trapecios;
        }
        private static void lista_trapecios_exteriores_recursivo(TMNode node, List<TMTrapezoid> trapecios)
        {
            if (node is TMANode)
            {
                if (((TMANode)node).Trap.Interior)
                    trapecios.Add(((TMANode)node).Trap);
            }
            else
            {
                lista_trapecios_exteriores_recursivo(node.Node_Left, trapecios);
                lista_trapecios_exteriores_recursivo(node.Node_Rigth, trapecios);
            }
        }

        public List<TMTrapezoid> lista_trapecios()
        {
            var trapecios = new List<TMTrapezoid>();
            lista_trapecios_recursivo(this.Root, trapecios);
            return trapecios;
        }

        private static void lista_trapecios_recursivo(TMNode node, List<TMTrapezoid> trapecios)
        {
            if (node is TMANode)
                trapecios.Add(((TMANode)node).Trap);
            else 
            {
                lista_trapecios_recursivo(node.Node_Left, trapecios);
                lista_trapecios_recursivo(node.Node_Rigth, trapecios);
            }
        }
    }   
}
