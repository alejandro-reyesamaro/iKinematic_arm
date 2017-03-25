namespace CS_ParticleFilter
{
    public class GausianParameters
    {
        public double Media { get; set; }
        public byte[] Rotaciones { get; set; }

        public GausianParameters(double media_gausiana, byte rotar_en_x, byte rotar_en_y, byte rotar_en_z)
        {
            this.Media = media_gausiana;
            Rotaciones = new[]{ rotar_en_x, rotar_en_y, rotar_en_z};
        }

        internal double[] ToArray()
        {
            return new[] {Media, Rotaciones[0], Rotaciones[1], Rotaciones[2]};
        }
    }
}
