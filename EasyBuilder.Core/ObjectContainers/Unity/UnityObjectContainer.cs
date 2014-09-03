using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;

namespace EasyBuilder.Core.ObjectContainers.Unity
{
    /// <summary>
    /// UnityObjectContainer
    /// </summary>
    public class UnityObjectContainer : IObjectContainer
    {
        private readonly IUnityContainer _container;
        /// <summary>
        /// Stor
        /// </summary>
        public UnityObjectContainer()
        {
            _container = new UnityContainer();
        }
        /// <summary>
        /// get WrappedContainer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetWrappedContainer<T>()
        {
            if (!typeof(T).Equals(typeof(UnityContainer)))
                throw new Exception("The wrapped container type provided by the current object container should be UnityContainer.");
            return (T)this._container;
        }
        /// <summary>
        /// Register a type mapping with the container.
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="life"></param>
        public IObjectContainer RegisterType<TFrom, TTo>(LifeStyle life = LifeStyle.Transient)
            where TTo : TFrom
        {
            if (life == LifeStyle.Singleton)
            {
                _container.RegisterType<TFrom, TTo>(new ContainerControlledLifetimeManager());
            }
            else
            {
                _container.RegisterType<TFrom, TTo>();
            }
            return this;
        }
        /// <summary>
        /// Register a type mapping with the container.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="life"></param>
        /// <returns></returns>
        public IObjectContainer RegisterType(Type from, Type to, LifeStyle life = LifeStyle.Transient)
        {
            if (life == LifeStyle.Singleton)
            {
                _container.RegisterType(from, to, new ContainerControlledLifetimeManager());
            }
            else
            {
                _container.RegisterType(from, to);
            }
            return this;
        }

        /// <summary>
        /// Register an instance with the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        public IObjectContainer RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance<T>(instance, new ContainerControlledLifetimeManager());
            return this;
        }
        /// <summary>
        /// Check if a particular type has been registered with the container with the default name.
        /// </summary>
        public bool IsRegistered<T>()
        {
            return _container.IsRegistered<T>();
        }
        /// <summary>
        /// Check if a particular type has been registered with the container with the default name.
        /// </summary>
        public bool IsRegistered(Type typeToCheck)
        {
            return _container.IsRegistered(typeToCheck);
        }

        /// <summary>
        /// Resolve an instance of the default requested type from the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Resolve an instance of the default requested type from the container.
        /// </summary>
        /// <returns></returns>
        public object Resolve(Type t)
        {
            return _container.Resolve(t);
        }
        /// <summary>
        /// Return instances of all registered types requested.
        /// </summary>
        public IEnumerable<object> ResolveAll(Type t)
        {
            return _container.ResolveAll(t);
        }
    }
}
