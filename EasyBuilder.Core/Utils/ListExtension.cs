using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Core.Utils
{
    /// <summary>
    /// List扩展方法
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// 将IEnumerable转换成集合并升序排序
        /// </summary>
        public static List<TSource> ToListAsc<TSource, Tkey>(this IEnumerable<TSource> source, Func<TSource, Tkey> sortField)
        {
            var list = source.ToList();
            list.Sort(new ObjectComparer<TSource, Tkey>(sortField, SortType.Asc));
            return list;
        }
        /// <summary>
        /// 将IEnumerable转换成集合并降序排序
        /// </summary>
        public static List<TSource> ToListDesc<TSource, Tkey>(this IEnumerable<TSource> source, Func<TSource, Tkey> sortField)
        {
            var list = source.ToList();
            list.Sort(new ObjectComparer<TSource, Tkey>(sortField, SortType.Desc));
            return list;
        }
    }
    /// <summary>
    /// 对象排序比较器
    /// </summary>
    public class ObjectComparer<TSource, Tkey> : IComparer<TSource>
    {
        private Func<TSource, Tkey> sortField;
        private SortType sortType;
        public ObjectComparer(Func<TSource, Tkey> sortField, SortType sortType)
        {
            this.sortField = sortField;
            this.sortType = sortType;
        }
        public int Compare(TSource x, TSource y)
        {
            object tx = sortField(x);
            object ty = sortField(y);
            if (tx is IComparable)
            {
                int result = ((IComparable)tx).CompareTo(ty);
                if (sortType == SortType.Desc)
                    result = result * (-1);
                return result;
            }
            return 0;
        }
    }
    /// <summary>
    /// 排序类型
    /// </summary>
    public enum SortType
    {
        Asc, Desc
    }
}
