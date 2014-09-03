using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace EasyBuilder.Core.Repositories.EntityFramework
{
    /// <summary>
    /// EFRepository
    /// </summary>
    public class EFRepository : Repository
    {
        /// <summary>
        /// Stor
        /// </summary>
        /// <param name="repositoryContext"></param>
        public EFRepository(IEFRepositoryContext repositoryContext)
            : base(repositoryContext) { }
        /// <summary>
        /// Add override
        /// </summary>
        public override void Add<T>(T entity)
        {
            if (entity == null)
                throw new Exception("entity不能为空");
            Context.RegisterNew(entity);
        }
        /// <summary>
        /// Update override
        /// </summary>
        public override void Update<T>(T entity)
        {
            if (entity == null)
                throw new Exception("entity不能为空");
            Context.RegisterModified(entity);
        }
        /// <summary>
        /// Delete override
        /// </summary>
        public override void Delete<T>(T entity)
        {
            if (entity == null)
                throw new Exception("entity不能为空");
            Context.RegisterDeleted(entity);
        }
        /// <summary>
        /// 根据条件查询
        /// </summary>
        protected override IEnumerable<T> DoQuery<T>(Expression<Func<T, bool>> where, string orderBy)
        {
            var query = ((IEFRepositoryContext)Context).EFContext.Set<T>().Where(where);
            if (string.IsNullOrWhiteSpace(orderBy))
                return query;
            string[] order = orderBy.Trim().Split(' ');
            string sortName = "";
            string sortOrder = "";
            if (order.Length == 0 || order.Length > 2)
                throw new Exception("查询字段格式错误");
            else
            {
                sortName = order[0];
                if (order.Length == 2)
                    sortOrder = order[1].ToLower();
            }
            if (sortOrder != "" && sortOrder != "asc" && sortOrder != "desc")
                throw new Exception("排序方式只能为asc、desc或空字符串");
            Type type = typeof(T);
            PropertyInfo property = type.GetProperty(sortName);
            if (property == null)
                throw new Exception("属性名称不存在");
            ParameterExpression param = Expression.Parameter(type, "p");
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);
            string methodName = sortOrder.ToLower() == "desc" ? "OrderByDescending" : "OrderBy";
            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, property.PropertyType }, query.Expression, Expression.Quote(orderByExpression));
            return query.Provider.CreateQuery<T>(resultExp);
        }
        /// <summary>
        /// 查询分页数据
        /// </summary>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        protected override IEnumerable<T> DoQueryPaging<T>(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string orderBy)
        {
            if (pageIndex < 0)
                throw new Exception("页码pageIndex必须大于或等于0。");
            if (pageSize < 0)
                throw new Exception("每页大小pageSize必须大于或等于0。");
            var query = DoQuery(where, orderBy).AsQueryable();
            return query.Skip(pageSize * pageIndex).Take(pageSize);
        }
    }
}
