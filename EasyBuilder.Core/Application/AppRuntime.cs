using System;
namespace EasyBuilder.Core.Application
{
    /// <summary>
    /// AppRuntime
    /// </summary>
    public sealed class AppRuntime
    {
        private static IApp _app = null;
        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public static IApp Create()
        {
            if (_app != null)
                throw new Exception("Could not create create app twice.");
            _app = new App();
            return _app;
        }
    }
}