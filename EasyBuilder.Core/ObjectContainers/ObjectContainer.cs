using EasyBuilder.Core.Application;
using System;

namespace EasyBuilder.Core.ObjectContainers
{
    /// <summary>
    /// ObjectContainer Statc=ic Class
    /// </summary>
    public static class ObjectContainer
    {
        private static IObjectContainer _objectContainer;
        /// <summary>
        /// Config ObjectContainer
        /// </summary>
        /// <param name="app"></param>
        /// <param name="objectContainerConfigurator"></param>
        /// <returns></returns>
        public static IApp UsingObjectContainer(this IApp app, IObjectContainerConfigurator objectContainerConfigurator)
        {
            if (objectContainerConfigurator == null)
                throw new Exception("ObjectContainerConfigurator can not be null");
            _objectContainer = objectContainerConfigurator.Register();
            return app;
        }
        /// <summary>
        /// Current ObjectContainer
        /// </summary>
        public static IObjectContainer Current
        {
            get
            {
                if (_objectContainer == null)
                    throw new Exception("Container should be Initialized before using it.");
                return _objectContainer;
            }
        }
    }
}