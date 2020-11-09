using DigitalSignature.Utility.Elliptical;
using Org.BouncyCastle.Math;

namespace AsymmetricCryptography.Utility.Elliptical
{
    public class Point
    {
        public BigInteger X { get; set; }
        public BigInteger Y { get; set; }

        public Point()
        {
            X = new BigInteger("0");
            Y = new BigInteger("0");
        }

        public Point(BigInteger x, BigInteger y)
        {
            X = x;
            Y = y;
        }

        public Point(ParameterSet parameters)
        {
            X = new BigInteger(1, parameters.X);
            Y = new BigInteger(1, parameters.Y);
        }
    }
}
