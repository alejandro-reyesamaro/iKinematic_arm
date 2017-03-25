using System;
using System.Collections.Generic;
using System.Text;
using TrapezoidalMap;
using TrajectoryMap;

namespace Optimization
{
    public class OptimalPath
    {
        /// <summary>
        /// Funcion que calcula el camino optimo dada una trayectoria y los rangos de movimientos que puede adoptar
        /// </summary>
        /// <param name="path">Camino inicialmente</param>
        /// <param name="esps">Arreglo de tolerancias; eps[0] - gradiente; eps[1] - funcion; eps[2] - variable</param>
        /// <param name="maxits">Maximo de iteraciones permitidas</param>
        /// <param name="longitud_camino">Longitud final del camino</param>
        /// <returns></returns>
        public List<TRNode> GetOptimalPathOf(List<TRNode> path, double[] eps, int maxits, out string msg)
        {
            /// <param name="n">Cantidad de variables</param>
            /// <param name="m">Cantidad de columnas que se guardar'an en la aproximacion bfgs min(n, 7)</param>
            /// <param name="x">punto inicial y termina en el optimo</param>
            /// <param name="epsg">el epsilon para la condicion de parada por el gradiente 10^-8</param>
            /// <param name="epsf">condicion de parada para el error absoluto en la funcion</param>
            /// <param name="epsx">condicion de parada para el error absoluto en x</param>
            /// <param name="maxits">maximo de iteraciones</param>
            /// <param name="nbd">Buscar arriba NBD</param>
            /// <param name="l">cotas inferiores</param>
            /// <param name="u">cotas superiores</param>
            /// <param name="info">informacion por que para (buscar arriba)</param>
            /// <param name="iteration">por que iteracion va</param>
            /// <param name="epsinfo">cual epsilon fue el que paro</param>
            /// <param name="func">valor de la funcion</param>

            List<TRNode> optimal_path = lbfgsb.Minimizar(path, eps[0], eps[1], eps[2], maxits, out msg);
            return optimal_path;
        }
    }
}
