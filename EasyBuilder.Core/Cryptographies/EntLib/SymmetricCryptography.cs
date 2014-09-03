using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;

namespace EasyBuilder.Core.Cryptographies.EntLib
{
    /// <summary>
    /// 对称性加解密
    /// </summary>
    public class SymmetricCryptography : ISymmetricCryptography
    {
        private string symmetricInstance;
        /// <summary>
        /// Stor
        /// </summary>
        public SymmetricCryptography(string symmetrickey)
        {
            this.symmetricInstance = symmetrickey;
        }
        /// <summary>
        /// 对称性加密
        /// </summary>
        public byte[] EncryptSymmetric(byte[] plaintext)
        {
            return Cryptographer.EncryptSymmetric(this.symmetricInstance, plaintext);
        }
        /// <summary>
        /// 对称性加密
        /// </summary>
        public string EncryptSymmetric(string plaintext)
        {
            return Cryptographer.EncryptSymmetric(this.symmetricInstance, plaintext);
        }
        /// <summary>
        /// 对称性解密
        /// </summary>
        public byte[] DecryptSymmetric(byte[] ciphertext)
        {
            return Cryptographer.DecryptSymmetric(this.symmetricInstance, ciphertext);
        }
        /// <summary>
        /// 对称性解密
        /// </summary>
        public string DecryptSymmetric(string ciphertextBase64)
        {
            return Cryptographer.DecryptSymmetric(this.symmetricInstance, ciphertextBase64);
        }
    }
}