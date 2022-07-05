using Demo4_1.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Demo4_1.Controllers
{
    public class AFaireController : Controller
    {
        public DataPage1 Data = null;

        // Constructor
        public AFaireController()
        {
            Data = new DataPage1();
        }

        // Liste
        public ActionResult Index()
        {
            return View(Data);
        }

        // Détail d'un todo
        public ActionResult Details(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }

        // Create Todo
        public ActionResult Create()
        {
            var todo = new Todo();
            todo.DateExecution = DateTime.Now;
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

        // Edit Todo
        public ActionResult Edit(int id)
        {
            var todo = Data.Todos.Where(t => t.Id == id).FirstOrDefault();
            return View(todo);
        }
        [HttpPost]
        public ActionResult Edit(int id, Todo todoEdit)
        {
            Data.Edit(todoEdit);
            return View(todoEdit);
        }

        // Delete Todo
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
