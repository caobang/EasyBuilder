using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.MVC4
{
   public  class EasyDataGridColumn:EasyBuilderBase
    {
       public EasyDataGridColumn() { }
       public string title { get; set; }
       public string field { get; set; }
       public int? width { get; set; }
       public int? rowspan { get; set; }
       public int? colspan { get; set; }
       public string align { get; set; }
       public string halign { get; set; }
       public bool? sortable { get; set; }
       public string order { get; set; }
       public bool? resizable { get; set; }
       public bool? hidden { get; set; }
       public bool? checkbox { get; set; }
       public Function formatter { get; set; }
       public Function styler { get; set; }
       public Function sorter { get; set; }
       public object editor { get; set; }
    }
}
