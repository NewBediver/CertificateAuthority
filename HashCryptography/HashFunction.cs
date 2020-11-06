using System;

namespace HashCryptography
{
    public class HashFunction
    {
        public IHashPolicy Policy
        {
            get
            {
                return m_Policy;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Hash policy cannot be null!");
                }
                m_Policy = value;
            }
        }

        public HashFunction(IHashPolicy policy)
        {
            Policy = policy;
        }

        public byte[] GetHash(byte[] message)
        {
            return Policy.GetHash(message);
        }

        private IHashPolicy m_Policy;
    }
}
