using Kanban.Models;
using Kanban.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeExtension]
        public ActionResult Index(string projetoId = null)
        {
            int idProjeto = !string.IsNullOrEmpty(projetoId) ? Convert.ToInt32(projetoId) : 0;
            return View(HomeModel.Index(idProjeto));
        }
    }
}
