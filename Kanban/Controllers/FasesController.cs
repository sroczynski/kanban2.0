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
    public class FasesController : Controller
    {
        //
        // GET: /Fases/

        public ActionResult Index()
        {
            return View(FasesModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("FasesManager", new FasesView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(Fases request)
        {
            Result response = FasesModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int FasesId)
        {
            FasesView model = FasesModel.Buscar(FasesId);
            return View("FasesManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Fases request)
        {
            var response = FasesModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int FasesId)
        {
            return Json(FasesModel.Excluir(FasesId), JsonRequestBehavior.AllowGet);
        }

    }
}
