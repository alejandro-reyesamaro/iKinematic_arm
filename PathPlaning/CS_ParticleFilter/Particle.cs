using System;
using System.Collections.Generic;

namespace CS_ParticleFilter
{
    public class Particles
    {
        public List<Particle> Particulas { get; set; }
        public Particles(Chain chain, int samples, double[] pg, bool QuTEMSampling)
        {
            this.Particulas = new List<Particle>();
            for (int i = 0; i < samples; i++)
                Particulas.Add(new Particle(QuTEMSampling ? Chain.ChainQuTEMSampling(pg, chain) : chain, pg, 1.0/samples));
        }

        public Particles()
        {
            Particulas = new List<Particle>();
        }

        public static Particles Remostrejar(Particles particles)
        {
            double baseWeight = 1.0/particles.Particulas.Count;
            var res = new Particles();
            var rand = new Random();
            for(int i = 0; i < particles.Particulas.Count; i++)
            {
                double r = rand.NextDouble();

                if (r == 1)
                    r = rand.NextDouble();
                
                double base_ = 0;
                int count = -1;
                while (r > base_ && count + 1 < particles.Particulas.Count )
                {
                    count = count + 1;
                    base_ = base_ + particles.Particulas[count].W;
                }
                // base = base
                //res.Particulas[i].Cadena = 
                var particle = new Particle(particles.Particulas[count].Cadena, particles.Particulas[count].Gausian,
                                            baseWeight);
                //res.Particulas[i].W = baseWeight;
                res.Particulas.Add(particle);
            }
            return res;
        }
    }

    public class Particle
    {
        public Chain Cadena { get; set; }
        public double[] Gausian { get; set; }
        public double W { get; set; }

        public Particle(Chain cadena, double[] gausian, double peso)
        {
            this.Cadena = cadena;
            this.Gausian = gausian;
            this.W = peso;
        }

        //public double WeightFunction(PointD goal, SistemaObstaculos S)
        //{
        //    // euclideanDistance
        //    PointD ee = this.Cadena.ChainEndEffectorPosition();
        //    //Si ms de un end effector, multiplicar
        //   //w = exp((-1)*(euclidianDistance(ee, goal))*imageDistance(image, chain));
        //    double w = Math.Exp((-1)*MathUtils.euclidianDistance(ee, goal));

        //    //el peso será cero si entra en contacto con algun obstáculo
        //        w = w * S.S_Touch(this.Cadena);
        //    return w;
        //}

        public static double WeightFunction(Chain chain, PointD goal, SistemaObstaculos S)
        {
            // euclideanDistance
            PointD ee = chain.ChainEndEffectorPosition();
            //Si ms de un end effector, multiplicar
            //w = exp((-1)*(euclidianDistance(ee, goal))*imageDistance(image, chain));
            double w = Math.Exp((-1) * MathUtils.euclidianDistance(ee, goal));

            //el peso será cero si entra en contacto con algun obstáculo
            w = w * S.S_Touch(chain);
            return w;
        }
    }
}
