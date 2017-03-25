using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TRRange
    {
        private double y_max, y_min;
        public double Y_Max 
        {
            get { return this.y_max; }
            set { this.y_max = value; }
        }
        public double Y_Min
        {
            get { return this.y_min; }
            set { this.y_min = value; }
        }        
        public TRRange(double ymin, double ymax)
        {
            this.y_max = ymax;
            this.y_min = ymin;
        }
        public double Range 
        {
            get { return this.y_max - this.y_min; }
        }
    }
}
