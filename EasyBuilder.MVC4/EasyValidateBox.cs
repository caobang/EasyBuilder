using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-validatebox", "input")]
    public class EasyValidateBox : EasyBuilderBase
    {
        public EasyValidateBox() { }
        public bool? required { get; set; }
        public object validType { get; set; }
        public int? delay { get; set; }
        public string missingMessage { get; set; }
        public string invalidMessage { get; set; }
        public string tipPosition { get; set; }
        public int? deltaX { get; set; }
        public bool? novalidate { get; set; }

        public override MvcHtmlString Html()
        {
            EasyDom dom = new EasyDom("span") { Class = "combo" };
            this.Style = this.Style == null ? "" : this.Style;
            this.Style = "border:none;height:18px;" + this.Style;
            return dom.Append(base.Html().ToHtmlString()).Html();
        }
    }
}
