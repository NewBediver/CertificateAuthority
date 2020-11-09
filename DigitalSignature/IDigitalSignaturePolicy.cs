namespace DigitalSignature
{
    public interface IDigitalSignaturePolicy
    {
        public byte[] GeneratePrivateKey(int seed);
        public byte[] GeneratePublicKey(byte[] privateKey);
        public byte[] CreateSignature(byte[] message, byte[] privateKey);
        public bool IsSignatureValid(byte[] message, byte[] signature, byte[] publicKey);
    }
}
