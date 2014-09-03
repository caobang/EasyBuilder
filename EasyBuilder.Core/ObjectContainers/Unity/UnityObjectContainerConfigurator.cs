using System;

namespace EasyBuilder.Core.ObjectContainers.Unity
{
    /// <summary>
    /// Config Unity
    /// </summary>
    public class UnityObjectContainerConfigurator : IObjectContainerConfigurator
    {
        private readonly IObjectContainer _objectContainer;
        /// <summary>
        /// Stor
        /// </summary>
        public UnityObjectContainerConfigurator(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }
        /// <summary>
        /// Initialize Event
        /// </summary>
        public event Action<IObjectContainer> Initialize;
        /// <summary>
        /// Configure Action
        /// </summary>
        /// <param name="containerInitialize"></param>
        /// <returns></returns>
        public IObjectContainerConfigurator Configure(Action<IObjectContainer> containerInitialize)
        {
            if (this._objectContainer != null)
                this.Initialize += containerInitialize;
            return this;
        }
        /// <summary>
        /// Register Component
        /// </summary>
        /// <returns></returns>
        public IObjectContainer Register()
        {
            if (this._objectContainer == null)
                throw new Exception("The current object container can not be null.");
            if (this.Initialize != null)
                this.Initialize(this._objectContainer);
            return this._objectContainer;
        }
    }
}