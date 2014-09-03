using System.Web.Mvc;

namespace EasyBuilder.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{key}",
                new { controller = "Login", action = "Index", key = UrlParameter.Optional }
            );
        }
    }
}
