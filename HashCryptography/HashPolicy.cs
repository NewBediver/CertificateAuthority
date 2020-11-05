using System.Collections.Generic;

namespace HashCryptography
{
    public interface IHashPolicy
    {
        public byte[] GetHash(byte[] message);
    }
}
