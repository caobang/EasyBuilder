using EasyBuilder.Core.ObjectContainers;
using EasyBuilder.Infrastructure.Exceptions;
using EasyBuilder.Infrastructure.ObjectContainerAttributes;
using EasyBuilder.Services.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EasyBuilder.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// 获取session
        /// </summary>
        protected object GetSession(string name)
        {
            return Session[name];
        }
        /// <summary>
        /// 设置session
        /// </summary>
        protected void SetSession(string name, object value)
        {
            Session[name] = value;
        }
        /// <summary>
        /// 获取或保存当前用户Key
        /// </summary>
        protected Guid CurrentManagerKey
        {
            get
            {
                object key = this.GetSession("ManagerKey");
                if (key == null)
                    return Guid.Empty;
                return Guid.Parse(key.ToString());
            }
            set
            {
                this.SetSession("ManagerKey", value);
            }
        }

        /// <summary>
        /// 注入用户服务
        /// </summary>
        [ResolveProperty]
        public IManagerService ManagerService { get; set; }
        ///<summary>
        /// action开始时 验证用户是否登录
        /// </summary>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //测试环境不验证

            //if (CurrentManagerKey == Guid.Empty)
            //    throw new Exception("当前登录用户为空");
        }

        /// <summary>
        /// 初始化Services
        /// </summary>
        protected override void Initialize(RequestContext requestContext)
        {
            var properties = this.GetType().GetProperties().Where(o => o.GetCustomAttributes(typeof(ResolvePropertyAttribute), true).Length != 0);
            foreach (PropertyInfo property in properties)
            {
                object service = ObjectContainer.Current.Resolve(property.PropertyType);
                property.SetValue(this, service);
            }
            base.Initialize(requestContext);
        }
    }
}
