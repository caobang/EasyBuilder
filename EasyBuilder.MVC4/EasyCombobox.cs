using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-combobox", "select")]
    public class EasyComboBox : EasyBuilderBase
    {
        public EasyComboBox() { }
        public string valueField { get; set; }
        public string textField { get; set; }
        public string groupField { get; set; }
        public string groupFormatter { get; set; }
        public string mode { get; set; }
        public string url { get; set; }
        public string method { get; set; }
        public string data { get; set; }
        public string filter { get; set; }
        public string formatter { get; set; }
        public string loader { get; set; }
        public string loadFilter { get; set; }
        public Function onBeforeLoad { get; set; }
        public Function onLoadSuccess { get; set; }
        public Function onLoadError { get; set; }
        public Function onSelect { get; set; }
        public Function onUnselect { get; set; }

        //-extend form combo
        public int? width { get; set; }
        public int? height { get; set; }
        public int? panelWidth { get; set; }
        public int? panelHeight { get; set; }
        public bool? multiple { get; set; }
        public bool? selectOnNavigation { get; set; }
        public string separator { get; set; }
        public bool? editable { get; set; }
        public bool? disabled { get; set; }
        public bool? hasDownArrow { get; set; }
        public string value { get; set; }
        public int? delay { get; set; }
        public object keyHandler { get; set; }
        public Function onShowPanel { get; set; }
        public Function onHidePanel { get; set; }
        public Function onChange { get; set; }

    }
}
