using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private static ILog _log = LogManager.GetLogger("homeController");

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            _log.Info("test");

            return View();
        }
    }
}
