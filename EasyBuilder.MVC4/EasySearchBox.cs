using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-searchbox", "input")]
    public class EasySearchBox : EasyBuilderBase
    {
        public EasySearchBox()
        {

        }
        public int? width { get; set; }
        public int? height { get; set; }
        public string prompt { get; set; }
        public string value { get; set; }
        public string menu { get; set; }
        public Function searcher { get; set; }

    }
}
