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
    public class GrupoUsuariosController : Controller
    {
        //
        // GET: /GrupoUsuarios/

        public ActionResult Index()
        {
            return View( GrupoUsuariosModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("GrupoUsuariosManager", new GrupoUsuariosView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(GrupoUsuarios request)
        {
            Result response = GrupoUsuariosModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int GrupoUsuariosId)
        {
            GrupoUsuariosView model = GrupoUsuariosModel.Buscar(GrupoUsuariosId);
            return View("GrupoUsuariosManager", model);
        }

        [HttpPost]
        public ActionResult Editar(GrupoUsuarios request)
        {
            var response = GrupoUsuariosModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int GrupoUsuariosId)
        {
            return Json(GrupoUsuariosModel.Excluir(GrupoUsuariosId), JsonRequestBehavior.AllowGet);
        }
    }
}
