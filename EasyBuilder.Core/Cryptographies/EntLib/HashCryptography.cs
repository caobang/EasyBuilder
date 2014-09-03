using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;

namespace EasyBuilder.Core.Cryptographies.EntLib
{
    /// <summary>
    /// 离散加密
    /// </summary>
    public class HashCryptography : IHashCryptography
    {
        private string hashInstance;
        /// <summary>
        /// 离散离散加密
        /// </summary>
        public HashCryptography(string hashkey)
        {
            this.hashInstance = hashkey;
        }
        /// <summary>
        /// 离散加密
        /// </summary>
        public byte[] CreateHash(byte[] plaintext)
        {
            return Cryptographer.CreateHash(this.hashInstance, plaintext);
        }
        /// <summary>
        /// 加密
        /// </summary>
        public string CreateHash(string plaintext)
        {
            return Cryptographer.CreateHash(this.hashInstance, plaintext);
        }
        /// <summary>
        /// 离散加密比较
        /// </summary>
        public bool CompareHash(byte[] plaintext, byte[] hashedText)
        {
            return Cryptographer.CompareHash(this.hashInstance, plaintext, hashedText);
        }
        /// <summary>
        /// 离散加密比较
        /// </summary>
        public bool CompareHash(string plaintext, string hashedText)
        {
            return Cryptographer.CompareHash(this.hashInstance, plaintext, hashedText);
        }
    }
}