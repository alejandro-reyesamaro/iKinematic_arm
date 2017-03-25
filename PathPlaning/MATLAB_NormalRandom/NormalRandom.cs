using MathWorks.MATLAB.NET.Arrays;

namespace MATLAB_NormalRandom
{
    public class NormalRandom
    {
        public double[][] NextNormalRandomMatrix( double mu, double sigma, int n, int m )
        {
            var norm = new Normrand.MATLAB_NormalRandom();
            MWArray M_mu = new MWNumericArray( mu );
            MWArray M_sigma = new MWNumericArray( sigma );
            MWArray M_n = new MWNumericArray( n );
            MWArray M_m = new MWNumericArray( m );
            MWArray R = norm.Normrand( M_mu, M_sigma, M_n, M_m );
            var result = new double[n][];
            for ( int i = 0; i < n; i++ )
            {
                result[i] = new double[m];
                for ( int j = 0; j < m; j++ )
                    result[i][j] = ((MWNumericArray)R[i+1, j+1]).ToScalarDouble();
            }
            return result;
        }
        public double[] NextNormalRandomMatrix( double mu, double sigma, int samples )
        {
            var norm = new Normrand.MATLAB_NormalRandom();
            MWArray M_mu = new MWNumericArray( mu );
            MWArray M_sigma = new MWNumericArray( sigma );
            MWArray M_n = new MWNumericArray( 1 );
            MWArray M_m = new MWNumericArray( samples );
            MWArray R = norm.Normrand( M_mu, M_sigma, M_n, M_m );
            var result = new double[samples];
            for ( int i = 0; i < samples; i++ )
                result[i] = ((MWNumericArray)R[i+1]).ToScalarDouble();
            return result;
        }
    }
}
