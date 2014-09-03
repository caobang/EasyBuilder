using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Core.Utils
{
    /// <summary>
    /// String扩展方法
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 将逗号分割的Guid字符串转换成Guid对象集合
        /// </summary>
        public static List<Guid> ToGuidList(this string str)
        {
            var guids = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            List<Guid> Guids = new List<Guid>();
            foreach (var guid in guids)
            {
                Guids.Add(new Guid(guid));
            }
            return Guids;
        }
    }
}
