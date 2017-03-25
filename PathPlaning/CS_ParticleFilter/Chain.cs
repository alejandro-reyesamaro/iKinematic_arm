using System.Collections.Generic;

namespace CS_ParticleFilter
{
    public class Chain
    {
        public double[,] Vector { get; set; }
        public List<Quaternion> Qs;
        public int Size { get { return Vector.GetLength(0); } }

        public Chain(double[,] vector, List<Quaternion> qs)
        {
            this.Vector = vector;
            this.Qs = qs;
        }

        public double[] Vector_Fila(int i)
        {
            var fila = new double[Vector.GetLength(1)];
            for (int j = 0; j < fila.Length; j++)
            {
                fila[j] = Vector[i, j];
            }
            return fila;
        }

        public double[] Vector_Columna(int i)
        {
            var columna = new double[Vector.GetLength(0)];
            for (int j = 0; j < columna.Length; j++)
            {
                columna[j] = Vector[j, i];
            }
            return columna;
        }

        //public Chain(double[] xVector, double[] yVector)
        //{
        //    this.X_Vector = xVector;
        //    this.Y_Vector = yVector;
        //    Qs = new List<Quaternion> {new Quaternion(), new Quaternion()};
        //}
        public Chain(PointD[] points)
        {
            //var x = new double[points.Length];
            //var y = new double[points.Length];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    x[i] = points[i].X;
            //    y[i] = points[i].Y;
            //}
            Chain c = positions2chain(points);
            this.Vector = c.Vector;
            Qs = new List<Quaternion>();
            for (int i = 0; i < c.Vector.GetLength(0); i++)
                Qs.Add(new Quaternion());
        }
        
        internal PointD[] Chain2positions()
        {
            var posiciones = new PointD[Size + 1];
            posiciones[0] = new PointD(0,0);
            for( int i = 1; i <= this.Size; i++)
            {
                PointD p1 = Quaternion.QuaternionRotation(Vector_Fila(i-1), Qs[i-1]);
                posiciones[i] = new PointD( posiciones[i-1].X + p1.X, posiciones[i-1].Y + p1.Y );//[posiciones;posiciones(i, :)+p1];
            }
            return posiciones;
        }

        internal PointD ChainEndEffectorPosition()
        {
            //for( int j = 0; j < 1; j++) //for j = 1:size(chain,3)
            //{
                var p = new PointD(0,0);
                for ( int i = 0; i < 2; i++) //for i = 1:size(chain,1)
                {
                    PointD rotation = Quaternion.QuaternionRotation(Vector_Fila(i), Qs[i]);
                    p = new PointD(p.X + rotation.X, p.Y + rotation.Y);
                }
                //ee(j, :) =p;
            //}
            return p;
        }

        //internal PointD[] Positions2chain()
        //{
        //    //Se asume que la primera posicion es el (0, 0)
        //    double x_ = 0;
        //    double y_ = 0;
        //    var chain = new List<PointD>();
        //    int n = X_Vector.Length;
        //    for(int i = 1; i < n; i++) //for i = 2:n
        //    {
        //        chain.Add(new PointD((X_Vector[i] - x_), (Y_Vector[i] - y_)));
        //            //[chain;x(i) - x_,y(i) - y_,0];
        //        x_ = X_Vector[i];
        //        y_ = Y_Vector[i];
        //    }
        //    return chain.ToArray();
        //}

        internal static Chain ChainQuTEMSampling(double[] pg, Chain chain)
        {
            List<Quaternion> particles = Quaternion.QuaternionQuTEMSampling(chain, pg, chain.Size);
            var qs = new List<Quaternion>();
            for( int i = 0; i < chain.Size; i++ )//for i=1:size(chain,1)
            {
                qs.Add(particles[i]);
            }
            return new Chain(chain.Vector, qs);
        }

        public static Chain positions2chain(PointD[] points) //positions2chain(x, y)
        {
            // Se asume que la primera posicion es el (0,0)
            // Crea una cadena con cuaternion null
            double x_ = 0;
            double y_ = 0;
            int n = points.Length - 1;
            var vector = new double[n,3];
            for (int i = 0; i < n; i++)
            {
                vector[i,0] = points[i+1].X - x_;
                vector[i,1] = points[i+1].Y - y_;
                vector[i, 2] = 0;
                x_ = points[i+1].X;
                y_ = points[i+1].Y;
            }
            return new Chain(vector, null);
        }
    }
}
