using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    public class EasyLayoutPanel : EasyBuilderBase
    {
        public EasyLayoutPanel() { }
        public string title { get; set; }
        public string region { get; set; }
        public bool? border { get; set; }
        public bool? split { get; set; }
        public string iconCls { get; set; }
        public string href { get; set; }
        public bool? collapsible { get; set; }
        public int? minWidth { get; set; }
        public int? minHeight { get; set; }
        public int? maxWidth { get; set; }
        public int? maxHeight { get; set; }

        public int? width { get; set; }
        public int? height { get; set; }
        public string content { get; set; }

        public Function onCollapse { get; set; }
        public Function onExpand { get; set; }
    }
}
