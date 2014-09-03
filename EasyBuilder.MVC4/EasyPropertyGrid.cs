using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-propertygrid", "table")]
    public class EasyPropertyGrid : EasyBuilderBase
    {
        public EasyPropertyGrid() { }
        public bool? showGroup { get; set; }
        public string groupField { get; set; }
        public Function groupFormatter { get; set; }

        //--extend from datagrid
        public object columns { get; set; }
        public object frozenColumns { get; set; }
        public bool? fitColumns { get; set; }
        public string resizeHandle { get; set; }
        public bool? autoRowHeight { get; set; }
        public object toolbar { get; set; }
        public bool? striped { get; set; }
        public string method { get; set; }
        public bool? nowrap { get; set; }
        public string idField { get; set; }
        public string url { get; set; }
        public object data { get; set; }
        public string loadMsg { get; set; }
        public bool? pagination { get; set; }
        public bool? rownumbers { get; set; }
        public bool? singleSelect { get; set; }
        public bool? checkOnSelect { get; set; }
        public bool? selectOnCheck { get; set; }
        public string pagePosition { get; set; }
        public int? pageNumber { get; set; }
        public int? pageSize { get; set; }
        public object pageList { get; set; }
        public object queryParams { get; set; }
        public string sortName { get; set; }
        public string sortOrder { get; set; }
        public bool? multiSort { get; set; }
        public bool? remoteSort { get; set; }
        public bool? showHeader { get; set; }
        public bool? showFooter { get; set; }
        public int? scrollbarSize { get; set; }
        public Function rowStyler { get; set; }
        public Function loader { get; set; }
        public Function loadFilter { get; set; }
        public object editors { get; set; }
        public object view { get; set; }
    }
}
