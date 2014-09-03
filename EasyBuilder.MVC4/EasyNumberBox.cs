using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-numberbox","input")]
    public  class EasyNumberBox:EasyBuilderBase
    {
        public EasyNumberBox() { }
        public bool? disabled { get; set; }
        public int? value { get; set; }
        public int? min { get; set; }
        public int? max { get; set; }
        public int? precision { get; set; }
        public string decimalSeparator { get; set; }
        public string groupSeparator { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public Function filter { get; set; }
        public Function formatter { get; set; }
        public Function parser { get; set; }
        public Function onChange { get; set; }

        //-extend form validatebox
        public bool? required { get; set; }
        public object validType { get; set; }
        public int? delay { get; set; }
        public string missingMessage { get; set; }
        public string invalidMessage { get; set; }
        public string tipPosition { get; set; }
        public int? deltaX { get; set; }
        public bool? novalidate { get; set; }
    }
}
