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

namespace EasyBuilder.Core.ObjectContainers
{
    /// <summary>
    /// IObjectContainerConfigurator Interface
    /// </summary>
    public interface IObjectContainerConfigurator
    {
        /// <summary>
        /// Initialize Event
        /// </summary>
        event Action<IObjectContainer> Initialize;
        /// <summary>
        /// Configure Action
        /// </summary>
        /// <param name="containerInitialize"></param>
        /// <returns></returns>
        IObjectContainerConfigurator Configure(Action<IObjectContainer> containerInitialize);
        /// <summary>
        /// Register Component
        /// </summary>
        /// <returns></returns>
        IObjectContainer Register();
    }
}