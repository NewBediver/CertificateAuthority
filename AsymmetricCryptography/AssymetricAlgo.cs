using System;
using System.Numerics;

namespace AsymmetricCryptography
{
    public abstract class AssymetricAlgo
    {
        public abstract KeyContainer GenerateKeys(ulong seed);
        public abstract string Encode(string message, BigInteger key);
        public abstract string Decode(string message, BigInteger key);
    }
}
