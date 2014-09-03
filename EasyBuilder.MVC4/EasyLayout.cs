using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-layout")]
    public class EasyLayout : EasyBuilderBase
    {
        public EasyLayout() { }
        public bool? fit { get; set; }
    }
}
