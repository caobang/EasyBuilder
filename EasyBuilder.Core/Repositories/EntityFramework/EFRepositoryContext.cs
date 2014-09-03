using System.Data.Entity;

namespace EasyBuilder.Core.Repositories.EntityFramework
{
    /// <summary>
    /// EFRepositoryContext
    /// </summary>
    public class EFRepositoryContext : IEFRepositoryContext
    {
        private DbContext _context;
        /// <summary>
        /// Stor
        /// </summary>
        /// <param name="context"></param>
        public EFRepositoryContext(DbContext context)
        {
            this._context = context;
        }

        #region IEFRepositoryContext
        /// <summary>
        /// Get EFContext DbContext
        /// </summary>
        public DbContext EFContext
        {
            get { return _context; }
        }
        #endregion

        #region IRepositoryContext
        /// <summary>
        /// RegisterNew
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterNew(object obj)
        {
            this._context.Entry(obj).State = EntityState.Added;
            this.uncommitted++;
        }
        /// <summary>
        /// RegisterModified
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterModified(object obj)
        {
            this._context.Entry(obj).State = EntityState.Modified;
            this.uncommitted++;
        }
        /// <summary>
        /// RegisterDeleted
        /// </summary>
        /// <param name="obj"></param>
        public void RegisterDeleted(object obj)
        {
            this._context.Entry(obj).State = EntityState.Deleted;
            this.uncommitted++;
        }
        #endregion

        #region IUnitOfWork
        private int uncommitted = 0;
        /// <summary>
        /// 开始上下文，未实现
        /// </summary>
        public void BeginTransaction() { }
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        public bool Commit()
        {
            if (this.uncommitted != 0)
            {
                int effect = this._context.SaveChanges();
                bool result = effect == this.uncommitted;
                this.uncommitted = 0;
                return result;
            }
            return false;
        }
        /// <summary>
        /// 回滚，未实现
        /// </summary>
        public void Rollback() { }
        /// <summary>
        /// 资源释放
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }
        #endregion
    }
}
