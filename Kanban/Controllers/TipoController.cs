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
    public class TipoController : Controller
    {
        //
        // GET: /Tipo/
        public ActionResult Index()
        {
            return View(TipoModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("TipoManager", new TipoView() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Tipo request)
        {
            Result response = TipoModel.Criar(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int TipoId)
        {
            TipoView model = TipoModel.Buscar(TipoId);
            return View("TipoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Tipo request)
        {
            var response = TipoModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int TipoId)
        {
            return Json(TipoModel.Excluir(TipoId),JsonRequestBehavior.AllowGet);
        }
    }
}
