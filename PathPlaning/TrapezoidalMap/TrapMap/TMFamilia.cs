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
        public TMFamilia(List<TMNode> padres, TMNode node)
        {
            this.padres = padres;
            this.posiciones = new List<NodeType>();
            for (int i = 0; i < padres.Count; i++)
			{
                posiciones.Add(padres[i].node_type(node));
			}            
        }
    }
}
