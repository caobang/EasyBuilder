using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Design
{
    [Table("Design_Menu")]
    public class Design_Menu : EntityTree
    {
        public string Name { get; set; }
        public string IconCls { get; set; }
        public bool Enabled { get; set; }
    }
}
