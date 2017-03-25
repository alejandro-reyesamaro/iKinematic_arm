using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMFamilia
    {
        public List<NodeType> posiciones;
        public List<TMNode> padres;

        /// <summary>
        /// Construir la informacion del padre que tendrá en el futuro
        /// </summary>
        /// <param name="padres"></param>
        /// <param name="hijo"></param>
        /// <param name="node"></param>
        public TMFamilia(List<TMNode> padres, TMNode node)
        {
            this.padres = padres;
            this.posiciones = new List<NodeType>();
            foreach (TMNode t in padres)
            {
                posiciones.Add(t.node_type(node));
            }
        }
    }
}
