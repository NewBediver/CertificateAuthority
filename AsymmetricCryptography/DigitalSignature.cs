using System;

namespace DigitalSignature
{
    public class DigitalSignature
    {
        public IDigitalSignaturePolicy Policy
        {
            get
            {
                return m_SigPolicy;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Digital signature policy cannot be null!");
                }
                m_SigPolicy = value;
            }
        }

        public DigitalSignature(IDigitalSignaturePolicy sigPolicy)
        {
            Policy = sigPolicy;
        }

        public byte[] CreateSignature(byte[] message, byte[] privateKey)
        {
            return Policy.CreateSignature(message, privateKey);
        }

        public bool IsSignatureValid(byte[] message, byte[] signature, byte[] publicKey)
        {
            return Policy.IsSignatureValid(message, signature, publicKey);
        }

        private IDigitalSignaturePolicy m_SigPolicy;
    }
}
