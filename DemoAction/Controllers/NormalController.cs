﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoAction.Controllers
{
    public class NormalController : Controller
    {
        // GET: Normal
        public ActionResult Index()
        {
            return View();
        }
    }
}