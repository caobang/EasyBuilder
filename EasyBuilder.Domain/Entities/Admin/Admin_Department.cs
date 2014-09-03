using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_Departmen")]
    public class Admin_Department : EntityTree
    {
        public string Name { get; set; }
    }
}
