using Data.Object;
using Data.Object.Validation;
using Kanban.Models;
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

        public ActionResult Index()
        {
            return View(SprintModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("SprintManager", new SprintView() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Sprint request)
        {
            Result response = SprintModel.Criar(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int sprintId)
        {
            SprintView model = SprintModel.Buscar(sprintId);
            return View("SprintManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Sprint request)
        {
            var response = SprintModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int sprintId)
        {
            return Json(SprintModel.Excluir(sprintId),JsonRequestBehavior.AllowGet);
        }
    }
}
