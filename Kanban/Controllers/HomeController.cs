﻿using Kanban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(HomeModel.Index());
        }
    }
}
