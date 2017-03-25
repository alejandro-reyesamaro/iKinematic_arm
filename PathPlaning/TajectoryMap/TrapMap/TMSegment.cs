using System;

namespace TrapezoidalMap
{
    public class TMSegment
    {
        /// <summary>
        /// Representará en obstáculo al que pertenece el segmento
        /// </summary>
        public short Owner { get; set; }

        public TMPoint Point_1 { get; set; }

        public TMPoint Point_2 { get; set; }

        public double Pendiente 
        {
            get { return (this.Point_1.Y - this.Point_2.Y) / (this.Point_1.X - this.Point_2.X); } 
        }
        public double N
        {
            get { return this.Point_1.Y - this.Pendiente * this.Point_1.X; }
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
            if (p < q) { this.Point_1 = p; this.Point_2 = q; }
            else { this.Point_1 = q; this.Point_2 = p; }
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
            string s = string.Format("{0}-{1}", this.Point_1, this.Point_2);
            return s;
        }

    }
}
