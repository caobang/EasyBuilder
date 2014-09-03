using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public class Function
    {
        private string script;
        public string Script { get { return this.script; } }
        public Function(string script)
        {
            this.script = script;
        }
        public static Function Create(string jsfuncname)
        {
            string func = jsfuncname.Trim();
            if (func.StartsWith("function"))
                return new Function(func);
            else
                return new Function(string.Format("function(){0}{1}.apply(this,arguments){2}", "{", func, "}"));
        }
        public static Function Create(MvcHtmlString htmlstr)
        {
            return new Function(string.Format("function(){0}{1}{2}", "{", htmlstr.ToHtmlString(), "}"));
        }
        public static Function Eval(string script)
        {
            return new Function(script);
        }
        public static Function Eval(MvcHtmlString htmlstr)
        {
            return new Function(htmlstr.ToHtmlString());
        }
    }
}
