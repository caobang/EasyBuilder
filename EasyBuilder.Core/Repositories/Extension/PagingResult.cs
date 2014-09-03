using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyBuilder.Core.Repositories.Extension
{
    /// <summary>
    /// PagingResult Object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagingResult<T>
    {
        private int totalCount = 0;
        private int pageIndex = 0;
        private int pageSize = 10;
        private List<T> queryPage;
        /// <summary>
        /// Stor
        /// </summary>
        public PagingResult(IEnumerable<T> queryTotal, int pageIndex, int pageSize, IEnumerable<T> queryPage)
        {
            this.pageIndex = pageIndex;
            this.pageSize = pageSize;
            this.totalCount = queryTotal.AsQueryable().Count();
            this.queryPage = queryPage.ToList();
        }
        /// <summary>
        /// 总记录数量
        /// </summary>
        public int TotalCount
        {
            get { return this.totalCount; }
        }
        /// <summary>
        /// 当前页数
        /// </summary>
        public int PageIndex
        {
            get { return this.pageIndex; }
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageSize
        {
            get { return this.pageSize; }
        }
        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPages
        {
            get
            {
                return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(this.totalCount) / this.PageSize));
            }
        }
        /// <summary>
        /// 当前页记录数
        /// </summary>
        public int PageCount
        {
            get { return this.queryPage.Count(); }
        }
        /// <summary>
        /// 当前页数据集合
        /// </summary>
        public List<T> Data
        {
            get { return this.queryPage; }
        }
    }
}
