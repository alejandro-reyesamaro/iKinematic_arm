using System.Collections.Generic;

namespace CS_ParticleFilter
{
    public class SistemaObstaculos
    {
        public List<Obstaculo> S { get; set; }

        public SistemaObstaculos(List<Obstaculo> s)
        {
            this.S = s;
        }
        
        public double S_Touch(Chain chain)
        {
            /*S: 
             * S = [ O1 O2...Ok]
             * Ok.ptos: lista de puntos
             */

            PointD[] cadena = chain.Chain2positions();
            double r = 1;
            int b = cadena.Length;
            for (int i = 0; i < b - 1; i++)
            {
                //Crear el enlace a analizar
                PointD p1 = cadena[i];
                PointD p2 = cadena[i + 1];

                // Poner en cuadrantes 1 o 2
                if (p1.Y > p2.Y)  //esta en los cuadrantes 3 o 4
                {
                    double xtemp = p1.X;
                    double ytemp = p1.Y;
                    p1.X = p2.X;
                    p1.Y = p2.Y;
                    p2.X = xtemp;
                    p2.Y = ytemp;
                } //ahora estan puestos en los cuadrantes 1 o 2

                //Escoger los obstaculos a los que se le hara la suma
                int obst = this.S.Count;
                //S_ = S;
                var S_ = new List<Obstaculo>();
                for (int k = 0; k < obst; k++)
                {
                    double[] tx = this.S[k].xVector;
                    double x_max = MathUtils.Max(tx);
                    double x_min = MathUtils.Min(tx);
                    
                    double[] ty = this.S[k].yVector;
                    double y_max = MathUtils.Max(ty);
                    double y_min = MathUtils.Min(ty);
                    if (!(p1.X < x_min && p2.X < x_min) || (p1.X > x_max && p2.X > x_max))
                        S_.Add(S[k]);
                }
                //Poner la cadena respecto al (0, 0), crecerlo
                //y preguntar si el brazo esta dentro del poligono.
                var temp = new PointD(p2.X,p2.Y);
                p2.X = p2.X - p1.X;
                p2.Y = p2.Y - p1.Y;
                p1.X = 0;
                p1.Y = 0;
                int obst_ = S_.Count;
                
                var brazo = new Segment(p1, p2);

                for (int k = 0; k < obst_; k++ )
                {
                    int ptos_ = S_[k].xVector.Length;
                    S_[k] = S_[k].obstaculo_crecido(brazo);
                    r = r * (1 - ((S_[k].Dentro(temp))?1:0));
                    if (r == 0)
                        r = 0;
                }
            }
            return r;
        }
    }
}
