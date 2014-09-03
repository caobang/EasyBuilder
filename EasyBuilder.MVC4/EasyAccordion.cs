using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-accordion")]
    public class EasyAccordion : EasyBuilderBase
    {
        public EasyAccordion() { }
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? fit { get; set; }
        public bool? border { get; set; }
        public bool? animate { get; set; }
        public bool? multiple { get; set; }
        public int? selected { get; set; }
    }
}
