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
    public class ComentarioController : Controller
    {
        //
        // GET: /Comentario/

        public ActionResult Index()
        {
            return View(ComentarioModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("ComentarioManager", new ComentarioView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(Comentario request)
        {
            Result response = ComentarioModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int ComentarioId)
        {
            ComentarioView model = ComentarioModel.Buscar(ComentarioId);
            return View("ComentarioManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Comentario request)
        {
            var response = ComentarioModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int ComentarioId)
        {
            return Json(ComentarioModel.Excluir(ComentarioId), JsonRequestBehavior.AllowGet);
        }

    }
}
