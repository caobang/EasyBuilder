using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EasyBuilder.Core.Repositories.Extension
{
    /// <summary>
    /// IRepository扩展方法
    /// </summary>
    public static class RepositoryExtension
    {
        /// <summary>
        /// 批量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entities"></param>
        public static void Add<T>(this IRepository repository, List<T> entities) where T : class
        {
            foreach (var entity in entities)
            {
                repository.Add(entity);
            }
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entities"></param>
        public static void Update<T>(this IRepository repository, List<T> entities) where T : class
        {
            foreach (var entity in entities)
            {
                repository.Update(entity);
            }
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="repository"></param>
        /// <param name="entities"></param>
        public static void Delete<T>(this IRepository repository, List<T> entities) where T : class
        {
            foreach (var entity in entities)
            {
                repository.Delete(entity);
            }
        }
        /// <summary>
        /// 获取分页结果对象
        /// </summary>
        public static PagingResult<T> GetPagingResult<T>(this IRepository repository, int pageIndex, int pageSize, string orderBy) where T : class
        {
            return repository.GetPagingResult<T>(o => true, pageIndex, pageSize, orderBy);
        }
        /// <summary>
        /// 获取分页结果对象
        /// </summary>
        public static PagingResult<T> GetPagingResult<T>(this IRepository repository, Expression<Func<T, bool>> where, int pageIndex, int pageSize, string orderBy) where T : class
        {
            var queryTotal = repository.Query(where);
            var queryPage = repository.QueryPaging(where, pageIndex, pageSize, orderBy);
            return new PagingResult<T>(queryTotal, pageIndex, pageSize, queryPage);
        }
    }
}