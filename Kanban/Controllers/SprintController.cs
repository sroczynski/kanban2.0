using Data.Object;
using Data.Object.Validation;
using Kanban.Models;
using Kanban.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Controllers
{
    public class SprintController : Controller
    {
        //
        // GET: /Projeto/

        [AuthorizeExtension]
        public ActionResult Index()
        {
            return View(SprintModel.Index());
        }


        [AuthorizeExtension]
        [HttpGet]
        public ActionResult Criar()
        {
            return View("SprintManager", new SprintView() { newRegister = true});
        }


        [AuthorizeExtension]
        [HttpPost]
        public ActionResult Criar(Sprint request)
        {
            Result response = SprintModel.Criar(request);
            return Json(response);
        }

        [AuthorizeExtension]
        [HttpGet]
        public ActionResult Editar(int sprintId)
        {
            SprintView model = SprintModel.Buscar(sprintId);
            return View("SprintManager", model);
        }

        [AuthorizeExtension]
        [HttpPost]
        public ActionResult Editar(Sprint request)
        {
            var response = SprintModel.Editar(request);
            return Json(response);
        }

        [AuthorizeExtension]
        public ActionResult Excluir(int sprintId)
        {
            return Json(SprintModel.Excluir(sprintId),JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetSprints(string projetoId)
        {
            int projeto = Convert.ToInt32(projetoId);
            var sprints = SprintModel.GetSprints(projeto);
            return Json(sprints);
        }
    }
}
