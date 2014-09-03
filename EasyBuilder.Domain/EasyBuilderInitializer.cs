using EasyBuilder.Domain.Entities.Admin;
using EasyBuilder.Infrastructure.SysConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Domain
{
    public class EasyBuilderInitializer : DropCreateDatabaseIfModelChanges<EasyBuilderDbContext>
    {
        protected override void Seed(EasyBuilderDbContext context)
        {

            Guid managerkey = Guid.NewGuid();
            context.AdminManager.Add(new Admin_Manager { Key = managerkey, Name = "超级管理员", Username = "admin", Password = DefaultConfig.Password, IsManager = true });
            Guid menu1 = Guid.NewGuid();
            context.AdminMenu.Add(new Admin_Menu { Key = menu1, IconCls = "icon-chartorganisation", Name = "组织机构", IntSort = 1 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu1, IconCls = "icon-special", Name = "角色管理", Url = "/Admin/Role", IntSort = 1 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu1, IconCls = "icon-customers", Name = "部门管理", Url = "", IntSort = 2 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu1, IconCls = "icon-suppliers", Name = "用户管理", IntSort = 3 });
            Guid menu2 = Guid.NewGuid();
            context.AdminMenu.Add(new Admin_Menu { Key = menu2, IconCls = "icon-design", Name = "系统设计", IntSort = 2 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu2, IconCls = "icon-sitemap", Name = "菜单管理", IntSort = 1 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu2, IconCls = "icon-page", Name = "页面管理", IntSort = 2 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu2, IconCls = "icon-database", Name = "数据管理", IntSort = 3 });
            Guid menu3 = Guid.NewGuid();
            context.AdminMenu.Add(new Admin_Menu { Key = menu3, IconCls = "icon-settings", Name = "系统管理", IntSort = 3 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu3, IconCls = "icon-library_occupied", Name = "数据字典", IntSort = 1 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu3, IconCls = "icon-config", Name = "系统配置", IntSort = 2 });
            context.AdminMenu.Add(new Admin_Menu { Key = Guid.NewGuid(), ParentKey = menu3, IconCls = "icon-report", Name = "超级用户", IntSort = 3 });

            Guid role1 = Guid.NewGuid();
            Guid role2 = Guid.NewGuid();
            context.AdminRole.Add(new Admin_Role { Key = role1, Name = "测试角色1", IntSort = 1 });
            context.AdminRole.Add(new Admin_Role { Key = role2, Name = "测试角色2", IntSort = 2 });

            Guid dept1 = Guid.NewGuid();
            Guid dept2 = Guid.NewGuid();
            context.AdminDepartment.Add(new Admin_Department { Key = dept1, Name = "测试部门1", IntSort = 1 });
            context.AdminDepartment.Add(new Admin_Department { Key = dept2, Name = "测试部门2", IntSort = 2 });

            Guid user1 = Guid.NewGuid();
            Guid user2 = Guid.NewGuid();
            context.AdminUser.Add(new Admin_User { Key = user1, Name = "测试用户1", Username = "test", Password = DefaultConfig.Password, RoleKey = role1, DepartmentKey = dept1, IntSort = 1 });
            context.AdminUser.Add(new Admin_User { Key = user2, Name = "测试用户2", Username = "test2", Password = DefaultConfig.Password, RoleKey = role1, DepartmentKey = dept1, IntSort = 2 });
        }
    }
}
