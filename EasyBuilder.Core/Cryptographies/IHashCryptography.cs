namespace EasyBuilder.Core.Cryptographies
{
    /// <summary>
    /// 离散加密接口
    /// </summary>
    public interface IHashCryptography
    {
        /// <summary>
        /// 离散加密
        /// </summary>
        byte[] CreateHash(byte[] plaintext);
        /// <summary>
        /// 离散加密
        /// </summary>
        string CreateHash(string plaintext);
        /// <summary>
        /// 离散加密比较
        /// </summary>
        bool CompareHash(byte[] plaintext, byte[] hashedText);
        /// <summary>
        /// 离散加密比较
        /// </summary>
        bool CompareHash(string plaintext, string hashedText);
    }
}