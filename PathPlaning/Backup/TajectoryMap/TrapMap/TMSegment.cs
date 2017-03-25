using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMSegment
    {
        protected TMPoint p1, p2;
        protected short owner;
        /// <summary>
        /// Representará en obstáculo al que pertenece el segmento
        /// </summary>
        public short Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public TMPoint Point_1 
        {
            get { return this.p1; }
            set { this.p1 = value; }
        }
        public TMPoint Point_2
        {
            get { return this.p2; }
            set { this.p2 = value; }
        }

        public double Pendiente 
        {
            get { return (this.p1.Y - this.p2.Y) / (this.p1.X - this.p2.X); } 
        }
        public double N
        {
            get { return this.p1.Y - this.Pendiente * this.p1.X; }
        }
        public double Longitud
        {
            get 
            {
                double dx = this.Point_1.X - this.Point_2.X;
                double dy = this.Point_1.Y - this.Point_2.Y;
                return Math.Sqrt(dx*dx + dy*dy); 
            }
        }

        public TMSegment(TMPoint p, TMPoint q)
        {
            if (p < q) { this.p1 = p; this.p2 = q; }
            else { this.p1 = q; this.p2 = p; }
        }

        public bool pertenece(TMPoint p)
        {
            return p.Y == eval(p.X);
        }

        public double eval(double x)
        {
            return Pendiente * x + N;
        }

        public bool porEncimaDe(TMPoint p)
        {            
            double y_ = Pendiente * p.X + N;
            // Calcular la diferencia. Si esta es negativa, entonces el
            // segmento está por encima del punto, si no, estará por debajo.
            double dlt = p.Y - y_;
            return dlt < 0; 
        }
        public bool porDebajoDe(TMPoint p)
        {
            return !porEncimaDe(p) && !pertenece(p);
        }

        public override string ToString()
        {
            string s = this.Point_1.ToString() + "-" + this.Point_2.ToString();
            return s;
        }

    }
}
