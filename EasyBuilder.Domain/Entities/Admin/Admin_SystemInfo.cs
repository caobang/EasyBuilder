using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_SystemInfo")]
    public class Admin_SystemInfo : Entity
    {
        public string Name { get; set; }
    }
}
