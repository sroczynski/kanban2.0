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
    public class StatusController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            return View(StatusModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("StatusManager", new StatusView() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Status request)
        {
            Result response = StatusModel.Criar(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int StatusId)
        {
            StatusView model = StatusModel.Buscar(StatusId);
            return View("StatusManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Status request)
        {
            var response = StatusModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int StatusId)
        {
            return Json(StatusModel.Excluir(StatusId),JsonRequestBehavior.AllowGet);
        }
    }
}
