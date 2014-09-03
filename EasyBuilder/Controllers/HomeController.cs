using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyBuilder.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("Index", "Main", new { Area = "Admin" });
        }
    }
}
