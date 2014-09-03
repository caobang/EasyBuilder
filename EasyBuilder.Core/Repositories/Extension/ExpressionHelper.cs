using System;
using System.Linq.Expressions;

namespace EasyBuilder.Core.Repositories.Extension
{
    /// <summary>
    /// 动态创建表达式 工具类
    /// </summary>
    public static class ExpressionHelper
    {
        /// <summary>
        /// 动态创建表达式
        /// </summary>
        public static Expression<Func<T, bool>> CreateExpression<T>(string FieldName, ExpressionType type, object Value) where T : class
        {
            ParameterExpression parExp = Expression.Parameter(typeof(T), "a");
            MemberExpression menberExp = Expression.Property(parExp, FieldName);
            ConstantExpression constant = Expression.Constant(Value);
            BinaryExpression eExp = Expression.MakeBinary(type, menberExp, constant);
            Expression<Func<T, bool>> lambda = Expression.Lambda<Func<T, bool>>(eExp, parExp);
            return lambda;
        }
    }
}