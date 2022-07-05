using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoEF.Controllers
{
    public class TodoController : Controller
    {
        public DataPage1 Data = new DataPage1();

        public ActionResult Index()
        {
            return View(Data);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View(new Todo());
        }

        // POST: Todo/Create
        [HttpPost]
        public ActionResult Create(Todo todoCree)
        {
            Data.Add(todoCree);
            return RedirectToAction("Index");
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }

        // POST: Todo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Todo todoEdit)
        {
            Data.Edit(todoEdit);
            return View(todoEdit);
        }

        // GET: Todo/Delete/5
        public ActionResult Delete(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }

        // POST: Todo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Todo todoDelete)
        {
            Data.Delete(todoDelete);
            return RedirectToAction("Index");
        }
    }
}
