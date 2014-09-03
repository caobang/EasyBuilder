namespace EasyBuilder.Core.Repositories
{
    /// <summary>
    /// IUnitOfWork Interface
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 开始上下文
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// 提交 并返回是否成功
        /// </summary>
        bool Commit();
        /// <summary>
        /// 回滚
        /// </summary>
        void Rollback();
    }
}