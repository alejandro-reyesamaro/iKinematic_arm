using System;
using System.Collections.Generic;

namespace CS_ParticleFilter
{
    public class Obstaculo
    {
        public double[] xVector { get; set; }
        public double[] yVector { get; set; }

        public Obstaculo(List<PointD> points)
        {
            this.xVector = new double[points.Count];
            this.yVector = new double[points.Count];
            for (int i = 0; i < points.Count; i++)
            {
                xVector[i] = points[i].X;
                yVector[i] = points[i].Y;
            }
        }

        public Obstaculo(double[] x_puntos, double[] y_puntos)
        {
            this.xVector = x_puntos;
            this.yVector = y_puntos;
        }

        public bool Dentro(PointD p)
        {
            // Esta funcionnos dir'a si un punto est'a dentrode unpoligono(convexo)
            int ptos = xVector.Length;
            int cayo_dentro = 0;
            int esta_entre = 0;
            for (int i = 0; i < ptos; i ++)
            {
                double s_p1_x = xVector[i];
                double s_p1_y = yVector[i];
                double s_p2_x;
                double s_p2_y;
                if(i == ptos - 1)
                {
                    s_p2_x = xVector[0];
                    s_p2_y = yVector[0];
                }
                else
                {
                    s_p2_x = xVector[i+1];
                    s_p2_y = yVector[i+1];
                }
                var S = new Segment(new PointD(s_p1_x, s_p1_y), new PointD(s_p2_x, s_p2_y));
                int edos = S.Entredos(p);
                cayo_dentro = cayo_dentro + Math.Abs(edos);
                esta_entre = esta_entre + edos;
            }

            return cayo_dentro > 0 && esta_entre == 0;
        }

        public Obstaculo obstaculo_crecido(Segment a)
        {
            /* Esta función calcula espacio prohibido de configuraciones de un brazo
             * mecanico representado por el segmento "a".El resultado es una lista de
             * puntos que representan el obstáculo crecido
             */

            int i = 0;
            int j = 0;
            int n = 2;
            int m = xVector.Length;
            var V = new[]{a.P1, a.P2, a.P1, a.P2, a.P1, a.P2};
            var WX = new double[xVector.Length + 1];// [ L_puntos L_puntos(1)]
            for (int k = 0; k < xVector.Length; k++)
                WX[k] = xVector[k];
            WX[xVector.Length] = xVector[0];
            var WY = new double[yVector.Length + 1];// [ L_puntos L_puntos(1)]
            for (int k = 0; k < yVector.Length; k++)
                WY[k] = yVector[k];
            WY[yVector.Length] = yVector[0];

            var RmasP = new List<PointD>();
            PointD p_suma = V[i] + new PointD(WX[j], WY[j]);
            RmasP.Add(p_suma);

            double angV = Segment.Angulo(V[i], V[i + 1], 0);
            double angW = Segment.Angulo(new PointD(WX[j], WY[j]), new PointD(WX[j + 1], WY[j + 1]), 0);
            
            if (angV < angW)
                i = i + 1;
            else if (angV > angW)
                j = j + 1;
            else
            {
                i = i + 1;
                j = j + 1;
            }

            while (i + 1 < n + 2 && j + 1 < m + 2)
            {
                p_suma = V[i] + new PointD(WX[j], WY[j]);
                RmasP.Add(p_suma);

                //if (i >= n || j >= m)
                if (i + 1 > n || j + 1 > m)
                    break;
                
                double angV_ = Segment.Angulo(V[i], V[i + 1], angV);
                double angW_ = Segment.Angulo(new PointD(WX[j], WY[j]), new PointD(WX[j+1], WY[j+1]), angW);

                if (angV_ < angW_)
                    i = i + 1;
                else if (angV_ > angW_)
                    j = j + 1;
                else
                {
                    i = i + 1;
                    j = j + 1;
                }

                angV = angV_;
                angW = angW_;

            }
            return new Obstaculo(RmasP);
        }

    }
}
