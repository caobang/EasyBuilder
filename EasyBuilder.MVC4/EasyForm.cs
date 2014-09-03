using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-form", "form")]
    public class EasyForm : EasyBuilderBase
    {
        public EasyForm() { }
        public string url { get; set; }
        public Function onSubmit { get; set; }
        public Function success { get; set; }
        public Function onBeforeLoad { get; set; }
        public Function onLoadSuccess { get; set; }
        public Function onLoadError { get; set; }

        //extension
        public IEasyBuilder Fill(int column, params object[] builders)
        {
            if (column == 0 || builders == null)
                return this;
            StringBuilder content = new StringBuilder();
            content.Append("<table style='margin:auto;'><tr>");
            for (int i = 0; i < builders.Length; i++)
            {
                if (i > 0 && i % column == 0)
                    content.Append("</tr><tr>");
                if (builders[i] is IEasyBuilder)
                    content.AppendFormat("<td>{0}</td>", (builders[i] as IEasyBuilder).Html());
                else
                    content.AppendFormat("<td>{0}</td>", builders[i]);
            }
            content.Append("</tr></table>");
            this.Append(content.ToString());
            content.Clear();
            return this;
        }

    }
}
