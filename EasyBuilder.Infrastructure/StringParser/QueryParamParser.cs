using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBuilder.Core.Repositories.Extension;
using System.Linq.Expressions;
using System.Reflection;

namespace EasyBuilder.Infrastructure.StringParser
{
    public static class QueryParamParser
    {
        public static Expression<Func<T, bool>> ToLinq<T>(string search) where T : class
        {
            if (string.IsNullOrEmpty(search))
                return o => true;
            ParameterExpression parExp = Expression.Parameter(typeof(T), "a");
            string[] s = search.Trim().Split(':');
            Expression menberExp = Expression.Property(parExp, s[0]);
            ConstantExpression constant = Expression.Constant(s[1]);
            if (!menberExp.Type.Equals(typeof(string)))
                return o => true;
            MethodInfo method = menberExp.Type.GetMethod("Contains");
            MethodCallExpression ex = Expression.Call(menberExp, method, constant);
            var where = Expression.Lambda<Func<T, bool>>(ex, parExp);
            return where;
        }
    }
}
