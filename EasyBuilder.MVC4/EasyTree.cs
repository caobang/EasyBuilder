using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-tree", "ul")]
    public class EasyTree : EasyBuilderBase
    {
        public EasyTree() { }
        public string url { get; set; }
        public string method { get; set; }
        public bool? animate { get; set; }
        public bool? checkbox { get; set; }
        public bool? cascadeCheck { get; set; }
        public bool? onlyLeafCheck { get; set; }
        public bool? lines { get; set; }
        public bool? dnd { get; set; }
        public object data { get; set; }
        public Function formatter { get; set; }
        public Function loader { get; set; }
        public Function loadFilter { get; set; }

        public Function onClick { get; set; }
        public Function onDblClick { get; set; }
        public Function onBeforeLoad { get; set; }
        public Function onLoadSuccess { get; set; }
        public Function onLoadError { get; set; }
        public Function onBeforeExpand { get; set; }
        public Function onExpand { get; set; }
        public Function onBeforeCollapse { get; set; }
        public Function onCollapse { get; set; }
        public Function onBeforeCheck { get; set; }
        public Function onCheck { get; set; }
        public Function onBeforeSelect { get; set; }
        public Function onSelect { get; set; }
        public Function onContextMenu { get; set; }
        public Function onBeforeDrag { get; set; }
        public Function onStartDrag { get; set; }
        public Function onStopDrag { get; set; }
        public Function onDragEnter { get; set; }
        public Function onDragOver { get; set; }
        public Function onDragLeave { get; set; }
        public Function onBeforeDrop { get; set; }
        public Function onDrop { get; set; }
        public Function onBeforeEdit { get; set; }
        public Function onAfterEdit { get; set; }
        public Function onCancelEdit { get; set; }
    }
}
