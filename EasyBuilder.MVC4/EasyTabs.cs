using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-tabs")]
    public class EasyTabs : EasyBuilderBase
    {
        public EasyTabs() { }
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? plain { get; set; }
        public bool? fit { get; set; }
        public bool? border { get; set; }
        public int? scrollIncrement { get; set; }
        public int? scrollDuration { get; set; }
        public object tools { get; set; }
        public string toolPosition { get; set; }
        public string tabPosition { get; set; }
        public int? headerWidth { get; set; }
        public int? tabWidth { get; set; }
        public int? tabHeight { get; set; }
        public int? selected { get; set; }
        public bool? showHeader { get; set; }
        public Function onLoad { get; set; }
        public Function onSelect { get; set; }
        public Function onUnselect { get; set; }
        public Function onBeforeClose { get; set; }
        public Function onClose { get; set; }
        public Function onAdd { get; set; }
        public Function onUpdate { get; set; }
        public Function onContextMenu { get; set; }
    }
}
