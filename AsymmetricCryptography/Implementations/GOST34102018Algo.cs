using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AsymmetricCryptography.Implementations
{
    public class GOST34102018Algo
        : AssymetricAlgo
    {
        public override string Decode(string message, BigInteger key)
        {
            throw new NotImplementedException();
        }

        public override string Encode(string message, BigInteger key)
        {
            throw new NotImplementedException();
        }

        public override KeyContainer GenerateKeys(ulong seed)
        {
            throw new NotImplementedException();
        }
    }
}
