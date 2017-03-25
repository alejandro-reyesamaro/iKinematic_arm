using System.Collections.Generic;
using TrajectoryMap;

namespace Optimization
{
    public class OptimalPath
    {
        /// <summary>
        /// Funcion que calcula el camino optimo dada una trayectoria y los rangos de movimientos que puede adoptar
        /// </summary>
        /// <param name="path">Camino inicialmente</param>
        /// <param name="eps">Arreglo de tolerancias; eps[0] - gradiente; eps[1] - funcion; eps[2] - variable</param>
        /// <param name="maxits">Maximo de iteraciones permitidas</param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public List<TRNode> GetOptimalPathOf(List<TRNode> path, double[] eps, int maxits, out string msg)
        {
            List<TRNode> optimal_path = lbfgsb.Minimizar(path, eps[0], eps[1], eps[2], maxits, out msg);
            return optimal_path;
        }
    }
}
