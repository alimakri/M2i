using Demo4_1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo4_1.Controllers
{
    public class AFaireController : Controller
    {
        public DataPage1 Data = null;

        public AFaireController()
        {
            Data = new DataPage1();
        }
        // GET: AFaire
        public ActionResult Index()
        {
            return View(Data);
        }

        public ActionResult Details(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }

        public ActionResult Create()
        {
            var todo = new Todo();
            return View(todo);
        }

        [HttpPost]
        public ActionResult Create(Todo todoCree)
        {
            try
            {
                Data.Add(todoCree);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AFaire/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, Todo todoEdit)
        {
            Data.Edit(todoEdit);
            return View();
        }

        // GET: AFaire/Delete/5
        public ActionResult Delete(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();

            return View(todo);
        }

        [HttpPost]
        public ActionResult Delete(int id, Todo todoDelete)
        {
            try
            {
                Data.Delete(todoDelete);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
