using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoVuePartiel.Controllers
{
    public class Data
    {
        public string Chaine;
    }
    public class HomeController : Controller
    {
        public PartialViewResult Partie()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Page1()
        {
            var data = new Data { Chaine = "Hello" };
            return View(data);
        }
        public ActionResult Page2()
        {
            var data = new Data { Chaine = "Ola" };
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