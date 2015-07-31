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

        [HttpPost]
        public ActionResult Logar(UsuarioLogin request)
        {
            if (!UsuarioModel.AutenticarUsuario(request.Login, request.Senha))
	        {
                ViewBag.msg_Error = "O nome de usuário ou a senha informada estão incorretas.";
                return View("Login", request);
	        }

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Logout()
        {
            UsuarioModel.Deslogar();
            return RedirectToAction("Login", "Usuario");
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
