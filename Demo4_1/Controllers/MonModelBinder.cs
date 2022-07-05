using Demo4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo4_1.Controllers
{
    public class MonModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            var todo = new Todo();
            todo.Libelle = "$$$" +request.Form["Libelle"];
            var etat = false;
            bool.TryParse(request.Form.GetValues("Fait")[0], out etat);
            todo.Fait = etat;
            todo.DateExecution = DateTime.Now;
            return todo;
        }
    }
}