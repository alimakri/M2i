using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace DemoActionFilters.Controllers
{
    public class HomeController : Controller
    {
        public List<string> Actions = new List<string>();
        #region Filtres

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Actions.Add("OnActionExecuted");
            base.OnActionExecuted(filterContext);
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Actions.Add("OnActionExecuting");
            base.OnActionExecuting(filterContext);
        }
        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Actions.Add("OnResultExecuting");
            base.OnResultExecuting(filterContext);
        }
        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Actions.Add("OnResultExecuted");
            base.OnResultExecuted(filterContext);
        }
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            Actions.Add("OnAuthorization");
            base.OnAuthorization(filterContext);
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            Actions.Add("OnException");
            base.OnException(filterContext);
        }
        #endregion

        public ActionResult Index()
        {
            Actions.Add("Index");
            //throw new Exception("Test");
            return View(Actions);

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