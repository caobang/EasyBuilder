using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    public class EasyTabPanel : EasyBuilderBase
    {
        public EasyTabPanel() { }
        public string id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string href { get; set; }
        public bool? cache { get; set; }
        public string iconCls { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? collapsible { get; set; }
        public bool? closable { get; set; }
        public bool? selected { get; set; }
        public object tools { get; set; }

    }
}
