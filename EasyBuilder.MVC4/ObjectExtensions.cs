using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// 将对象解析成直接嵌入js的内容
        /// </summary>
        public static string Parser(this object obj)
        {
            string str = string.Empty;
            if (obj is string)
                str = string.Format("'{0}'", obj.ToString());
            else if (obj is int)
                str = obj.ToString();
            else if (obj is bool)
                str = obj.ToString().ToLower();
            else if (obj is MvcHtmlString)
            {
                str = (obj as MvcHtmlString).ToHtmlString().Parser();
            }
            else if (obj is Function)
                str = (obj as Function).Script;
            else if (obj is IEnumerable)
            {
                foreach (object ob in (IEnumerable)obj)
                {
                    str += string.Format("{0}{1}{2},", "{", ob.Parser(), "}");
                }
                str = string.Format("[{0}]", str.TrimEnd(','));
            }
            else if (obj is IEasyBuilder)
            {
                PropertyInfo[] infos = obj.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo info in infos)
                {
                    object value = info.GetValue(obj);
                    if (value != null)
                    {
                        str += string.Format("{0}:{1},", info.Name, value.Parser());
                    }
                }
                str = str.TrimEnd(',');
            }
            else
            {
                PropertyInfo[] infos = obj.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo info in infos)
                {
                    object value = info.GetValue(obj);
                    if (value != null)
                    {
                        str += string.Format("{0}:{1},", info.Name, value.Parser());
                    }
                }
                str = string.Format("{0}{1}{2}", "{", str.TrimEnd(','), "}");
            }
            return str;
        }

    } 
}