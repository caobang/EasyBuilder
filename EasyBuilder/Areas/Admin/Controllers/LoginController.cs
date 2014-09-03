using EasyBuilder.Core.Cryptographies;
using EasyBuilder.Infrastructure.VerifyCode;
using EasyBuilder.Infrastructure.VerifyCode.ImageVerifyCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyBuilder.Infrastructure.ActionResults;

namespace EasyBuilder.Areas.Admin.Controllers
{
    public class LoginController : BaseController
    {
        //
        // GET: /Admin/Login/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Admin登录验证
        /// </summary>
        public ActionResult Login(string username, string password, string verifycode)
        {
            DataResult data = null;
            if (!this.GetSession("Admin_VerifyCode").ToString().Equals(verifycode, StringComparison.CurrentCultureIgnoreCase))
            {
                data = this.MessageData(false, "验证码错误，请重新输入。");
                data.ContentType = "text/plain";
                return data;
            }
            string pwd = Cryptography.MD5.CreateHash(password);
            var manager = ManagerService.Login(username, pwd);
            if (manager == null)
            {
                data = this.MessageData(false, "用户名或密码错误，请重新输入。"); 
                data.ContentType = "text/plain";
                return data;
            }
            this.CurrentManagerKey = manager.Key;
            data = this.MessageData(true, "登录成功");
            data.ContentType = "text/plain";
            return data;
        }

        /// <summary>
        /// 获取随机验证码
        /// </summary>
        public void GetVerifyCode(VerifyCodeType type = VerifyCodeType.HttpResponse)
        {
            string verifyCode = string.Empty;
            switch (type)
            {
                case VerifyCodeType.HttpResponse:
                default:
                    {
                        ImageVerifyCodeParameter parameter = new ImageVerifyCodeParameter();
                        parameter.ImageWidth = 85;
                        parameter.ImageHeight = 26;
                        parameter.TextLength = 1;
                        ImageVerifyCodeProvider provider = new ImageVerifyCodeProvider(parameter);
                        verifyCode = provider.CreateVerifyCode();
                        break;
                    }
            }
            this.SetSession("Admin_VerifyCode", verifyCode);
        }
        /// <summary>
        ///  重写权限验证 登录页不验证权限
        /// </summary>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }
}
