using System;

namespace CS_ParticleFilter
{
    public class Segment
    {
        public PointD P1 { get; set; }
        public PointD P2 { get; set; }

        public Segment(PointD p1, PointD p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }
        
        internal int Entredos(PointD p)
        {
 	        /* Devuelve:
             * -1 si la recta est'a por debajo del punto
             * 1 si la recta est'a por encima del punto
             * 0 si el punto pertenece a la recta
             */
            int r = 0;
            if ((P1.X <= p.X && P2.X > p.X) || (P2.X <= p.X && P1.X > p.X))
            {
                double yr = Evalua(p.X);
                double rest = yr - p.Y;
                if (Math.Abs(rest) >= MathUtils.Eps)
                    r = (int) (rest/Math.Abs(rest));
            }
            return r;
        }

        private double Evalua(double x)
        {
            double m = (P1.Y - P2.Y)/(P1.X - P2.X);
            double n = P1.Y - m*P1.X;
            // Evaluar el punto dado
            return m * x + n;
        }

        public double Angulo(double antan)
        {
            return Angulo(this.P1, this.P2, antan);
        }

        public static double Angulo(PointD p1, PointD p2, double antan)
        {
            double a = 0;
            if (Math.Abs(p1.X - p2.X) < MathUtils.Eps) //cuidarme de la división por cero
                a = Math.PI / 2;
            else
            {
                double m = (p1.Y - p2.Y) / (p1.X - p2.X);
                a = Math.Atan(m);
            }
            a = a + ((a < 0) ? 1 : 0) * Math.PI + ((p1.Y > p2.Y) ? 1 : 0) * Math.PI;

            if (Math.Abs(p1.Y - p2.Y) < MathUtils.Eps && p1.X > p2.X)
                a = a + Math.PI;

            if (a != antan)
                while (a <= antan)
                    a = a + Math.PI;
            return a;
        }
    
    }
}
