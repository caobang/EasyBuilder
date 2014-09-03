using System;

namespace EasyBuilder.Core.Repositories
{
    /// <summary>
    /// 仓储上下文
    /// </summary>
    public interface IRepositoryContext : IUnitOfWork, IDisposable
    {
        /// <summary>
        /// RegisterNew
        /// </summary>
        void RegisterNew(object obj);
        /// <summary>
        /// RegisterModified
        /// </summary>
        void RegisterModified(object obj);
        /// <summary>
        /// RegisterDeleted
        /// </summary>
        void RegisterDeleted(object obj);
    }
}