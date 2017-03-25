using System;

namespace CS_ParticleFilter
{
    internal class NormalD_Random
    {
        private readonly Random rand1;
        private readonly Random rand2;

        public NormalD_Random()
        {
            this.rand1 = new Random();
            this.rand2 = new Random();
        }

        public double[][] Next(double mu, double sigma, int samples, int cant)
        {
            var d = new double[samples][];
            for (int i = 0; i < samples; i++ )
            {
                d[i] = new double[cant];
                for (int j = 0; j < cant; j++)
                    d[i][j] = BoxMullerNormalNumber(mu, sigma);
            }
            return d;
        }
        public double[] Next(double mu, double sigma, int samples)
        {
            var ns = new double[samples];
            for (int i = 0; i < samples; i++)
                ns[i] = BoxMullerNormalNumber(mu, sigma);
            return ns;
        }

        private double BoxMullerNormalNumber(double mu, double sigma)
        {
            double Rnd = rand1.NextDouble();
            double NORMAL01 = Math.Sqrt((-2*Math.Log(Rnd, Math.E)))*Math.Sin(2*Math.PI*Rnd);
            return mu + sigma * NORMAL01;
        }
    }
}
