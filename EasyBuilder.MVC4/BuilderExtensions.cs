using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public static  class BuilderExtensions
    {
        public static MvcHtmlString Build(this HtmlHelper htmlHelper, IEasyBuilder builder)
        {
            return builder.Html();
        }
    }
}
