using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-panel")]
    public class EasyPanel : EasyBuilderBase
    {
        public EasyPanel() { }
        public string id { get; set; }
        public string title { get; set; }
        public string iconCls { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
        public int? left { get; set; }
        public int? top { get; set; }
        public string cls { get; set; }
        public string headerCls { get; set; }
        public string bodyCls { get; set; }
        public string style { get; set; }
        public bool? fit { get; set; }
        public bool? border { get; set; }
        public bool? doSize { get; set; }
        public bool? noheader { get; set; }
        public string content { get; set; }
        public bool? collapsible { get; set; }
        public bool? minimizable { get; set; }
        public bool? maximizable { get; set; }
        public bool? closable { get; set; }
        public object tools { get; set; }
        public bool? collapsed { get; set; }
        public bool? minimized { get; set; }
        public bool? maximized { get; set; }
        public bool? closed { get; set; }
        public string href { get; set; }
        public bool? cache { get; set; }
        public string loadingMessage { get; set; }
        public string extractor { get; set; }

        public Function onLoad { get; set; }
        public Function onBeforeOpen { get; set; }
        public Function onOpen { get; set; }
        public Function onBeforeClose { get; set; }
        public Function onClose { get; set; }
        public Function onBeforeDestroy { get; set; }
        public Function onDestroy { get; set; }
        public Function onBeforeCollapse { get; set; }
        public Function onCollapse { get; set; }
        public Function onBeforeExpand { get; set; }
        public Function onExpand { get; set; }
        public Function onResize { get; set; }
        public Function onMove { get; set; }
        public Function onMaximize { get; set; }
        public Function onRestore { get; set; }
        public Function onMinimize { get; set; }

    }
}
