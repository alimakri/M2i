using Demo4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo4_1.Controllers
{
    public class MonController : Controller
    {
        public MonController()
        {
            Data = new DataPage1
            {
                Titre = "Ma première page ASP.Net MVC 5",
                Todos = new List<Todo> {
                    new Todo { Id = 1, Libelle = "Aller manger", DateExecution = new DateTime(2022, 7, 4) },
                    new Todo { Id = 2, Libelle = "Aller dormir", DateExecution = new DateTime(2022, 7, 5) },
                    new Todo { Id = 3, Libelle = "Aller chanter", DateExecution = new DateTime(2022, 7, 6) }
                }
            };
        }
        public DataPage1 Data = null;
        public ActionResult Page1()
        {
            ViewBag.Nom = "Ali MAKRI";
            //ViewData["Nom"] = "Ali MAKRI"; // Obsolete
            return View(Data);
        }
        public ActionResult Page2(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();

            //Todo todo = null;
            //foreach(var t in Data.Todos)
            //{
            //    if (t.Id == id)
            //    {
            //        todo = t;
            //        break;
            //    }
            //}

            return View(todo);
        }
    }
}