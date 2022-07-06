using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoUnitTest.Controllers
{
    public class Data
    {
        public string Chaine;
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = new Data { Chaine = "Yes" };
            return View(data);
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