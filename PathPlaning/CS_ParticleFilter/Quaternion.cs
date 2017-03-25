using System;
using System.Collections.Generic;
using System.Linq;
using MATLAB_NormalRandom;

namespace CS_ParticleFilter
{
    public class Quaternion
    {
        public double W { get; set; }
        public double[] IJK { get; set; }

        public Quaternion(double w, double[] ijk)
        {
            this.W = w;
            this.IJK = ijk;
        }
        public Quaternion(params double[] values)
        {
            this.W = values[0];
            this.IJK = new[] {values[1], values[2], values[3]};
        }
        /// <summary>
        /// Unit quaternion
        /// </summary>
        public Quaternion()
        {
            this.W = 1;
            this.IJK = new double[] { 0, 0, 0 };
        }

        public double this[int index]
        {
            get { return index == 0 ? W : IJK[index - 1]; }
            set
            {
                if( index == 0 )
                    W = value; 
                else IJK[index - 1] = value;
            }
        }

        internal static PointD QuaternionRotation(double[] vector, Quaternion quaternion)
        {
            var q = new Quaternion( 1, 1, 1, 1 );
            q = new Quaternion( 0, q[1] * vector[0], q[3] * vector[1], q[3] * vector[2] );
            q = QuaternionProduct(quaternion, q);
            q = QuaternionProduct(q, QuaternionConjugate(quaternion));
            return new PointD(q[1], q[2]);//q=[q(:,2) q(:,3) q(:,4)];
        }

        private static Quaternion QuaternionConjugate(Quaternion q)
        {
            return new Quaternion(q[0], -q[1], -q[2], -q[3] );
        }

        private static Quaternion QuaternionProduct(Quaternion q1, Quaternion q2)
        {
            double x = q1[1] * q2[0] + q1[2] * q2[3] - q1[3] * q2[2] + q1[0] * q2[1];
            double y = -q1[1] * q2[3] + q1[2] * q2[0] + q1[3] * q2[1] + q1[0] * q2[2];
            double z = q1[1] * q2[2] - q1[2] * q2[1] + q1[3] * q2[0] + q1[0] * q2[3];
            double s = -q1[1] * q2[1] - q1[2] * q2[2] - q1[3] * q2[3] + q1[0] * q2[0];
            return new Quaternion( s, x, y, z );
        }

        internal static List<Quaternion> QuaternionQuTEMSampling(Chain chain, double[] pg, int samples)
        {
            //s1=s2=s3 =>uniform Sampling
            //var r = new NormalD_Random();
            var r = new NormalRandom();
            double[][] x = r.NextNormalRandomMatrix(0, 1, samples, 3); //r.Next(0, 1, samples, 3); // normrnd(0,1,[samples,3]);%2
            for (int i = 0; i < samples; i++) //for i = 1:samples%3
            {
                for (int j = 0; j < 3; j++)
                {
                    x[i][j] = x[i][j]/MathUtils.euclidianNorm(x[i].ToArray()); //x(i,:)=x(i,:)/norm(x(i,:));
                }
                
            } 
    
            var N = new double[x.GetLength(0)][];
            for (int i = 0; i < samples; i++)
            {
                var n = new[]{pg[1]*x[i][0], pg[2]*x[i][1], pg[3]*x[i][2]};
                N[i] = n;
            }
            double[] theta = r.NextNormalRandomMatrix(0, pg[0], samples); // r.Next(0, pg[0], samples);
            var qs = new List<Quaternion>();
            for (int i = 0; i < samples; i++)
            {
                var K = new double[3];
                for(int j = 0; j < 3; j++)
                    K[j] = N[i][j]*theta[i]; //[N(i, :)*theta(i)]
                Quaternion q = QuaternionProduct(chain.Qs[i], QuaternionExponentialMap(K));
                qs.Add(q);
            }
            return qs;
        }

        private static Quaternion QuaternionExponentialMap(double[] p)
        {
            double theta = MathUtils.euclidianNorm(p);
            double sin_theta = Math.Sin(theta);
            var q = new double[4];
            q[0] = Math.Cos(theta);
            if(Math.Abs(sin_theta)>0.00001)
            {
                double sin_theta_over_theta = sin_theta/theta;
                for( int i = 0; i < 3; i++ )
                    q[i + 1] = p[i]*sin_theta_over_theta; // q(2: 4) = p(1: 3) *sin_theta_over_theta;
            }
            else
                for (int i = 0; i < 3; i++)
                    q[i + 1] = p[i]; //q(2:4) = p(1:3);
            return new Quaternion(q);
        }
    }
}
