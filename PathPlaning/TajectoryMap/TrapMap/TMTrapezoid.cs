namespace TrapezoidalMap
{
    public class TMTrapezoid
    {
        #region Propiedades 

        public TMPoint LeftP { get; set; }

        public TMPoint RightP { get; set; }

        public TMPoint Top_Left { get; set; }

        public TMPoint Top_Right { get; set; }

        public TMPoint Bottom_Left { get; set; }

        public TMPoint Bottom_Right { get; set; }

        /// <summary>
        /// Segmento superior del trapezoide
        /// </summary>
        public TMSegment Top
        {
            get {return new TMSegment(this.Top_Left, this.Top_Right); }
        }
        /// <summary>
        /// Segmento inferior del trapezoide
        /// </summary>
        public TMSegment Bottom
        {
            get { return new TMSegment(this.Bottom_Left, this.Bottom_Right); }
        }
        /// <summary>
        /// Indica si el trapecio es interior a algun obstaculo (poligono)
        /// </summary>
        public bool Interior
        {
            get 
            {
                bool limites = Bottom_Left.ID * Bottom_Right.ID * Top_Left.ID * Top_Right.ID == 0;
                bool dentro = Bottom_Left.ID != Top_Left.ID || Bottom_Right.ID != Top_Right.ID;
                return limites || dentro;
            }
        }
        #endregion

        public TMTrapezoid(TMPoint leftp, TMPoint rightp, TMPoint top_left, TMPoint top_right, TMPoint bottom_left, TMPoint bottom_right)
        {
            this.LeftP = leftp;
            this.RightP = rightp;
            this.Top_Left = top_left;
            this.Top_Right = top_right;
            this.Bottom_Left = bottom_left;
            this.Bottom_Right = bottom_right;
        }

        public override bool Equals(object obj)
        {
            if (obj is TMTrapezoid)
            {
                var t = (TMTrapezoid)obj;
                return this.Bottom_Right.Equals(t.Bottom_Right) &&
                       this.Bottom_Left.Equals(t.Bottom_Left) &&
                       this.Top_Left.Equals(t.Top_Left) &&
                       this.Top_Right.Equals(t.Top_Right) &&
                       this.RightP.Equals(t.RightP) &&
                       this.LeftP.Equals(t.LeftP);
            }
            return false;
        }

        public TMPoint Centro
        {
            get 
            {                
                double xx = (this.Top_Left.X + this.Top_Right.X) / 2;
                double yder = (Top_Right.Y + Bottom_Right.Y) / 2;
                double yizq = (Top_Left.Y + Bottom_Left.Y) / 2;
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
            bool x_rang = p.X >= this.LeftP.X && p.X < this.RightP.X;
            bool y_rang = p.Y <= this.Top.eval(p.X) && p.Y >= this.Bottom.eval(p.Y);
            return x_rang && y_rang;
        }

        public override string ToString()
        {
            string s = string.Format("{0} | ", this.Top);
            s += this.Bottom.ToString();
            return s;
        }
    }
}
