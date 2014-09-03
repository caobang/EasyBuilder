using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_User")]
    public class Admin_User : EntitySort
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Guid RoleKey { get; set; }
        public Guid DepartmentKey { get; set; }

        [ForeignKey("RoleKey")]
        public virtual Admin_Role Role { get; set; }
        [ForeignKey("DepartmentKey")]
        public virtual Admin_Department Department { get; set; }
    }
}