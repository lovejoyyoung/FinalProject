using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
        // GET: Home
        public class HomeController : Controller
        {
            public ActionResult AdminIndex()
            {
                return View();
            }

            public ActionResult ManagerIndex()
            {
                return View();
            }

            public ActionResult TenantIndex()
            {
                return View();
            }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    
}