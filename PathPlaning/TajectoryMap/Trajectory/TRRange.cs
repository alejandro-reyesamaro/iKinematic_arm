namespace TrajectoryMap
{
    public class TRRange
    {
        public double Y_Max { get; set; }

        public double Y_Min { get; set; }

        public TRRange(double ymin, double ymax)
        {
            this.Y_Max = ymax;
            this.Y_Min = ymin;
        }
        public double Range 
        {
            get { return this.Y_Max - this.Y_Min; }
        }
    }
}
