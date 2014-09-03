using System.Data.Entity;

namespace EasyBuilder.Core.Repositories.EntityFramework
{
    /// <summary>
    /// IEFRepositoryContext Interface
    /// </summary>
    public interface IEFRepositoryContext : IRepositoryContext
    {
        /// <summary>
        /// Get EFContext DbContext
        /// </summary>
        DbContext EFContext { get; }
    }
}
