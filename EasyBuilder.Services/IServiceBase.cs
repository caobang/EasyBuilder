using EasyBuilder.Core.Repositories.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Services
{
    public interface IServiceBase<T> where T : class
    {
        /// <summary>
        /// 根据Key查询实体
        /// </summary>
        T GetByKey(Guid Key);
        /// <summary>
        /// 根据Keys获取实体
        /// </summary>
        List<T> GetByKeys(List<Guid> Keys);
        /// <summary>
        /// 查询所有实体
        /// </summary>
        List<T> GetAll(string orderBy = null);
        /// <summary>
        /// 查询实体
        /// </summary>
        List<T> GetMany(Expression<Func<T, bool>> where, string orderBy = null);
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        PagingResult<T> GetPagingData(int pageIndex, int pageSize, string sortName, string orderName);
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        PagingResult<T> GetPagingData(Expression<Func<T, bool>> where, int pageIndex, int pageSize, string sortName, string orderName);
        /// <summary>
        /// 获取实体分页数据
        /// </summary>
        PagingResult<T> GetPagingData(string search, int pageIndex, int pageSize, string sortName, string orderName);
        /// <summary>
        /// 添加实体
        /// </summary>
        bool Add(T t);
        /// <summary>
        /// 批量添加实体
        /// </summary>
        bool Add(List<T> ts);
        /// <summary>
        /// 编辑实体
        /// </summary>
        bool Update(T t);
        /// <summary>
        /// 批量编辑实体
        /// </summary>
        bool Update(List<T> ts);
        /// <summary>
        /// 根据Key删除实体
        /// </summary>
        bool Delete(Guid Key);
        /// <summary>
        /// 根据Keys批量删除实体
        /// </summary>
        bool Delete(List<Guid> Keys);
    }
}
