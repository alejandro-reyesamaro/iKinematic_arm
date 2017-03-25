using System;
using System.Collections.Generic;

namespace CS_ParticleFilter
{
    public struct FilterResult
    {
        public Particle ChainResult { get; set; }
        public PointD[] ChainResult_points { get; set; }
        public int Iterations { get; set; }
        public double Distance { get; set; }
    }

    public class ParticleFilter
    {
        public FilterResult PrtFltr_MkwskSum(
            int max_iter, 
            double epsilon, 
            SistemaObstaculos S, 
            List<PointD> arm, 
            PointD obj, 
            int samples, 
            double media_gausiana)
        {
            int it;
            double distance;
            var parametros_gausiana = new GausianParameters(media_gausiana, 0, 0, 1);
            var chaint = new Chain( arm.ToArray() );
            var particles = new Particles(chaint, samples, parametros_gausiana.ToArray(), true);
            Particle CHresult = pik(max_iter, epsilon, obj, particles, S, out it, out distance);
            PointD[] chainResult_points = CHresult.Cadena.Chain2positions();
            var fr = new FilterResult
                         {
                             ChainResult = CHresult,
                             ChainResult_points = chainResult_points,
                             Iterations = it,
                             Distance = distance
                         };
            return fr;
        }

        #region Private
        private static Particles PF(PointD goal, Particles particles, SistemaObstaculos S, out int bestIndex)
        {
            double wSum = 0;
            double resampling = 0;
            var p = new Particles();
            for (int i = 0; i < particles.Particulas.Count; i++)
            {
                //sampling
                //for (int j = 0; j < particles.Particulas[i].Cadena.Size; j++ )

                //p.Particulas[i].Cadena = 
                Chain c = Chain.ChainQuTEMSampling(particles.Particulas[i].Gausian, particles.Particulas[i].Cadena); //???????
                //compute weight 
                //p.Particulas[i].Gausian = 
                double[] gausian = particles.Particulas[i].Gausian;
                double weight = Particle.WeightFunction(c, goal, S);
                //p.Particulas[i].W = 
                double w = particles.Particulas[i].W * weight;
                //weights cumsum
                var particle = new Particle(c, gausian, w);
                p.Particulas.Add(particle);
                wSum = wSum + w;
                //computing resamplig condition
                resampling = resampling + Math.Pow(w, 2);
            }

            //normalize weights
            foreach (Particle t in p.Particulas)
                t.W = t.W / wSum;

            // best chain
            double max = 0;
            int imax = 0;
            for (int i = 0; i < p.Particulas.Count; i++)
            {
                //ww = particles(i).w
                if (p.Particulas[i].W > max)
                {
                    max = p.Particulas[i].W;
                    imax = i;
                }
            }
            bestIndex = imax;
            if (p.Particulas[bestIndex].W == 0)
                bestIndex = 0;

            //if necessary, resampling
            //Effective Sample Size, Tutorial PF, 15 year later
            // if ((1/resampling) <= (size(p, 1)/2))
            // 'resampling'

            return Particles.Remostrejar(p);
        }

        private Particle pik(int max_iter, double epsilon, PointD goal, Particles particles, SistemaObstaculos S, out int it, out double distance)
        {
            //chainResult = chain;
            Particle chainResult = particles.Particulas[0];
            PointD ee = chainResult.Cadena.ChainEndEffectorPosition();
            it = 0;
            while (it < max_iter && MathUtils.euclidianDistance(ee, goal) > epsilon)
            {
                int I;
                particles = PF(goal, particles, S, out I);
                ee = particles.Particulas[I].Cadena.ChainEndEffectorPosition();
                chainResult = particles.Particulas[I];
                it = it + 1;
            }
            distance = MathUtils.euclidianDistance(ee, goal);
            return chainResult;
        }

        #endregion
    }
}
