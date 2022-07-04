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
            Data = new DataPage1
            {
                Titre = "Ma première page ASP.Net MVC 5",
                Todos = new List<Todo>()
            };

            var cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TodoDB;Integrated Security=True";
            cnx.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select Id, Libelle, Fait, DateExecution from Todo";
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Data.Todos.Add(new Todo
                {
                    Id = (int)rd["Id"],
                    Libelle = (string)rd["Libelle"],
                    Fait = (bool)rd["Fait"],
                    DateExecution = (DateTime)rd["DateExecution"]
                });
            }
            //Data = new DataPage1
            //{
            //    Titre = "Ma première page ASP.Net MVC 5",
            //    Todos = new List<Todo> {
            //        new Todo { Id = 1, Libelle = "Aller manger", DateExecution = new DateTime(2022, 7, 4) },
            //        new Todo { Id = 2, Libelle = "Aller dormir", DateExecution = new DateTime(2022, 7, 5) },
            //        new Todo { Id = 3, Libelle = "Aller chanter", DateExecution = new DateTime(2022, 7, 6) }
            //    }
            //};
        }
        // GET: AFaire
        public ActionResult Index()
        {
            return View(Data);
        }

        // GET: AFaire/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AFaire/Create
        public ActionResult Create()
        {
            var todo = new Todo();
            return View(todo);
        }

        // POST: AFaire/Create
        [HttpPost]
        public ActionResult Create(Todo todoCree)
        {
            try
            {
                // TODO: Add insert logic here
                Data.Todos.Add(todoCree);
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

        // POST: AFaire/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AFaire/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AFaire/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
