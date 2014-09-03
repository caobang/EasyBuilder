using EasyBuilder.Core.Application;

namespace EasyBuilder.Core.Cryptographies.EntLib
{
    /// <summary>
    /// Cryptography Configurator Extender
    /// </summary>
    public static class CryptographyExtender
    {
        /// <summary>
        /// MD5 Configurator
        /// </summary>
        public static IApp UsingMD5Cryptography(this IApp app, string hashkey)
        {
            IHashCryptography cryptography = new HashCryptography(hashkey);
            return app.UsingHashCryptography(HashCryptographyType.MD5, cryptography);
        }
        /// <summary>
        /// Des Configurator
        /// </summary>
        public static IApp UsingDesCryptography(this IApp app, string symmetrickey)
        {
            ISymmetricCryptography cryptography = new SymmetricCryptography(symmetrickey);
            return app.UsingSymmetricCryptography(SymmetricCryptographyType.Des, cryptography);
        }
        /// <summary>
        /// RC2 Configurator
        /// </summary>
        public static IApp UsingRC2Cryptography(this IApp app, string symmetrickey)
        {
            ISymmetricCryptography cryptography = new SymmetricCryptography(symmetrickey);
            return app.UsingSymmetricCryptography(SymmetricCryptographyType.RC2, cryptography);
        }
    }
}
