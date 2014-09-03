using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_Role")]
    public class Admin_Role : EntitySort
    {
        public string Name { get; set; }
    }
}
