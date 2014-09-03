using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_Menu")]
    public class Admin_Menu : EntityTree
    {
        public string Name { get; set; }
        public string IconCls { get; set; }
        public string Url { get; set; }
    }
}
