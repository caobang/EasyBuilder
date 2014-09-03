using EasyBuilder.Infrastructure.ObjectContainerAttributes;
using EasyBuilder.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyBuilder.Infrastructure.ActionResults;
using EasyBuilder.Domain.Entities.Admin;

namespace EasyBuilder.Areas.Admin.Controllers
{
    public class RoleController : BaseController
    {
        //
        // GET: /Admin/Role/
        [ResolveProperty]
        public IRoleService RoleService { get; set; }
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 获取角色分页数据
        /// </summary>
        public ActionResult GetPagingRole(int page, int rows, string sort, string order, string search)
        {
            var datas = RoleService.GetPagingData("Name:d", page - 1, rows, sort, order);
            return this.GridData(datas.TotalCount, datas.Data);
        }
    }
}
