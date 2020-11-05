using System;
using System.Collections.Generic;
using System.Text;

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

        public byte[] GetHash(string message)
        {
            return Policy.GetHash(Encoding.ASCII.GetBytes(message));
        }

        private IHashPolicy m_Policy;
    }
}
