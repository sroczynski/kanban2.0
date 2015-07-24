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
    public class UsuarioGrupoController : Controller
    {
        public ActionResult Index()
        {
            return View(UsuarioGrupoModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("UsuarioGrupoManager", new UsuarioGrupoView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(UsuarioGrupo request)
        {
            Result response = UsuarioGrupoModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int UsuarioGrupoId)
        {
            UsuarioGrupoView model = UsuarioGrupoModel.Buscar(UsuarioGrupoId);
            return View("UsuarioGrupoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(UsuarioGrupoRequest request)
        {
            var response = UsuarioGrupoModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int UsuarioGrupoId)
        {
            return Json(UsuarioGrupoModel.Excluir(UsuarioGrupoId), JsonRequestBehavior.AllowGet);
        }

    }
}
