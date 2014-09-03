using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-calendar", "div")]
    public class EasyCalendar : EasyBuilderBase
    {
        public EasyCalendar() { }
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? fit { get; set; }
        public int? border { get; set; }
        public int? firstDay { get; set; }
        public int? weeks { get; set; }
        public int? months { get; set; }
        public int? year { get; set; }
        public int? month { get; set; }
        public int? current { get; set; }
        public Function onSelect { get; set; }
    }
}
