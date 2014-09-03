using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EasyBuilder.Infrastructure.DataExtension
{
    /// <summary>
    /// 实体类型与视图模型类相互转换的静态类,包含类型转换的一些扩展方法
    /// </summary>
    public static class MapperExtension
    {
        /// <summary>
        /// 扩展方法 将对象转换成映射类型
        /// </summary>
        public static TResult MapTo<TResult>(this object self)
        {
            if (self == null)
                throw new Exception("对象为空值");
            return (TResult)Mapper.Map(self, self.GetType(), typeof(TResult));
        }

        /// <summary>
        /// 扩展方法 将对象转换成映射类型 该方法不强制指定转换类型
        /// </summary>
        public static object MapTo(this object self)
        {
            if (self == null)
                throw new Exception("对象为空值");
            Type mapperType = MapperHelper.GetMappedType(self.GetType());
            if (mapperType == null)
                throw new Exception("未找到对象对应转换类型");
            return Mapper.Map(self, self.GetType(), mapperType);
        }

        /// <summary>
        /// 扩展方法 将List集合对象转换成映射类型List集合
        /// </summary>
        public static List<TResult> MapTo<TResult>(this IEnumerable self)
        {
            if (self == null)
                throw new Exception("集合对象为空值");
            return (List<TResult>)Mapper.Map(self, self.GetType(), typeof(List<TResult>));
        }

        /// <summary>
        /// 扩展方法 将List集合对象转换成映射类型List集合 该方法不强制指定转换类型
        /// </summary>
        public static object MapTo(this IEnumerable self)
        {
            if (self == null)
                throw new Exception("对象为空值");
            Type mapperType = MapperHelper.GetMappedType(self.GetType());
            if (mapperType == null)
                throw new Exception("未找到对象对应转换类型");
            Type mList = typeof(List<>);
            Type mapperList = mList.MakeGenericType(mapperType);
            return Mapper.Map(self, self.GetType(), mapperList);
        }
    }
}
