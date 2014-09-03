using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EasyBuilder.Core.Repositories
{
    /// <summary>
    /// 仓储对象
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// 仓储上下文
        /// </summary>
        IRepositoryContext Context { get; }
        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="entity"></param>
        void Add<T>(T entity) where T : class;
        /// <summary>
        /// 更新操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Update<T>(T entity) where T : class;
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        void Delete<T>(T entity) where T : class;

        /// <summary>
        /// 查询所有
        /// </summary>
        IEnumerable<T> QueryAll<T>(string orderBy = null) where T : class;
        /// <summary>
        /// 根据条件查询
        /// </summary>
        IEnumerable<T> Query<T>(Expression<Func<T, bool>> where, string orderBy = null) where T : class;

        /// <summary>
        /// 查询单条记录
        /// </summary>
        T QuerySingle<T>(string orderBy = null) where T : class;
        /// <summary>
        /// 查询单条记录
        /// </summary>
        T QuerySingle<T>(Expression<Func<T, bool>> where, string orderBy = null) where T : class;

        /// <summary>
        /// 查询分页数据
        /// </summary>
        IEnumerable<T> QueryPaging<T>(int pageIndex, int pageSize, string orderBy = null) where T : class;
        /// <summary>
        /// 查询分页数据
        /// </summary>
        IEnumerable<T> QueryPaging<T>(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string orderBy = null) where T : class;
    }
}