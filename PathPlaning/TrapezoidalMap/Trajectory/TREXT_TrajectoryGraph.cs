using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TREXT_TrajectoryGraph : TRTrajectoryGraph
    {
        public TREXT_TrajectoryGraph(TMSearchGraph D, TMPoint end_efector, double seps)
            : base(D, end_efector, seps)
        { }

        public List<TRNode> GetThinPartition(double eps)
        {
            List<TRNode> ext = null;
            if (this.current != null && this.current.Count > 0)
            {
                ext = new List<TRNode>();
                ext.Add(this.current[0]);
                TRNode node_actual = this.current[0];
                for (int i = 1; i < this.current.Count; i++)
                {
                    TMSegment puente = new TMSegment(node_actual.Point, this.current[i].Point);
                    double dx = hipotenusa(puente, eps);
                    int k = 1;
                    while (node_actual.Point.X + k*dx < this.current[i].Point.X)
                    { 
                        double inter_x = node_actual.Point.X + k * dx;
                        TMPoint p_intermedio = new TMPoint(inter_x, puente.eval(inter_x));
                        ext.Add(new TRNode(p_intermedio));
                        k++;
                    }
                    ext.Add(new TRNode(this.current[i].Point));
                    node_actual = this.current[i];
                }
            }
            return ext;
        }

        private double hipotenusa(TMSegment puente, double eps)
        {
            double numerador = eps * puente.Point_2.X * puente.Point_2.X - eps * puente.Point_1.X * puente.Point_1.X;
            double denominador = puente.Longitud * (puente.Point_2.X + puente.Point_1.X);
            return numerador / denominador;
        }
    }
}
