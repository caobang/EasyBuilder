using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public interface IEasyBuilder
    {
        MvcHtmlString Html();
        IEasyBuilder Append(IEasyBuilder builder);
        IEasyBuilder Append(string html);
    }
}
