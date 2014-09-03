namespace EasyBuilder.Core.Cryptographies
{
    /// <summary>
    /// 对称性加解密接口
    /// </summary>
    public interface ISymmetricCryptography
    {
        /// <summary>
        /// 对称性加密
        /// </summary>
        byte[] EncryptSymmetric(byte[] plaintext);
        /// <summary>
        /// 对称性加密
        /// </summary>
        string EncryptSymmetric(string plaintext);
        /// <summary>
        /// 对称性解密
        /// </summary>
        byte[] DecryptSymmetric(byte[] ciphertext);
        /// <summary>
        /// 对称性解密
        /// </summary>
        string DecryptSymmetric(string ciphertextBase64);
    }
}
