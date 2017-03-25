using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ParticleFilter
{
    public class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointD(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static PointD operator+(PointD p1, PointD p2)
        {
            return new PointD(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}
