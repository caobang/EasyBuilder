using EasyBuilder.Core.Repositories;
using EasyBuilder.Core.Repositories.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EasyBuilder.Domain.Entities;
using EasyBuilder.Infrastructure.StringParser;

namespace EasyBuilder.Services
{
    /// <summary>
    /// 服务层基类 提供Repository对象
    /// </summary>
    public abstract class ServiceBase
    {
        private IRepository _repository;
        public IRepository Repository
        {
            get
            {
                return this._repository;
            }
        }
        public ServiceBase(IRepository repository)
        {
            this._repository = repository;
        }
    }
    /// <summary>
    /// 泛型服务层基类，封装对象操作常用方法 方便调用
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ServiceBase<T> : ServiceBase, IServiceBase<T> where T : Entity
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ServiceBase(IRepository repository) : base(repository) { }

        /// <summary>
        /// 根据Key查询实体
        /// </summary>
        public virtual T GetByKey(Guid Key)
        {
            var lambda = ExpressionHelper.CreateExpression<T>("Key", ExpressionType.Equal, Key);
            return Repository.QuerySingle<T>(lambda);
        }
        /// <summary>
        /// 根据Keys获取实体
        /// </summary>
        public virtual List<T> GetByKeys(List<Guid> Keys)
        {
            List<T> users = new List<T>();
            foreach (var Id in Keys)
            {
                var user = this.GetByKey(Id);
                users.Add(user);
            }
            return users;
        }
        /// <summary>
        /// 查询所有实体
        /// </summary>
        public virtual List<T> GetAll(string orderBy = null)
        {
            return Repository.QueryAll<T>(orderBy).ToList();
        }
        /// <summary>
        /// 查询实体
        /// </summary>
        public virtual List<T> GetMany(Expression<Func<T, bool>> where, string orderBy = null)
        {
            return Repository.Query<T>(where, orderBy).ToList();
        }
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        public virtual PagingResult<T> GetPagingData(int pageIndex, int pageSize, string sortName, string orderName)
        {
            var pagingResult = Repository.GetPagingResult<T>(pageIndex, pageSize, sortName + " " + orderName);
            return pagingResult;
        }
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        public virtual PagingResult<T> GetPagingData(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string sortName, string orderName)
        {
            var pagingResult = Repository.GetPagingResult<T>(where, pageIndex, pageSize, sortName + " " + orderName);
            return pagingResult;
        }
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        public virtual PagingResult<T> GetPagingData(string search, int pageIndex, int pageSize, string sortName, string orderName)
        {
            var pagingResult = Repository.GetPagingResult<T>(QueryParamParser.ToLinq<T>(search), pageIndex, pageSize, sortName + " " + orderName);
            return pagingResult;
        }
        /// <summary>
        /// 添加实体
        /// </summary>
        public virtual bool Add(T t)
        {
            Repository.Add(t);
            bool result = Repository.Context.Commit();
            return result;
        }
        /// <summary>
        /// 批量添加实体
        /// </summary>
        public virtual bool Add(List<T> ts)
        {
            Repository.Add(ts);
            bool result = Repository.Context.Commit();
            return result;
        }
        /// <summary>
        /// 编辑实体
        /// </summary>
        public virtual bool Update(T t)
        {
            Repository.Update(t);
            bool result = Repository.Context.Commit();
            return result;
        }
        /// <summary>
        /// 批量编辑实体
        /// </summary>
        public virtual bool Update(List<T> ts)
        {
            Repository.Update(ts);
            bool result = Repository.Context.Commit();
            return result;
        }
        /// <summary>
        /// 根据Key删除实体
        /// </summary>
        public virtual bool Delete(Guid Key)
        {
            T t = this.GetByKey(Key);
            Repository.Delete(t);
            bool result = Repository.Context.Commit();
            return result;
        }
        /// <summary>
        /// 根据Keys批量删除实体
        /// </summary>
        public virtual bool Delete(List<Guid> Keys)
        {
            var ts = GetByKeys(Keys);
            Repository.Delete(ts);
            bool result = Repository.Context.Commit();
            return result;
        }
    }
}
