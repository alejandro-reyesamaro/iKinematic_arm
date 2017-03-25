using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IK_ParticleFilter;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using TrapezoidalMap;

namespace PathPlaning
{
    public class ParticleFilter
    {
        private MWArray MAT_obst_ranks, MAT_x_obst, MAT_y_obst;
        /**
         *  % Esta funcion es la que engloba los algoritmos de Filtro de Particulas
            % y Suma de Minkowski. Como parámetros se le pasa:
            % max_iter: Maximo de iteraciones que realizara el filtraje
            % epsilon:  tolerancia de cercanía con el objetivo
            % S:        el sistema de obstaculos
            % x_axis:   posiciones en el eje x de la cadena en su posición "inicial" 
            % y_axis:   posiciones en el eje y de la cadena en su posición "inicial" 
            % obj:      objetivo intermedio 
            % samples:  cantidad de particulas que se generaran
            % media_gausiana: media para la generación de particulas (0.03)
            % S: 
            % S = [O1 O2 ... Ok]
            % Ok.ptos: lista de puntos, ordenados tomando como principio el que menos
            % coordenada "y" tenga (menos "x") en caso de empate y siguiendo el orden
            % inverso a a las manesillas del reloj         
         **/        
        
        /// <summary>
        /// Este metodo se encarga de encontrar la configuracion que debe adoptar el brazo (arm) para llegar al objetivo (obj)
        /// </summary>
        /// <param name="chain_result">(Salida) Posiciones de la cadena resultante</param>
        /// <param name="it">(Salida) Numero de iteraciones realizadas</param>
        /// <param name="distance">(Salida) Distancia a la que quedo del objetivo intermedio (obj)</param>
        /// <param name="max_iter">Maximo de iteraciones que realizara el filtro</param>
        /// <param name="epsilon">Distancia a la que se quiere llegar del objetivo intermedio (obj)</param>
        /// <param name="S">Sistemas de obstaculos</param>
        /// <param name="arm">Posiciones de los nodos de la cadena inicialmente</param>
        /// <param name="obj">Posicion del objetivo intermedio</param>
        /// <param name="samples">Numero de particulas que se generaran en el proceso de filtrado</param>
        /// <param name="m_gaussian">Media gaussiana</param>
        /// <returns>Indica si el brazo pudo llegar al objetivo.</returns>
        public bool Filter
        ( 
            out List<TMPoint> chain_result,
            out int it, 
            out double distance,
            int max_iter,
            double epsilon,
            TMObstacleSystem S,
            List<TMPoint> arm,
            TMPoint obj,
            int samples, 
            double m_gaussian
        )
        {
            chain_result = null;
            it = 0;
            distance = 0;
            IK_ParticleFilter.MATLAB_PFIK PF = new IK_ParticleFilter.MATLAB_PFIK();
            //function [chainResult, chainResult_points, it, distance] = PrtFltr_MkwskSum(max_iter, epsilon, S, x_axis, y_axis, obj, samples, media_gausiana)
            MWArray MAT_max_iter = new MathWorks.MATLAB.NET.Arrays.MWNumericArray(max_iter);
            MWArray MAT_epsilon = new MathWorks.MATLAB.NET.Arrays.MWNumericArray(epsilon);
            
            #region OBSTACULOS
            if (this.MAT_obst_ranks == null || this.MAT_x_obst == null || this.MAT_y_obst == null)
            {
                int obs_count = S.Obstacles.Poligons.Count;
                /*
                obst_ranks = [4];
                x_obst = [0.4 0.7 0.7 0.4];
                y_obst = [0.6 0.6 0.9 0.9]; 
                */
                int[] rr = new int[obs_count];
                int c_ptos = 0;
                for (int i = 0; i < obs_count; i++)
                {
                    c_ptos += S.Obstacles.Poligons[i].Count;
                    rr[i] = c_ptos;
                }
                this.MAT_obst_ranks = new MWNumericArray(1, obs_count, rr);
                double[] x_rr = new double[c_ptos];
                double[] y_rr = new double[c_ptos];
                int index = 0;
                foreach (TMPoligon pol in S.Obstacles.Poligons)
                {
                    foreach (TMPoint p in pol.Points)
                    {
                        x_rr[index] = p.X;
                        y_rr[index] = p.Y;
                        index++;
                    }
                }
                //corrimiento_minkowski(rr, out x_rr, out y_rr);
                this.MAT_x_obst = new MWNumericArray(1, c_ptos, x_rr);
                this.MAT_y_obst = new MWNumericArray(1, c_ptos, y_rr);
            }
            #endregion

            double[] a_x = new double[arm.Count];
            double[] a_y = new double[arm.Count];
            for (int i = 0; i < arm.Count; i++)
			{
                a_x[i] = arm[i].X;
                a_y[i] = arm[i].Y;
			}

            MWArray MAT_X_axis = new MWNumericArray(1, arm.Count, a_x);
            MWArray MAT_Y_axis = new MWNumericArray(1, arm.Count, a_y);
            MWArray MAT_Obj = new MWNumericArray(1, 2, new double[] { obj.X, obj.Y });
            MWArray MAT_Samples = new MWNumericArray(samples);
            MWArray MAT_MedGauss = new MWNumericArray(m_gaussian);
            MWArray t = new MWStructArray();
            MWArray[] outs = PF.PrtFltr_MkwskSum(4, MAT_max_iter, MAT_epsilon, MAT_obst_ranks, MAT_x_obst, MAT_y_obst, MAT_X_axis, MAT_Y_axis, MAT_Obj, MAT_Samples, MAT_MedGauss); 
            
            distance = ((MWNumericArray)outs[3]).ToScalarDouble();
            it = ((MWNumericArray)outs[2]).ToScalarInteger();
            int ptos_brazos = outs[1].Dimensions[0];
            chain_result = new List<TMPoint>();
            Array mat_chain_result = ((MWNumericArray)outs[1]).ToArray();
            for (int i = 0; i < ptos_brazos; i++)
            {
                TMPoint p = new TMPoint((double)mat_chain_result.GetValue(i, 0), (double)mat_chain_result.GetValue(i, 1));
                chain_result.Add(p);
            }
            return distance <= epsilon;
        }
    }
}
