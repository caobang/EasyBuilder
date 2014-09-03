using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-menubutton", "a")]
    public class EasyMenuButton : EasyBuilderBase
    {
        public EasyMenuButton() { }

        public bool? plain { get; set; }
        public string menu { get; set; }
        public int? duration { get; set; }

        //--extend from linkbutton
        public string id { get; set; }
        public bool? disabled { get; set; }
        public bool? toggle { get; set; }
        public bool? selected { get; set; }
        public string group { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public string iconAlign { get; set; }
    }
}
