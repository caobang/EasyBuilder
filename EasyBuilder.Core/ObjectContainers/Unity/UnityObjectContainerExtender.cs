using EasyBuilder.Core.Application;
using System;

namespace EasyBuilder.Core.ObjectContainers.Unity
{
    /// <summary>
    /// Unity Config Extender
    /// </summary>
    public static class UnityObjectContainerExtender
    {
        /// <summary>
        /// Config Unity
        /// </summary>
        public static IApp UsingUnityObjectContainer(this IApp app, Action<IObjectContainer> unityContainerInitialize = null)
        {
            IObjectContainer container = new UnityObjectContainer();
            IObjectContainerConfigurator configurator = new UnityObjectContainerConfigurator(container);
            configurator.Configure(unityContainerInitialize);
            return app.UsingObjectContainer(configurator);
        }
    }

}