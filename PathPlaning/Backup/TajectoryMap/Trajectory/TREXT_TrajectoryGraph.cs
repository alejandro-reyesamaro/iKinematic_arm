using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrapezoidalMap;

namespace TrajectoryMap
{
    public class TREXT_TrajectoryGraph : TRTrajectoryGraph
    {
        public TREXT_TrajectoryGraph(TMSearchGraph D, TMPoint end_efector, TMPoint objetivo, double seps)
            : base(D, end_efector, objetivo, seps)
        { }

        public List<TRNode> GetThinPartition(double eps)
        {
            return TREXT_TrajectoryGraph.aux_GetThinPartition(this.current, eps);
        }
        public static List<TRNode> GetThinPartition(List<TRNode> path, double eps)
        {
            return aux_GetThinPartition(path, eps);
        }

        #region Metodos Privados
        private static List<TRNode> aux_GetThinPartition(List<TRNode> path, double eps)
        {
            List<TRNode> ext = null;
            if (path != null && path.Count > 0)
            {
                ext = new List<TRNode>();
                ext.Add(path[0]);
                TRNode node_actual = path[0];
                for (int i = 1; i < path.Count; i++)
                {
                    TRPuente puente = new TRPuente(node_actual.Point, path[i].Point);
                    double dx = delta_x(puente, eps);
                    double dy = delta_y(puente, eps);                    

                    while (norma(node_actual.Point,path[i].Point) > eps)
                    {
                        TMPoint point_actual = new TMPoint(node_actual.Point.X + dx, node_actual.Point.Y + dy);
                        node_actual = new TRNode(point_actual);                        
                        ext.Add(node_actual);
                    }

                    ext.Add(new TRNode(path[i].Point));
                    node_actual = path[i];
                }
            }
            return ext;
        }
        private static double norma(TMPoint p1, TMPoint p2)
        {
            double n = Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
            return n;
        }
        private static double delta_x(TRPuente puente, double eps)
        {
            double numerador = eps * (puente.p2.X - puente.p1.X);
            double denominador = puente.Longitud;
            return (denominador == 0) ? 0 : numerador / denominador;
        }
        private static double delta_y(TRPuente puente, double eps)
        {
            double numerador = eps * (puente.p2.Y - puente.p1.Y);
            double denominador = puente.Longitud;
            return (denominador == 0) ? 0 : numerador / denominador;
        }
        #endregion

        #region Clase iterna privada
        private class TRPuente
        {
            internal TMPoint p1, p2;
            internal TRPuente(TMPoint p1, TMPoint p2)
            {
                this.p1 = p1;
                this.p2 = p2;
            }
            internal double Longitud
            {
                get
                {
                    double dx = this.p1.X - this.p2.X;
                    double dy = this.p1.Y - this.p2.Y;
                    return Math.Sqrt(dx * dx + dy * dy);
                }
            }
        }
        #endregion
    }    
}
