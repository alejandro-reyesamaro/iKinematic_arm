using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMMath;

namespace TrapezoidalMap
{
    public class TMPoligon
    {
        protected List<TMPoint> points;
        
        public TMPoint GetPointAt(int i)
        {
            return points[i];
        }
        public List<TMPoint> Points
        {
            get 
            {
                return this.points;
            }
        }
        /// <summary>
        /// Cantidad de puntos del poligono
        /// </summary>
        public int Count
        {
            get { return points.Count; }
        }
        public List<TMSegment> Segments
        {
            get 
            {
                List<TMSegment> ls = new List<TMSegment>();
                for (int i = 0; i < points.Count-1; i++)
                {
                    TMSegment s = new TMSegment(this.points[i], this.points[i+1]);
                    ls.Add(s);
                }
                ls.Add(new TMSegment(points[points.Count - 1], points[0]));
                return ls;
            }
        }
        
        /// <summary>
        /// Los puntos deben estar ordenados siguiendo el oredn inverso de las manesillas del reloj.
        /// comenzando por el de menor coordenada y (menor x en caso de empate)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public TMPoligon(int id, double[] x, double[] y)
        {
            int n = x.Length;
            if (x == null || y == null || n != y.Length)
            { throw new InvalidOperationException("Debe pasar la misma cantidad de absisas que de ordenadas."); }
            this.points = new List<TMPoint>();
            for (int i = 0; i < n; i++)
            {
                TMPoint p = new TMPoint(x[i], y[i], id);
                points.Add(p);
            }
        }

        public bool PointInside(TMPoint p)
        {
            int segs = points.Count;                    //segs = max(size(P.Segs));    
            int cayo_dentro = 0;                        //cayo_dentro = 0;
            int esta_entre = 0;                         //esta_entre = 0;
            foreach(TMSegment s in this.Segments)       //for i=1:segs
            {
                int edos = entredos(s, p);              //edos = entredos(P.Segs(i), p);
                cayo_dentro += Math.Abs(edos);          //cayo_dentro = cayo_dentro + abs(edos);
                esta_entre += edos;                     //esta_entre  = esta_entre + edos;
            }
            return cayo_dentro > 0 && esta_entre == 0;  //r = cayo_dentro > 0 && esta_entre == 0;
        }

        /// <summary>
        /// Metodo privado
        /// </summary>
        /// <param name="tMSegment"></param>
        /// <param name="p"></param>
        /// <returns>-1: si la recta está por debajo del punto, 
        /// 1 si la recta está por encima del punto, 
        /// 0 si el punto pertenece a la recta
        /// </returns>
        private int entredos(TMSegment S, TMPoint p)
        {
            int r = 0;      //r = 0;
            //if (S.p1.x <= p.x && S.p2.x >= p.x) || (S.p2.x <= p.x && S.p1.x >= p.x)
            if ((S.Point_1.X <= p.X && S.Point_2.X >= p.X) || (S.Point_2.X <= p.X && S.Point_1.X >= p.X))
            {
                double yr = S.eval(p.X);                    //    yr = evalua_recta(S, p.x);
                double rest = yr - p.Y;                     //    rest = yr - p.y;
                if (Math.Abs(rest) >= Utils.Eps)            //    if abs(rest) >= eps
                    r = (int)(rest / Math.Abs(rest));       //        r = rest/abs(rest);                
            }
            return r;
        }
    }
}
