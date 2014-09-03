using EasyBuilder.Infrastructure.ObjectContainerAttributes;
using EasyBuilder.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyBuilder.Areas.Admin.Controllers
{
    public class MainController : BaseController
    {
        /// <summary>
        /// 注入服务
        /// </summary>
        [ResolveProperty]
        public IMenuService MenuService { get; set; }
        //
        // GET: /Admin/Main/

        public ActionResult Index()
        {
            var list = MenuService.GetMany(o => o.ParentKey == null,"IntSort");
            return View(list);
        }

    }
}
