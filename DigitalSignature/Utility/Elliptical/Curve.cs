using DigitalSignature.Utility.Elliptical;
using Org.BouncyCastle.Math;

namespace AsymmetricCryptography.Utility.Elliptical
{
    public class Curve
    {
        public BigInteger A { get; }
        public BigInteger B { get; }
        public BigInteger P { get; }

        public Curve(ParameterSet parameters)
        {
            A = new BigInteger(1, parameters.A);
            B = new BigInteger(1, parameters.B);
            P = new BigInteger(1, parameters.P);
        }

        public Point Add(Point p1, Point p2)
        {
            Point res = new Point();

            BigInteger dx = p2.X.Subtract(p1.X);
            if (dx.CompareTo(BigInteger.Zero) < 0)
            {
                dx = dx.Add(P);
            }

            BigInteger dy = p2.Y.Subtract(p1.Y);
            if (dy.CompareTo(BigInteger.Zero) < 0)
            {
                dy = dy.Add(P);
            }

            BigInteger t = dy.Multiply(dx.ModInverse(P)).Mod(P);
            if (t.CompareTo(BigInteger.Zero) < 0)
            {
                t = t.Add(P);
            }

            res.X = t.Multiply(t).Subtract(p1.X).Subtract(p2.X).Mod(P);
            if (res.X.CompareTo(BigInteger.Zero) < 0)
            {
                res.X = res.X.Add(P);
            }

            res.Y = t.Multiply(p1.X.Subtract(res.X)).Subtract(p1.Y).Mod(P);
            if (res.Y.CompareTo(BigInteger.Zero) < 0)
            {
                res.Y = res.Y.Add(P);
            }

            return res;
        }

        public Point Double(Point p)
        {
            Point res = new Point();

            BigInteger dx = new BigInteger("2").Multiply(p.Y);
            if (dx.CompareTo(BigInteger.Zero) < 0)
            {
                dx = dx.Add(P);
            }

            BigInteger dy = new BigInteger("3").Multiply(p.X).Multiply(p.X).Add(A);
            if (dy.CompareTo(BigInteger.Zero) < 0)
            {
                dy = dy.Add(P);
            }

            BigInteger t = dy.Multiply(dx.ModInverse(P)).Mod(P);
            if (t.CompareTo(BigInteger.Zero) < 0)
            {
                t = t.Add(P);
            }

            res.X = t.Multiply(t).Subtract(p.X).Subtract(p.X).Mod(P);
            if (res.X.CompareTo(BigInteger.Zero) < 0)
            {
                res.X = res.X.Add(P);
            }

            res.Y = t.Multiply(p.X.Subtract(res.X)).Subtract(p.Y).Mod(P);
            if (res.Y.CompareTo(BigInteger.Zero) < 0)
            {
                res.Y = res.Y.Add(P);
            }

            return res;
        }

        public Point Multiply(Point p, BigInteger c)
        {
            Point res = p;
            c = c.Subtract(BigInteger.One);

            while (!c.Equals(BigInteger.Zero))
            {
                if (!c.Mod(BigInteger.Two).Equals(BigInteger.Zero))
                {
                    if (res.X.Equals(p.X) || res.Y.Equals(p.Y))
                    {
                        res = Double(res);
                    }
                    else
                    {
                        res = Add(res, p);
                    }
                    c = c.Subtract(BigInteger.One);
                }

                c = c.Divide(BigInteger.Two);
                p = Double(p);
            }

            return res;
        }
    }
}
