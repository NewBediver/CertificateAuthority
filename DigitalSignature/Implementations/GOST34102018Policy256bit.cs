using AsymmetricCryptography.Utility.Elliptical;
using DigitalSignature.Utility.Elliptical;
using Org.BouncyCastle.Math;
using System;
using System.Security.Cryptography;

namespace DigitalSignature.Implementations
{
    public class GOST34102018Policy256bit
        : IDigitalSignaturePolicy
    {
        public ParameterSet Parameters { get; }

        public GOST34102018Policy256bit(ParameterSet parameters)
        {
            Parameters = parameters;
            Curve = new Curve(parameters);
            P = new Point(parameters);
            Q = new BigInteger(1, parameters.Q);
        }

        public byte[] GeneratePrivateKey(int seed)
        {
            var rng = new Random(seed);
            byte[] bytes = new byte[32];

            BigInteger d;
            do
            {
                rng.NextBytes(bytes);
                d = new BigInteger(1, bytes);
            } while (d.CompareTo(BigInteger.Zero) <= 0 || d.CompareTo(Q) >= 0);
            return d.ToByteArrayUnsigned();
        }

        public byte[] GeneratePublicKey(byte[] privateKey)
        {
            BigInteger d = new BigInteger(1, privateKey);
            Point Q = Curve.Multiply(P, d);

            string x = Q.X.ToString(16).PadLeft(64, '0');
            string y = Q.Y.ToString(16).PadLeft(64, '0');
            string total = x + y;

            byte[] publicKey = new byte[total.Length / 2];
            for (int i = 0; i < total.Length; i += 2)
            {
                publicKey[i / 2] = Convert.ToByte(total.Substring(i, 2), 16);
            }

            return publicKey;
        }

        public byte[] CreateSignature(byte[] messageHash, byte[] privateKey)
        {
            BigInteger d = new BigInteger(1, privateKey);

            // Stage 1
            byte[] h = messageHash;

            // Stage 2
            BigInteger a = new BigInteger(1, h);
            BigInteger e = a.Mod(Q);
            if (e.Equals(BigInteger.Zero))
            {
                e = new BigInteger("1");
            }

            // Stages 3-5
            BigInteger r = new BigInteger("0");
            BigInteger s = new BigInteger("0");
            do
            {
                // Stage 3
                BigInteger k = new BigInteger("0");
                do
                {
                    var rng = new RNGCryptoServiceProvider();
                    byte[] bytes = new byte[32];
                    rng.GetBytes(bytes);
                    k = new BigInteger(1, bytes);
                }
                while (k.CompareTo(BigInteger.Zero) <= 0 || k.CompareTo(Q) >= 0);

                // Stage 4
                Point C = Curve.Multiply(P, k);
                r = C.X.Mod(Q);

                // Stage 5
                s = r.Multiply(d).Add(k.Multiply(e)).Mod(Q);
            }
            while (r.Equals(BigInteger.Zero) || s.Equals(BigInteger.Zero));
            
            // Stage 6
            string Rvector = r.ToString(16).PadLeft(64, '0');
            string Svector = s.ToString(16).PadLeft(64, '0');
            string total = Rvector + Svector;

            byte[] ans = new byte[total.Length / 2];
            for (int i = 0; i < total.Length; i += 2)
            {
                ans[i / 2] = Convert.ToByte(total.Substring(i, 2), 16);
            }

            return ans;
        }

        public bool IsSignatureValid(byte[] messageHash, byte[] signature, byte[] publicKey)
        {
            int len = 64;
            if (signature.Length != len) return false;

            // Create Q
            byte[] xByte = new byte[len / 2];
            Array.Copy(publicKey, 0, xByte, 0, len / 2);
            BigInteger tmpX = new BigInteger(1, xByte);

            byte[] yByte = new byte[len / 2];
            Array.Copy(publicKey, len / 2, yByte, 0, len / 2);
            BigInteger tmpY = new BigInteger(1, yByte);

            Point P_Q = new Point(tmpX, tmpY);

            // Stage 1
            byte[] rByte = new byte[len / 2];
            Array.Copy(signature, 0, rByte, 0, len / 2);
            BigInteger r = new BigInteger(1, rByte);
            if (r.CompareTo(BigInteger.Zero) <= 0 || r.CompareTo(Q) >= 0)
            {
                return false;
            }

            byte[] sByte = new byte[len / 2];
            Array.Copy(signature, len / 2, sByte, 0, len / 2);
            BigInteger s = new BigInteger(1, sByte);
            if (s.CompareTo(BigInteger.Zero) <= 0 || s.CompareTo(Q) >= 0)
            {
                return false;
            }

            // Stage 2
            byte[] h = messageHash;

            // Stage 3
            BigInteger a = new BigInteger(1, h);
            BigInteger e = a.Mod(Q);
            if (e.Equals(BigInteger.Zero))
            {
                e = new BigInteger("1");
            }

            // Stage 4
            BigInteger v = e.ModInverse(Q);

            // Stage 5
            BigInteger z1 = s.Multiply(v).Mod(Q);
            BigInteger z2 = r.Multiply(v).Negate().Mod(Q);
            if (z2.CompareTo(BigInteger.Zero) < 0)
            {
                z2 = z2.Add(Q);
            }

            // Stage 6
            Point C = Curve.Add(Curve.Multiply(P, z1), Curve.Multiply(P_Q, z2));
            BigInteger R = C.X.Mod(Q);

            // Stage 7
            if (R.Equals(r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Curve Curve { get; }
        private Point P { get; }
        private BigInteger Q { get; }
    }
}
