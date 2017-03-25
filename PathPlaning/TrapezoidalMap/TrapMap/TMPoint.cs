using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMPoint
    {
        protected double x, y;
        protected int id;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public double X 
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public TMPoint(double x, double y)
        {
            this.x = x; this.y = y; this.id = -1;
        }
        public TMPoint(double x, double y, int id)
        {
            this.x = x; this.y = y; this.id = id;
        }
        public bool alaDerechaDe(TMPoint p)
        {
            return this.x > p.x;
        }
        public bool alaIzquierdaDe(TMPoint p)
        {
            return p.alaDerechaDe(this);
        }
        public override bool Equals(object obj)
        {
            if (obj is TMPoint)
            {
                TMPoint p = (TMPoint)obj;
                bool r = Math.Abs(this.x - p.x) < Utils.Eps &&
                       Math.Abs(this.y - p.y) < Utils.Eps;
                return r;
            }
            else return false;
        }

        #region Operadores
        public static bool operator<(TMPoint p1, TMPoint p2)
        {
            return p1.x < p2.x;
        }
        public static bool operator>(TMPoint p1, TMPoint p2)
        {
            return p1.x > p2.x;
        }
        public static bool operator >=(TMPoint p1, TMPoint p2)
        {
            return p1.x >= p2.x;
        }
        public static bool operator <=(TMPoint p1, TMPoint p2)
        {
            return p1.x <= p2.x;
        }
        //public static bool operator ==(TMPoint p1, TMPoint p2)
        //{
        //    return (p1 != null && p2 != null) ? p1.Equals(p2) : false;
        //}
        //public static bool operator !=(TMPoint p1, TMPoint p2)
        //{
        //    return (p1 != null && p2 != null) ? !p1.Equals(p2) : true;
        //}
        #endregion

        public override string ToString()
        {
            string s = "("+ this.x + ";" + this.y.ToString() + ")";
            return s;
        }
    }
}
