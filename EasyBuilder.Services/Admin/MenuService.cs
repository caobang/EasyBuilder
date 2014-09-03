using EasyBuilder.Core.Repositories;
using EasyBuilder.Domain.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBuilder.Services.Admin
{
    public class MenuService : ServiceBase<Admin_Menu>, IMenuService
    {
        public MenuService(IRepository repository)
            : base(repository) { }
        /// <summary>
        /// 获取用户子菜单
        /// </summary>
        public List<Admin_Menu> GetSubMenus(Guid Key)
        {
            List<Admin_Menu> btnlist = new List<Admin_Menu>();
            var menus = Repository.Query<Admin_Menu>(b => b.ParentKey == Key, "IntSort").ToList();
            foreach (Admin_Menu menu in menus)
            {
                btnlist.Add(menu);
                btnlist.AddRange(GetSubMenus(menu.Key));
            }
            return btnlist;
        }
    }
}
