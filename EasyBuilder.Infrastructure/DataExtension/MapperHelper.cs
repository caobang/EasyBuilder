
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Infrastructure.DataExtension
{
    /// <summary>
    /// 与AutoMapper相关的工具类
    /// </summary>
    public sealed class MapperHelper
    {
        /// <summary>
        /// 将排序参数中映射类型排序字段转换为实体类型字段
        /// </summary>
        public static string GetMappedOrderBy<T>(string orderBy)
        {
            if (string.IsNullOrWhiteSpace(orderBy))
                return orderBy;
            Type mappedType = MapperHelper.GetMappedType<T>();
            if (mappedType == null)
                return orderBy;
            string[] order = orderBy.Trim().Split(' ');
            string orderName = "";
            orderName = order[0];
            PropertyInfo property = mappedType.GetProperty(orderName);
            if (property == null)
                throw new Exception(mappedType.Name + "不存在属性" + orderName);
            object[] obj = property.GetCustomAttributes(typeof(OrderMapperAttribute), true);
            if (obj.Length == 0)
                return orderBy;
            string MappedName = (obj[0] as OrderMapperAttribute).FieldName;
            return orderBy.Replace(orderName, MappedName);
        }

        ///存储实体类型与dto类型的集合
        private static Dictionary<Type, Type> typeDic = new Dictionary<Type, Type>();
        public static Dictionary<Type, Type> TypeDic
        {
            get
            {
                if (typeDic.Count == 0)
                {
                    TypeMap[] types = Mapper.GetAllTypeMaps();
                    foreach (TypeMap t in types)
                    {
                        typeDic.Add(t.SourceType, t.DestinationType);
                    }
                }
                return typeDic;
            }
        }

        /// <summary>
        /// 从AutoMapper注册类型中 获取实体类型对应的dto类型
        /// </summary>
        public static Type GetMappedType<T>()
        {
            return GetMappedType(typeof(T));
        }

        /// <summary>
        /// 从AutoMapper注册类型中 获取实体类型对应的dto类型
        /// </summary>
        public static Type GetMappedType(Type type)
        {
            Type mappedType = null;
            TypeDic.TryGetValue(type, out mappedType);
            return mappedType;
        }
    }
}

