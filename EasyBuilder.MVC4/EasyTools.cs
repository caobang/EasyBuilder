using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    public class EasyTools : EasyBuilderBase
    {
        public EasyTools() { }
        public bool? toggle { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public Function handler { get; set; }
    }

}
