using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    public class EasyAccordionPanel : EasyBuilderBase
    {
        public EasyAccordionPanel() { }
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
        public string selected { get; set; }

        public Function onSelect { get; set; }
        public Function onUnselect { get; set; }
        public Function onAdd { get; set; }
        public Function onBeforeRemove { get; set; }
        public Function onRemove { get; set; }
    }
}
