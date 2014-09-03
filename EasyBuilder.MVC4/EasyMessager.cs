using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public static class EasyMessager
    {
        public static MvcHtmlString Show(object options)
        {
            string parser = string.Empty;
            string html = string.Format("$.messager.show({0});", options.Parser());
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Alert(string title, string msg, string icon = null, Function fn = null)
        {
            string parser = string.Empty;
            string html = string.Format("$.messager.alert({0}{1}{2}{3});", title.Parser(), msg.Parser(), icon == null ? string.Empty : "," + icon.Parser(), fn == null ? string.Empty : "," + fn.Parser());
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Confirm(string title, string msg,  Function fn = null)
        {
            string parser = string.Empty;
            string html = string.Format("$.messager.alert({0}{1}{2});", title.Parser(), msg.Parser(),  fn == null ? string.Empty : "," + fn.Parser());
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Prompt(string title, string msg, Function fn = null)
        {
            string parser = string.Empty;
            string html = string.Format("$.messager.alert({0}{1}{2});", title.Parser(), msg.Parser(), fn == null ? string.Empty : "," + fn.Parser());
            return MvcHtmlString.Create(html);
        }
        public static MvcHtmlString Progress(object options)
        {
            string parser = string.Empty;
            string html = string.Format("$.messager.progress({0});", options.Parser());
            return MvcHtmlString.Create(html);
        }
    }
}
