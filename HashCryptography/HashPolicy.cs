namespace HashCryptography
{
    public interface IHashPolicy
    {
        public byte[] GetHash(byte[] message);
    }
}
