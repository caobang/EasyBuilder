using EasyBuilder.Core.Application;
using System;

namespace EasyBuilder.Core.Cryptographies
{
    /// <summary>
    /// Cryptography Static Class
    /// </summary>
    public static class Cryptography
    {
        /// <summary>
        /// Hash Configurator
        /// </summary>
        public static IApp UsingHashCryptography(this IApp app, HashCryptographyType hashCryptographyType, IHashCryptography hashcryptography)
        {
            if (hashcryptography == null) { throw new Exception("HashCryptography can not be null"); }
            if (hashCryptographyType == HashCryptographyType.MD5)
            {
                md5 = hashcryptography;
            }
            return app;
        }
        /// <summary>
        /// Symmetric Configurator
        /// </summary>
        public static IApp UsingSymmetricCryptography(this IApp app, SymmetricCryptographyType symmetricCryptographyType, ISymmetricCryptography symmetriccryptography)
        {
            if (symmetriccryptography == null) { throw new Exception("SymmetricCryptography can not be null"); }
            if (symmetricCryptographyType == SymmetricCryptographyType.Des)
            {
                des = symmetriccryptography;
            }
            else if (symmetricCryptographyType == SymmetricCryptographyType.Des)
            {
                rc2 = symmetriccryptography;
            }
            return app;
        }

        private static IHashCryptography md5;
        /// <summary>
        /// MD5 Hash
        /// </summary>
        public static IHashCryptography MD5
        {
            get
            {
                if (md5 == null)
                    throw new Exception("MD5 should be Initialized before using it.");
                return md5;
            }
        }
        private static ISymmetricCryptography des;
        /// <summary>
        /// Des
        /// </summary>
        public static ISymmetricCryptography Des
        {
            get
            {
                if (des == null)
                    throw new Exception("Des should be Initialized before using it.");
                return des;
            }
        }
        private static ISymmetricCryptography rc2;
        /// <summary>
        /// RC2
        /// </summary>
        public static ISymmetricCryptography RC2
        {
            get
            {
                if (rc2 == null)
                    throw new Exception("RC2 should be Initialized before using it.");
                return rc2;
            }
        }

    }
}
