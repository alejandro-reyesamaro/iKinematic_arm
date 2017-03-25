using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMTrapezoidList
    {
        protected List<TMTrapezoid> trapezoids;
        public List<TMTrapezoid> Trapezoids 
        {
            get { return this.trapezoids; }
        }

        public TMTrapezoidList(List<TMTrapezoid> trapezoids)
        {
            this.trapezoids = trapezoids;
        }        
    }
}
