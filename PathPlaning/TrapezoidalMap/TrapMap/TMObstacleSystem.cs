using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMObstacleSystem
    {
        protected TMPoligonList p_system;
        public TMPoligonList Obstacles
        {
            get { return this.p_system; }
        }

        public TMObstacleSystem(TMPoligonList l)
        {
            this.p_system = l;
        }
        public TMObstacleSystem(List<TMPoligon> poligons)
        {
            TMPoligonList l = new TMPoligonList(poligons);
            this.p_system = l;
        }        

        /// <summary>
        /// Mapa trapezoidal de un sistema de obstaculos. El universo se asume que es un poligono
        /// rectangular con los puntos ordenados comenzando por el extremos superior izquierdo y luego
        /// siguiendo el orden d elas manesillas del reloj.
        /// </summary>
        /// <param name="universe"></param>
        /// <returns></returns>
        public List<TMTrapezoid> freeConfigurationSpace(TMPoligon universe, out TMSearchGraph sg)
        {            
            //T = R;
            //% Se inicializa la estructura de búsqueda con el trapecio R como hoja.
            //D.node = 'hoja';
            //D.object = R;
            TMSearchGraph D = GetInit(universe);
            //% Permutar random el conjunto de aristas.
            List<TMSegment> S_ = this.p_system.GetRandomPermutationOfSegments();//S_ = permutar(S);

            int n = S_.Count;//n = size(S);
            for (int i = 0; i < n; i++) //for i = 1: n
            {
                //% Encontrar el conjunto de trapecios que intersecta S(i) y eliminarlos de T
                List<TMNode> Delta = D.follow_segment(S_[i]); //Delta = followSegment(D, T, S(i));
                D.actualiza_grafo_busqueda(Delta, S_[i]); //D = actualiza_grafo_busqueda(D, Delta, S(i));                
            }//end            
            List<TMTrapezoid> T = D.lista_trapecios_exteriores();//T = lista_trapecios(D);
            //List<TMTrapezoid> T = D.lista_trapecios();
            sg = D;
            return T;
        }

        

        private TMSearchGraph GetInit(TMPoligon universe)
        {
            TMTrapezoid trap = new TMTrapezoid(universe.GetPointAt(3), universe.GetPointAt(1),
                                               universe.GetPointAt(0), universe.GetPointAt(1),
                                               universe.GetPointAt(3), universe.GetPointAt(2));
            TMANode a = new TMANode(trap);
            TMSearchGraph T = new TMSearchGraph(a);
            return T;
        }

        #region _Prueba 
        /// <summary>
        /// PRUEBA.El universo se asume que es un poligono
        /// rectangular con los puntos ordenados comenzando por el extremos superior izquierdo y luego
        /// siguiendo el orden d elas manesillas del reloj.
        /// </summary>
        /// <param name="universe"></param>
        /// <returns></returns>
        public static List<TMTrapezoid> freeConfigurationSpacePrueba(TMPoligon universe, out TMNode sg)
        {
            //T = R;
            //% Se inicializa la estructura de búsqueda con el trapecio R como hoja.
            //D.node = 'hoja';
            //D.object = R;
            TMSearchGraph D = GetInitPrueba(universe);
            List<TMSegment> S_ = new List<TMSegment>();            
            
            S_.Add(new TMSegment(new TMPoint(50, 50), new TMPoint(40, 60)));
            S_.Add(new TMSegment(new TMPoint(60, 60), new TMPoint(50, 50)));
            S_.Add(new TMSegment(new TMPoint(40, 60), new TMPoint(60, 60)));
            S_.Add(new TMSegment(new TMPoint(30, 100), new TMPoint(70, 100)));
            S_.Add(new TMSegment(new TMPoint(70, 100), new TMPoint(90, 80)));
            S_.Add(new TMSegment(new TMPoint(90, 80), new TMPoint(10, 80)));
            S_.Add(new TMSegment(new TMPoint(10, 80), new TMPoint(30, 100)));

            int n = S_.Count;//n = size(S);
            for (int i = 0; i < n; i++) //for i = 1: n
            {
                //% Encontrar el conjunto de trapecios que intersecta S(i) y eliminarlos de T
                List<TMNode> Delta = D.follow_segment(S_[i]); //Delta = followSegment(D, T, S(i));                
                D.actualiza_grafo_busqueda(Delta, S_[i]); //D = actualiza_grafo_busqueda(D, Delta, S(i));                
            }//end            
            List<TMTrapezoid> T = D.lista_trapecios();//T = lista_trapecios(D);
            sg = D.Root;
            return T;
        }         

        private static TMSearchGraph GetInitPrueba(TMPoligon universe)
        {
            TMTrapezoid trap = new TMTrapezoid(universe.GetPointAt(3), universe.GetPointAt(1),
                                               universe.GetPointAt(0), universe.GetPointAt(1),
                                               universe.GetPointAt(3), universe.GetPointAt(2));
            TMANode a = new TMANode(trap);
            TMSearchGraph T = new TMSearchGraph(a);
            return T;
        }
        
        #endregion

    }
}
