using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoIocWeb.Controllers
{
    public class HomeController : Controller
    {
        IVehicule Vehicule;
        public HomeController(IVehicule v)
        {
            Vehicule = v;
        }
        public ActionResult Index()
        {
            var a7 = new Autoroute(Vehicule);
            return View(a7);
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