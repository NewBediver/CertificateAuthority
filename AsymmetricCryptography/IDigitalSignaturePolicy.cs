namespace DigitalSignature
{
    public interface IDigitalSignaturePolicy
    {
        public byte[] CreateSignature(byte[] message, byte[] privateKey);
        public bool IsSignatureValid(byte[] message, byte[] signature, byte[] publicKey);
    }
}
