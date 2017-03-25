using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;
using System.Windows.Forms;
using TrapezoidalMap;
using TrajectoryMap;
using Optimization;

namespace PathPlaning
{
    public class Aplicador
    {

        #region Propiedades 
        ZedGraphControl zgc;
        TreeView tv;
        ToolStripProgressBar progres_bar;

        private TMPoligonList obstaculos;
        private TMPoint objetivo;
        private TMObstacleSystem sistema_obstaculos;
        private TMPoligon universe;
        private TMSearchGraph grafo_busqueda;
        private List<TMTrapezoid> C_Free;
        TRTrajectoryGraph grafo_trayectorias;
        List<TMPoint> arm;
        List<List<TRNode>> optimal_path;
        int index_path;
        private Configuracion config;
        public Configuracion Configuracion
        {
            get { return this.config; }
        }
        #endregion

        public Aplicador(ZedGraphControl zgc, TreeView tv, ToolStripProgressBar prog_bar)
        {
            this.config = new Configuracion();
            this.tv = tv;
            this.zgc = zgc;
            this.progres_bar = prog_bar;
            optimal_path = new List<List<TRNode>>();
            Cargar_Ejemplo1();
        }
        #region Ejemplos
        public void ejemplo_trapecios(ZedGraphControl zgc)
        {
            // P1 = ejemplo_punto(10, 30)
            TMPoint P1 = new TMPoint(10, 30);
            // A = ejemplo_trapecio(0, 60, 10, 60,      0, 0, 10, 0,          0, 0, 10, 30);
            TMTrapezoid A = new TMTrapezoid(new TMPoint(0, 0), new TMPoint(10, 30),
                                            new TMPoint(0, 60), new TMPoint(10, 60), new TMPoint(0, 0), new TMPoint(10, 0));
            // Q1 = ejemplo_punto(40, 50);
            TMPoint Q1 = new TMPoint(40, 50);
            // S1 = ejemplo_segmento(P1, Q1);
            TMSegment S1 = new TMSegment(P1, Q1);
            // B = ejemplo_trapecio(10, 60, 40, 60,    10, 30, 40, 50,      10, 30, 40, 50);
            TMTrapezoid B = new TMTrapezoid(new TMPoint(10, 30), new TMPoint(40, 50),
                                            new TMPoint(10, 60), new TMPoint(40, 60), new TMPoint(10, 30), new TMPoint(40, 50));
            // P2 = ejemplo_punto(20, 20);
            TMPoint P2 = new TMPoint(20, 20);
            // C = ejemplo_trapecio(10, 30, 20, evalua_recta(S1, 20),    10, 0, 20, 0,     P1.x, P1.y, P2.x, P2.y);
            TMTrapezoid C = new TMTrapezoid(P1, P2,
                                            new TMPoint(10, 30), new TMPoint(20, S1.eval(20)), new TMPoint(10, 0), new TMPoint(20, 0));
            // Q2 = ejemplo_punto(50, 10);
            TMPoint Q2 = new TMPoint(50, 10);
            // S2 = ejemplo_segmento(P2, Q2);
            TMSegment S2 = new TMSegment(P2, Q2);
            // D = ejemplo_trapecio(20, evalua_recta(S1, 20), 40, 50,    20, 20, 40, evalua_recta(S21, 40),     P2.x, P2.y, Q1.x, Q1.y);
            TMTrapezoid D = new TMTrapezoid(P2, Q1,
                                            new TMPoint(20, S1.eval(20)), new TMPoint(40, 50), new TMPoint(20, 20), new TMPoint(40, S2.eval(40)));
            // F = ejemplo_trapecio(P2.x, P2.y, Q2.x, Q2.y,    20, 0, 50, 0,    P2.x, P2.y, Q2.x, Q2.y);
            TMTrapezoid F = new TMTrapezoid(P2, Q2, P2, Q2, new TMPoint(20, 0), new TMPoint(50, 0));
            // E = ejemplo_trapecio(40, 60, 50, 60,     40, evalua_recta(S21, 40), Q2.x, Q2.y,    Q1.x, Q1.y, Q2.x, Q2.y);
            TMTrapezoid E = new TMTrapezoid(Q1, Q2, new TMPoint(40, 60), new TMPoint(50, 60), new TMPoint(40, S2.eval(40)), Q2);
            // G = ejemplo_trapecio(50, 60, 60, 60,         50, 0, 60, 0,     Q2.x, Q2.y, 60, 60);
            TMTrapezoid G = new TMTrapezoid(Q2, new TMPoint(60, 60),
                                            new TMPoint(50, 60), new TMPoint(60, 60), new TMPoint(50, 0), new TMPoint(60, 0));
            // Enlaces
            //TMPNode nP1 = new TMPNode(P1);
            //TMANode nA = new TMANode(A);
            //TMPNode nQ1 = new TMPNode(Q1);
            //TMSNode nS1 = new TMSNode(S1);
            //TMANode nB = new TMANode(B);
            //TMPNode nP2 = new TMPNode(P2);
            //TMANode nC = new TMANode(C);
            //TMSNode nS21 = new TMSNode(S2);
            //TMANode nD = new TMANode(D);
            //TMANode nF = new TMANode(F);
            //TMPNode nQ2 = new TMPNode(Q2);
            //TMANode nG = new TMANode(G);
            //TMSNode nS22 = new TMSNode(S2);
            //TMANode nE = new TMANode(E);
                        
            //nS21.Node_Left = nD;        //S21.node_izq = D;
            //nS21.Node_Rigth = nF;       //S21.node_der = F;
            //nS22.Node_Left = nE;        //S22.node_izq = E;
            //nS22.Node_Rigth = nF;       //S22.node_der = F;
            //nQ2.Node_Left = nS22;       //Q2.node_izq = S22;
            //nQ2.Node_Rigth = nG;        //Q2.node_der = G;
            //nP2.Node_Left = nC;         //P2.node_izq = C;
            //nP2.Node_Rigth = nS21;      //P2.node_der = S21;
            //nS1.Node_Left = nB;         //S1.node_izq = B;
            //nS1.Node_Rigth = nP2;       //S1.node_der = P2;
            //nQ1.Node_Left = nS1;        //Q1.node_izq = S1;
            //nQ1.Node_Rigth = nQ2;       //Q1.node_der = Q2;
            //nP1.Node_Left = nA;         //P1.node_izq = A;
            //nP1.Node_Rigth = nQ1;       //P1.node_der = Q1;

            //GraphPane pane = zgc.GraphPane;
            //pane.Title.Text = "Ejemplo del libro";
            //pane.XAxis.Title.Text =  "X Axis";
            //pane.YAxis.Title.Text = "Y Axis";           
             
            //plotTrapezoid(pane, A, B, C, D, E, F, G);
            //plotSegment(pane, S1, S2);
            //plotdot(pane, P1, P2, Q1, Q2);

            //TMTrapezoid R = new TMTrapezoid(new TMPoint(0, 0), new TMPoint(100, 100),
            //                                new TMPoint(0, 100), new TMPoint(100, 100),
            //                                new TMPoint(0, 0), new TMPoint(100, 0));
            //TMANode R_ = new TMANode(R);
            //List<TMNode> T = new List<TMNode>();
            //T.Add(R_);
            //TMPoint ps1 = new TMPoint(15, 25);
            //TMPoint ps2 = new TMPoint(45, 35);
            //TMSegment SS = new TMSegment(ps1, ps2);

            //TMSearchGraph DD = new TMSearchGraph(nP1);
            //T = DD.follow_segment(SS);
            //descubre_trapecio(pane, T.ToArray());

            //zgc.AxisChange();
        }
        private TMPoligonList ejemplo1(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 40, 110, 100, 50 }, new double[] { 40, 40, 60, 60 });
            TMPoligon S2 = new TMPoligon(2, new double[] { 75, 90, 60 }, new double[] { 20, 30, 30 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1); l.Add(S2);
            obj = new TMPoint(100, 35);
            double[] x_chain = new double[] { 0, 5, 20 };
            double[] y_chain = new double[] { 0, 50, 20 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo2(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 30, 40, 20 }, new double[] { 30, 50, 50 });
            TMPoligon S2 = new TMPoligon(2, new double[] { 50, 70, 60 }, new double[] { 30, 30, 50 });
            TMPoligon S3 = new TMPoligon(2, new double[] { 100, 110, 80 }, new double[] { 30, 50, 50 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1); l.Add(S2); l.Add(S3);
            obj = new TMPoint(45, 45);
            double[] x_chain = new double[] { 0, 5, 20 };
            double[] y_chain = new double[] { 0, 50, 20 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo3(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] {50, 80, 70, 40 }, new double[] { 40, 50, 70, 60 });
            TMPoligon S2 = new TMPoligon(2, new double[] { 85, 120, 110 }, new double[] { 47, 50, 70 });
            TMPoligon S3 = new TMPoligon(3, new double[] { 60, 90, 100, 65 }, new double[] { 20, 20, 40, 40 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1); l.Add(S2); l.Add(S3);
            obj = new TMPoint(80, 45);
            double[] x_chain = new double[] { 0, 5, 20 };
            double[] y_chain = new double[] { 0, 50, 20 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo4(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 33, 63, 60, 30 }, new double[] { 17, 60, 63, 20 });            
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1); 
            obj = new TMPoint(70, 55);
            double[] x_chain = new double[] { 0, 10, 25 };
            double[] y_chain = new double[] { 0, 50, 15 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo5(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 60, 90, 80, 50 }, new double[] { 30, 30, 43, 43 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1);
            obj = new TMPoint(75, 23);
            double[] x_chain = new double[] { 0, 10, 47 };
            double[] y_chain = new double[] { 0, 50, 50 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo6(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 40, 50, 30 }, new double[] { 30, 50, 50 });
            TMPoligon S2 = new TMPoligon(2, new double[] { 90, 110, 80 }, new double[] { 30, 30, 60 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1);
            l.Add(S2);
            obj = new TMPoint(70, 50);
            double[] x_chain = new double[] { 0, 10, 15, 20 };
            double[] y_chain = new double[] { 0, 30, 6, 55 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            arm.Add(new TMPoint(x_chain[3], y_chain[3]));
            return new TMPoligonList(l);
        }
        private TMPoligonList ejemplo7(out TMPoligon universe, out TMPoint obj)
        {
            universe = new TMPoligon(0, new double[] { 0, 140, 140, 0 }, new double[] { 0, 0, 80, 80 });
            TMPoligon S1 = new TMPoligon(1, new double[] { 40, 100, 90, 50 }, new double[] { 40, 40, 60, 60 });
            List<TMPoligon> l = new List<TMPoligon>();
            l.Add(S1);
            obj = new TMPoint(70, 67);
            double[] x_chain = new double[] { 0, 10, 43 };
            double[] y_chain = new double[] { 0, 60, 30 };
            arm = new List<TMPoint>();
            arm.Add(new TMPoint(x_chain[0], y_chain[0]));
            arm.Add(new TMPoint(x_chain[1], y_chain[1]));
            arm.Add(new TMPoint(x_chain[2], y_chain[2]));
            return new TMPoligonList(l);
        }

        public void Cargar_Ejemplo1()
        {
            this.obstaculos = ejemplo1(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        public void Cargar_Ejemplo2()
        {
            this.obstaculos = ejemplo2(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        public void Cargar_Ejemplo3()
        {
            this.obstaculos = ejemplo3(out this.universe, out this.objetivo);
            cargar_ejemplos();            
        }
        public void Cargar_Ejemplo4()
        {
            this.obstaculos = ejemplo4(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        public void Cargar_Ejemplo5()
        {
            this.obstaculos = ejemplo5(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        public void Cargar_Ejemplo6()
        {
            this.obstaculos = ejemplo6(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        public void Cargar_Ejemplo7()
        {
            this.obstaculos = ejemplo7(out this.universe, out this.objetivo);
            cargar_ejemplos();
        }
        /// <summary>
        /// Los ejemplos del 1 al 4 son no alcanzables
        /// Del 5 al 7 son alcanzables. Los poligonos se construyen comenzando por el vertice que menos coordenada
        /// "Y" tenga (menor "X" en caso de empate) y siguiendo el orden inverso de las manesillas del reloj
        /// </summary>
        private void cargar_ejemplos()
        {
            this.sistema_obstaculos = new TMObstacleSystem(this.obstaculos);
            C_Free = this.sistema_obstaculos.freeConfigurationSpace(universe, out this.grafo_busqueda);
            GraphPane pane = zgc.GraphPane;
            zgc.AxisChange();
            relena_Arbol(tv, this.grafo_busqueda.Root);
            TMPoint end_efector = new TMPoint(5, 40);
            grafo_trayectorias = new TREXT_TrajectoryGraph(this.grafo_busqueda, end_efector, this.objetivo, config.TR_Separacion_Obstaculos);
            optimal_path = new List<List<TRNode>>();
            optimizar_camino();
            this.index_path = 0;
            Publica_lo_basico();
        }
        private void optimizar_camino()
        {
            OptimalPath op = new OptimalPath();
            do
            {                
                double[] eps = new double[] { config.OPT_Gradiente_EPS, config.OPT_Funcion_EPS, config.OPT_Punto_EPS };
                List<TRNode> current = grafo_trayectorias.Current;
                string msg = "";
                optimal_path.Add(op.GetOptimalPathOf(current, eps, config.OPT_Maximo_iteraciones, out msg));
            } while (grafo_trayectorias.MoveNext());
        }

        public string Proximas_Secuencias_de_movimiento(ListBox lb_distancias, ListBox lb_iteraciones)
        {
            if (this.optimal_path != null && this.optimal_path.Count != 0 && this.index_path != -1)
            {
                List<TRNode> temp_path = this.optimal_path[index_path++];
                temp_path.Insert(0, new TRNode(this.arm[this.arm.Count - 1]));
                List<TRNode> current_path = TREXT_TrajectoryGraph.GetThinPartition(temp_path, this.config.TR_Separacion_entre_nodos);
                Publica_lo_basico();
                this.progres_bar.Visible = true;
                this.progres_bar.Maximum = current_path.Count;                
                
                ParticleFilter pf = new ParticleFilter();                
                List<TMPoint> chain_result = null;
                int iteraciones = 0;
                double distancia = 0;
                this.progres_bar.Minimum = 0;

                #region codigo para verificar en matlab
                //string s_matlab = "[" + current_path[0].Point.X.ToString() + "," + current_path[0].Point.Y.ToString();
                //for (int i = 1; i < current_path.Count; i++)
                //{
                //    string x_pe = Math.Floor(current_path[i].Point.X).ToString();
                //    string x_pf = (current_path[i].Point.X - Math.Floor(current_path[i].Point.X)).ToString();
                //    if(x_pf != "0")
                //        x_pf = x_pf.Substring(2);
                //    string sx = x_pe + "." + x_pf;

                //    string y_pe = Math.Floor(current_path[i].Point.Y).ToString();
                //    string y_pf = (current_path[i].Point.Y - Math.Floor(current_path[i].Point.Y)).ToString();
                //    if (y_pf != "0")
                //        y_pf = y_pf.Substring(2);
                //    string sy = y_pe + "." + y_pf;

                //    s_matlab += "; " + sx + "," + sy;
                //}
                //s_matlab += "]";
                #endregion

                List<TMPoint> temp_arm = this.arm;
                //for (int i = index_firts_node; i < current_path.Count; i++)
                for (int i = 0; i < current_path.Count; i++)
                {
                    this.progres_bar.Increment(1);
                    bool llego = pf.Filter(out chain_result, out iteraciones, out distancia, config.OPT_Maximo_iteraciones, config.PF_Epsilon, this.sistema_obstaculos, temp_arm, current_path[i].Point, config.PF_Numero_muestras, config.PF_Media_Gausiana);
                    Publicar_Brazo(chain_result);

                    lb_distancias.Items.Add(distancia);
                    string sllega = (llego) ? "SI" : "NO";
                    lb_iteraciones.Items.Add(iteraciones.ToString() + " - " + sllega);
                    temp_arm = chain_result;
                }
                if (index_path >= optimal_path.Count) this.index_path = -1;
                this.progres_bar.Visible = false;
                return "OK";
            }
            else
            {
                return "Se han terminado los caminos posibles a seguir";
            }
        }

        #region Publicar

        private void Publica_lo_basico()
        {
            this.zgc.GraphPane.CurveList.Clear();
            this.zgc.Refresh();
            Publicar_Universo();
            Publicar_Obstáculos();
            publicar_Objetivo();
            Publicar_Brazo(arm);
        }
        public void Publicar_Universo()
        {
            GraphPane pane = zgc.GraphPane;
            foreach (TMSegment seg in this.universe.Segments)
            {
                double[] x = new double[] { seg.Point_1.X, seg.Point_2.X };
                double[] y = new double[] { seg.Point_1.Y, seg.Point_2.Y };
                pane.AddCurve(null, x, y, Color.Black, SymbolType.None);
            }
            zgc.AxisChange();
        }
        public void Publicar_Obstáculos()
        {
            GraphPane pane = zgc.GraphPane;            
            
            foreach (TMPoligon pol in this.obstaculos.Poligons)
	        {
                foreach (TMSegment seg in pol.Segments)
	            {
                    double[] x = new double[] { seg.Point_1.X, seg.Point_2.X };
                    double[] y = new double[] { seg.Point_1.Y, seg.Point_2.Y };                    
                    pane.AddCurve(null, x, y, Color.Black, SymbolType.None);
	            }
	        }
            zgc.AxisChange();
        }
        public void Publicar_Mapa_Trapezoidal()
        {
            GraphPane pane = zgc.GraphPane;
            plotTrapezoid(pane, this.C_Free.ToArray());
        }
        public void Publicar_Mapa_Trayectoria()
        {
            GraphPane pane = zgc.GraphPane;
            grafo_trayectorias.Reset();
            int id = 1;
            do
            {
                Color c = Color.Blue;
                descubre_trayectoria(pane, grafo_trayectorias.Current, c, id++);
            } while (grafo_trayectorias.MoveNext());
        }
        private void Publicar_Brazo(double[] x_chain, double[] y_chain)
        {
            GraphPane pane = zgc.GraphPane;
            pane.AddCurve(null, x_chain, y_chain, Color.Red, SymbolType.None);
            pane.AddCurve(null, new double[] { x_chain[x_chain.Length - 1] }, new double[] { y_chain[y_chain.Length - 1] }, Color.Red, SymbolType.Circle);
        }
        private void Publicar_Brazo(List<TMPoint> chain_result)
        {
            GraphPane pane = zgc.GraphPane;
            double[] x_chain = new double[chain_result.Count];
            double[] y_chain = new double[chain_result.Count];
            for (int i = 0; i < chain_result.Count; i++)
            {
                x_chain[i] = chain_result[i].X;
                y_chain[i] = chain_result[i].Y;
            }
            pane.AddCurve(null, x_chain, y_chain, Color.Red, SymbolType.None);
            pane.AddCurve(null, new double[] { x_chain[x_chain.Length - 1] }, new double[] { y_chain[y_chain.Length - 1] }, Color.Red, SymbolType.Circle);
            this.zgc.Refresh();
        }
        public void Publicar_Mapa_Trayectoria_Optima()
        {
            GraphPane pane = zgc.GraphPane;
            grafo_trayectorias.Reset();
            OptimalPath op = new OptimalPath();
            int id = 1;
            foreach (List<TRNode> l_nodes in optimal_path)
            {
                Color c = Color.Purple;
                descubre_trayectoria(pane, l_nodes, c, id++);
            }            
        }

        public void Publicar_Rango_Nodos()
        {
            GraphPane pane = zgc.GraphPane;
            grafo_trayectorias.Reset();
            int id = 1;
            do
            {                
                Color c = Color.Blue;
                descubre_rangos(pane, grafo_trayectorias.Current, c, id++);
            } while (grafo_trayectorias.MoveNext());
        }
        private void publicar_Objetivo()
        {
            GraphPane pane = zgc.GraphPane;
            LineItem curve;
            curve = pane.AddCurve(null, new double[] { objetivo.X }, new double[] { objetivo.Y }, Color.Blue, SymbolType.Square);            
        }
        #endregion
        #endregion

        #region metodos privados

        private void relena_Arbol(TreeView tv, TMNode node)
        {
            TreeNode n_right = rellena_recursivo(node.Node_Rigth);
            TreeNode n_left  = rellena_recursivo(node.Node_Left);
            TreeNode n = new TreeNode(node.ToString(), new TreeNode[] { n_left, n_right });
            tv.Nodes.Add(n);
        }

        private TreeNode rellena_recursivo(TMNode node)
        {
            if (node is TMANode)
                return new TreeNode(node.ToString());
            else 
            {
                if (node.Node_Rigth == null)
                    Application.Exit();
                if (node.Node_Left == null)
                    Application.Exit();
                TreeNode n_right = rellena_recursivo(node.Node_Rigth);
                TreeNode n_left = rellena_recursivo(node.Node_Left);
                return new TreeNode(node.ToString(), new TreeNode[] { n_left, n_right });
            }
        }
        
        private void plotdot(GraphPane pane, params TMPoint[] L)
        {
            LineItem curve;
            for (int i = 0; i < L.Length; i++)
            {
                double[] x = new double[] { L[i].X };
                double[] y = new double[] { L[i].Y };
                curve = pane.AddCurve(null, x, y, Color.Red, SymbolType.Circle);
            }
        }

        private void plotSegment(GraphPane pane, params TMSegment[] L)
        {
            LineItem curve;
            for (int i = 0; i < L.Length; i++)
            {
                double[] x = new double[] { L[i].Point_1.X, L[i].Point_2.X};
                double[] y = new double[] { L[i].Point_1.Y, L[i].Point_2.Y };
                curve = pane.AddCurve(null, x, y, Color.Blue, SymbolType.Circle);
            }
        }

        private void plotTrapezoid(GraphPane pane, params TMTrapezoid[] L)
        {
            LineItem curve;
            for (int i = 0; i < L.Length; i++)
            {
                double[] x = new double[] { L[i].Top_Left.X, L[i].Top_Right.X, L[i].Bottom_Right.X, L[i].Bottom_Left.X, L[i].Top_Left.X };
                double[] y = new double[] { L[i].Top_Left.Y, L[i].Top_Right.Y, L[i].Bottom_Right.Y, L[i].Bottom_Left.Y, L[i].Top_Left.Y};
                curve = pane.AddCurve(null,x, y, Color.Green, SymbolType.None);
            }
        }
        private void descubre_trayectoria(GraphPane pane, List<TRNode> points, Color c, int id)
        {
            double[] xx = new double[points.Count];
            double[] yy = new double[points.Count];
            for (int i = 0; i < points.Count; i++)
            {
                xx[i] = points[i].Point.X;
                yy[i] = points[i].Point.Y;
            }
            pane.AddCurve(null, xx, yy, c, SymbolType.Diamond);
        }
        private void descubre_rangos(GraphPane pane, List<TRNode> points, Color c, int id)
        {            
            for (int i = 0; i < points.Count; i++)
            {
                double[] x_rango = new double[] { points[i].Point.X, points[i].Point.X };
                double[] y_rango = new double[] { points[i].Y_Range.Y_Max, points[i].Y_Range.Y_Min };
                pane.AddCurve(null, x_rango, y_rango, Color.Red, SymbolType.None);
            }
        }
        private void descubre_trapecio(GraphPane pane, params TMTrapezoid[] L)
        {
            LineItem curve;
            for (int i = 0; i < L.Length; i++)
            {
                TMTrapezoid T = L[i];
                TMPoint p = T.Centro;
                curve = pane.AddCurve(null, new double[]{p.X}, new double[]{p.Y}, Color.Blue, SymbolType.Circle);
            }
        }
        #endregion
        
    }
}
