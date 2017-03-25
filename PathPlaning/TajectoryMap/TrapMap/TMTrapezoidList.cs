using System.Collections.Generic;

namespace TrapezoidalMap
{
    public class TMTrapezoidList
    {
        public List<TMTrapezoid> Trapezoids { get; protected set; }

        public TMTrapezoidList(List<TMTrapezoid> trapezoids)
        {
            this.Trapezoids = trapezoids;
        }        
    }
}
