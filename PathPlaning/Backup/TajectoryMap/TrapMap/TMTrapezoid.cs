using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrapezoidalMap
{
    public class TMTrapezoid
    {
        #region Propiedades 
        protected TMPoint leftp, rightp, top_left, top_right, bottom_left, bottom_right;
        public TMPoint LeftP
        {
            get { return this.leftp; }
            set { this.leftp = value; }
        }
        public TMPoint RightP
        {
            get { return this.rightp; }
            set { this.rightp = value; }
        }
        public TMPoint Top_Left
        {
            get { return this.top_left; }
            set { this.top_left = value; }
        }
        public TMPoint Top_Right
        {
            get { return this.top_right; }
            set { this.top_right = value; }
        }
        public TMPoint Bottom_Left
        {
            get { return this.bottom_left; }
            set { this.bottom_left = value; }
        }
        public TMPoint Bottom_Right
        {
            get { return this.bottom_right; }
            set { this.bottom_right = value; }
        }
        /// <summary>
        /// Segmento superior del trapezoide
        /// </summary>
        public TMSegment Top
        {
            get {return new TMSegment(this.top_left, this.top_right); }
        }
        /// <summary>
        /// Segmento inferior del trapezoide
        /// </summary>
        public TMSegment Bottom
        {
            get { return new TMSegment(this.bottom_left, this.bottom_right); }
        }
        /// <summary>
        /// Indica si el trapecio es interior a algun obstaculo (poligono)
        /// </summary>
        public bool Interior
        {
            get 
            {
                bool limites = bottom_left.ID * bottom_right.ID * top_left.ID * top_right.ID == 0;
                bool dentro = bottom_left.ID != top_left.ID || bottom_right.ID != top_right.ID;
                return limites || dentro;
            }
        }
        #endregion

        public TMTrapezoid(TMPoint leftp, TMPoint rightp, TMPoint top_left, TMPoint top_right, TMPoint bottom_left, TMPoint bottom_right)
        {
            this.leftp = leftp;
            this.rightp = rightp;
            this.top_left = top_left;
            this.top_right = top_right;
            this.bottom_left = bottom_left;
            this.bottom_right = bottom_right;
        }

        public override bool Equals(object obj)
        {
            if (obj is TMTrapezoid)
            {
                TMTrapezoid t = (TMTrapezoid)obj;
                return this.bottom_right.Equals(t.bottom_right) &&
                       this.bottom_left.Equals(t.bottom_left) &&
                       this.top_left.Equals(t.top_left) &&
                       this.top_right.Equals(t.top_right) &&
                       this.rightp.Equals(t.rightp) &&
                       this.leftp.Equals(t.leftp);
            }
            else return false;
        }
        public TMPoint Centro
        {
            get 
            {                
                double xx = (this.top_left.X + this.top_right.X) / 2;
                double yder = (top_right.Y + bottom_right.Y) / 2;
                double yizq = (top_left.Y + bottom_left.Y) / 2;
                double yy = (yder + yizq) / 2;
                return new TMPoint(xx, yy);
            }
        }

        public bool SegmentInside(TMSegment s)
        {
            return PointInside(s.Point_1) && PointInside(s.Point_2);
        }

        public bool PointInside(TMPoint p)
        {
            bool x_rang = p.X >= this.leftp.X && p.X < this.rightp.X;
            bool y_rang = p.Y <= this.Top.eval(p.X) && p.Y >= this.Bottom.eval(p.Y);
            return x_rang && y_rang;
        }

        public override string ToString()
        {
            string s = this.Top.ToString() + " | ";
            s += this.Bottom.ToString();
            return s;
        }
    }
}
