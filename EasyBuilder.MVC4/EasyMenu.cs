using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-menu", "div")]
    public class EasyMenu : EasyBuilderBase
    {
        public EasyMenu() { }
        public int? zIndex { get; set; }
        public int? left { get; set; }
        public int? top { get; set; }
        public int? minWidth { get; set; }
        public bool? hideOnUnhover { get; set; }
        public Function onShow { get; set; }
        public Function onHide { get; set; }
        public Function onClick { get; set; }
    }
}
