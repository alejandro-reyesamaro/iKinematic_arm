using System;
using System.Linq;

namespace CS_ParticleFilter
{
    public class MathUtils
    {
        public static double euclidianNorm(double[] v)
        {
            double sum = v.Sum(d => + d*d);
            return Math.Sqrt(sum);
        }
        public static double euclidianDistance(PointD p1, PointD p2)
        {
            var d = new[] {p1.X - p2.X, p1.Y - p2.Y};
            return euclidianNorm(d);
        }
        public static double Eps = Math.Pow(10, -10);

        internal static double Max(double[] tx)
        {
            if (tx.Length == 1) return tx[0];
            double max = tx[0];
            for (int i = 1; i < tx.Length; i++)
                max = Math.Max(max, tx[i]);
            return max;
        }

        internal static double Min(double[] tx)
        {
            if (tx.Length == 1) return tx[0];
            double min = tx[0];
            for (int i = 1; i < tx.Length; i++)
                min = Math.Min(min, tx[i]);
            return min;
        }
    }
}
