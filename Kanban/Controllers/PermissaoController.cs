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
    public class PermissaoController : Controller
    {
        public ActionResult Index()
        {
            return View(PermissaoModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("PermissaoManager", new PermissaoView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(Permissao request)
        {
            Result response = PermissaoModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int PermissaoId)
        {
            PermissaoView model = PermissaoModel.Buscar(PermissaoId);
            return View("PermissaoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(PermissaoRequest request)
        {
            var response = PermissaoModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int PermissaoId)
        {
            return Json(PermissaoModel.Excluir(PermissaoId), JsonRequestBehavior.AllowGet);
        }
    }
}
