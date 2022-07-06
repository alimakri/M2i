using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DemoAction.Controllers
{
    public class HomeController : Controller
    {
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
        public string Action1()
        {
            return "Résultat de l'action 1";
        }
        public ActionResult Action2()
        {
            var cr = new ContentResult();
            cr.ContentType = "text";
            cr.Content = "Résultat de l'action 2 (50€)";
            cr.ContentEncoding = Encoding.Default;
            return cr;
        }
        public ActionResult Action3(string id)
        {
            var flux = System.IO.File.ReadAllBytes(@"d:\test.txt");
            Response.AddHeader("Content-Disposition", $"inline; filename=testFinal{id}.txt");
            var cr = new FileContentResult(flux, "application/txt");
            return cr;
        }
    }
}