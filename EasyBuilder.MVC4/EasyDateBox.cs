using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
    [Parser("easyui-datebox", "input")]
    public class EasyDateBox : EasyBuilderBase
    {
        public EasyDateBox() { }
        public int? panelWidth { get; set; }
        public int? panelHeight { get; set; }
        public string currentText { get; set; }
        public string closeText { get; set; }
        public string okText { get; set; }
        public bool? disabled { get; set; }
        public object buttons { get; set; }
        public string sharedCalendar { get; set; }
        public Function formatter { get; set; }
        public Function parser { get; set; }
        public Function onSelect { get; set; }

        //-extend form combo
        public int? width { get; set; }
        public int? height { get; set; }
        public bool? multiple { get; set; }
        public bool? selectOnNavigation { get; set; }
        public string separator { get; set; }
        public bool? editable { get; set; }
        public bool? hasDownArrow { get; set; }
        public string value { get; set; }
        public int? delay { get; set; }
        public object keyHandler { get; set; }
        public Function onShowPanel { get; set; }
        public Function onHidePanel { get; set; }
        public Function onChange { get; set; }

    }
}
