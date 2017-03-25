using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ParticleFilter
{
    internal class Link
    {
        public Quaternion Quaternion { get; set; }
        public double[] DirectionVector { get; set; }
    }
}
