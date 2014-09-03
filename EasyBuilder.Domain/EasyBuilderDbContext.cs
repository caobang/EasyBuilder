using EasyBuilder.Domain.Entities.Admin;
using EasyBuilder.Domain.Entities.Design;
using System.Data.Entity;

namespace EasyBuilder.Domain
{
    public class EasyBuilderDbContext: DbContext
    {
        public EasyBuilderDbContext()
            : base("EasyBuilder")
        {

        }

        public DbSet<Admin_Department> AdminDepartment { get; set; }
        public DbSet<Admin_Manager> AdminManager { get; set; }
        public DbSet<Admin_Dictionary> AdminDictionary { get; set; }
        public DbSet<Admin_Menu> AdminMenu { get; set; }
        public DbSet<Admin_Role> AdminRole { get; set; }
        public DbSet<Admin_SystemInfo> AdminSystemInfo { get; set; }
        public DbSet<Admin_User> AdminUser { get; set; }

        public DbSet<Design_Builder> DesignBuilder { get; set; }
        public DbSet<Design_Function> DesignFunction { get; set; }
        public DbSet<Design_Menu> DesignMenu { get; set; }
        public DbSet<Design_Page> DesignPage { get; set; }
        public DbSet<Design_PageComponent> DesignPageComponent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}