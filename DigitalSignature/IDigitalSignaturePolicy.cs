namespace DigitalSignature
{
    public interface IDigitalSignaturePolicy
    {
        public byte[] GeneratePrivateKey(int seed);
        public byte[] GeneratePublicKey(byte[] privateKey);
        public byte[] CreateSignature(byte[] messageHash, byte[] privateKey);
        public bool IsSignatureValid(byte[] messageHash, byte[] signature, byte[] publicKey);
    }
}
