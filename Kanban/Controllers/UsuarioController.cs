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
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View(UsuarioModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("UsuarioManager", new UsuarioView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(Usuario request)
        {
            Result response = UsuarioModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int UsuarioId)
        {
            UsuarioView model = UsuarioModel.Buscar(UsuarioId);
            return View("UsuarioManager", model);
        }

        [HttpPost]
        public ActionResult Editar(UsuarioRequest request)
        {
            var response = UsuarioModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int UsuarioId)
        {
            return Json(UsuarioModel.Excluir(UsuarioId), JsonRequestBehavior.AllowGet);
        }
    }
}
