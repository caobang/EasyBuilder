using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EasyBuilder.Core.Repositories
{
    /// <summary>
    /// Repository Abstract Class
    /// </summary>
    public abstract class Repository : IRepository
    {
        private IRepositoryContext _repositoryContext;
        /// <summary>
        /// Get IRepositoryContext
        /// </summary>
        public IRepositoryContext Context
        {
            get
            {
                return this._repositoryContext;
            }
        }
        /// <summary>
        /// Stor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public Repository(IRepositoryContext repositoryContext)
        {
            this._repositoryContext = repositoryContext;
        }
        /// <summary>
        /// 添加
        /// </summary>
        public abstract void Add<T>(T entity) where T : class;
        /// <summary>
        /// 编辑
        /// </summary>
        public abstract void Update<T>(T entity) where T : class;
        /// <summary>
        /// 删除
        /// </summary>
        public abstract void Delete<T>(T entity) where T : class;

        /// <summary>
        /// 查询所有
        /// </summary>
        public IEnumerable<T> QueryAll<T>(string orderBy = null) where T : class
        {
            return this.Query<T>(o => true, orderBy);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        public IEnumerable<T> Query<T>(Expression<Func<T, bool>> where, string orderBy = null) where T : class
        {
            return this.DoQuery(where, orderBy);
        }

        /// <summary>
        /// 查询单条记录
        /// </summary>
        public T QuerySingle<T>(string orderBy = null) where T : class
        {
            return this.QuerySingle<T>(o => true, orderBy);
        }
        /// <summary>
        /// 查询单条记录
        /// </summary>
        public T QuerySingle<T>(Expression<Func<T, bool>> where, string orderBy = null) where T : class
        {
            return this.DoQuery(where, orderBy).AsQueryable().FirstOrDefault();
        }

        /// <summary>
        /// 查询分页数据
        /// </summary>
        public IEnumerable<T> QueryPaging<T>(int pageIndex, int pageSize, string orderBy = null) where T : class
        {
            return this.QueryPaging<T>(o => true, pageIndex, pageSize, orderBy);
        }
        /// <summary>
        /// 查询分页数据
        /// </summary>
        public IEnumerable<T> QueryPaging<T>(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string orderBy = null) where T : class
        {
            return this.DoQueryPaging(where, pageIndex, pageSize, orderBy);
        }

        /// <summary>
        /// 根据条件查询
        /// </summary>
        protected abstract IEnumerable<T> DoQuery<T>(Expression<Func<T, bool>> where, string orderBy) where T : class;
        /// <summary>
        /// 查询分页数据
        /// </summary>
        protected abstract IEnumerable<T> DoQueryPaging<T>(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string orderBy) where T : class;

    }
}

