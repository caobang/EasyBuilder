using System;
using System.Collections.Generic;

namespace EasyBuilder.Infrastructure.ActionResults
{
    public class TreeData
    {
        public Guid id { get; set; }
        public Guid? pid { get; set; }
        public string text { get; set; }
        public string iconCls { get; set; }
        public string state { get; set; }
        public TreeAttributes attributes { get; set; }
        public List<TreeData> children { get; set; }
    }
}
