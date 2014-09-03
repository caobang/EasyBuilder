// ===========================================================================================================================================================
//
//
//             ▓▓▓     ▓    ▓  ▓   ▓  ▓    ▓▓▓   ▓  ▓     ▓        ▓     ▓      ▓▓▓   ▓          ▓      ▓▓      ▓  ▓   ▓  ▓
//            ▓    ▓         ▓ ▓    ▓  ▓    ▓       ▓ ▓     ▓ ▓      ▓ ▓  ▓ ▓   ▓        ▓    ▓    ▓    ▓    ▓   ▓ ▓    ▓  ▓
//           ▓    ▓    ▓    ▓▓     ▓▓      ▓▓▓   ▓▓     ▓▓▓     ▓  ▓ ▓  ▓   ▓▓▓     ▓  ▓▓  ▓    ▓     ▓   ▓▓     ▓▓
//          ▓   ▓     ▓    ▓       ▓  ▓    ▓       ▓       ▓   ▓    ▓   ▓▓   ▓  ▓          ▓ ▓ ▓ ▓      ▓   ▓   ▓       ▓  ▓
//         ▓▓▓      ▓     ▓       ▓   ▓   ▓       ▓      ▓    ▓   ▓    ▓     ▓  ▓▓▓       ▓    ▓         ▓▓     ▓       ▓   ▓
//
//
//           Name:    DirkFramework
//         Author:    Caobang
//        Version:    v1.0
//   RevisionDate:    2013-12-03
// ===========================================================================================================================================================

using System;
using System.Collections.Generic;

namespace EasyBuilder.Core.ObjectContainers
{
    /// <summary>
    /// IObjectContainer Interface
    /// </summary>
    public interface IObjectContainer
    {
        /// <summary>
        /// get WrappedContainer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetWrappedContainer<T>();

        /// <summary>
        /// Register a type mapping with the container.
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="life"></param>
        IObjectContainer RegisterType<TFrom, TTo>(LifeStyle life = LifeStyle.Transient)
            where TTo : TFrom;

        /// <summary>
        /// Register a type mapping with the container.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="life"></param>
        /// <returns></returns>
        IObjectContainer RegisterType(Type from, Type to, LifeStyle life = LifeStyle.Transient);

        /// <summary>
        /// Register an instance with the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        IObjectContainer RegisterInstance<T>(T instance);

        /// <summary>
        /// Check if a particular type has been registered with the container with the default name.
        /// </summary>
        bool IsRegistered<T>();

        /// <summary>
        /// Check if a particular type has been registered with the container with the default name.
        /// </summary>
        bool IsRegistered(Type typeToCheck);

        /// <summary>
        /// Resolve an instance of the default requested type from the container.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();

        /// <summary>
        /// Resolve an instance of the default requested type from the container.
        /// </summary>
        /// <returns></returns>
        object Resolve(Type t);

        /// <summary>
        /// Return instances of all registered types requested.
        /// </summary>
        IEnumerable<object> ResolveAll(Type t);

    }
}
