using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoJs.Controllers
{
    public class HomeController : Controller
    {
        private Random Alea = new Random();
        public string Couleur()
        {
            var couleur = new string[] { "Noir", "Black" };
            switch (Alea.Next(1, 4))
            {
                case 1: couleur = new string[] { "Rouge", "Red" }; break;
                case 2: couleur = new string[] { "Vert", "Green" }; break;
                case 3: couleur = new string[] { "Bleu", "Blue" }; break;
            }
            return JsonConvert.SerializeObject(couleur);
        }
        public ActionResult Index()
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