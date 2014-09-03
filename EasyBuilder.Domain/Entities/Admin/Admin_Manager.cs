using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain.Entities.Admin
{
    [Table("Admin_Manager")]
    public class Admin_Manager : EntitySort
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsManager { get; set; }//超级管理员有最高的权限,其它为系统设计人员
    }
}
