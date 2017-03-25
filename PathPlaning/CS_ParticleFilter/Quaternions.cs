using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CS_ParticleFilter
{
    public class Quaternions
    {
        public List<Quaternion> Qs { get; set; }
        public Quaternions(List<Quaternion> qs)
        {
            this.Qs = qs;
        }
    }
}
