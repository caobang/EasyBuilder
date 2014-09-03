using EasyBuilder.Infrastructure.ObjectContainerAttributes;
using EasyBuilder.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyBuilder.Infrastructure.ActionResults;

namespace EasyBuilder.Areas.Admin.Controllers
{
    public class MenuController : BaseController
    {
        /// <summary>
        /// 注入服务
        /// </summary>
        [ResolveProperty]
        public IMenuService MenuService { get; set; }
        //
        // GET: /Admin/Menu/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取主目录
        /// </summary>
        public ActionResult GetSubMenus(Guid key)
        {
            var menus = MenuService.GetSubMenus(key);
            return this.TreeData(menus, a => a.Key, b => b.Name, c => c.ParentKey, d => d.IconCls, e => e.Url);
        }
    }
}
