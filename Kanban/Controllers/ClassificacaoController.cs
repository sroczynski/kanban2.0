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
    public class ClassificacaoController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            return View(ClassificacaoModel.Index());
        }

        [HttpGet]
        public ActionResult Criar()
        {
            return View("ClassificacaoManager", new ClassificacaoView() { newRegister = true });
        }

        [HttpPost]
        public ActionResult Criar(Classificacao request)
        {
            Result response = ClassificacaoModel.Criar(request);
            return Json(response);
        }


        [HttpGet]
        public ActionResult Editar(int ClassificacaoId)
        {
            ClassificacaoView model = ClassificacaoModel.Buscar(ClassificacaoId);
            return View("ClassificacaoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(Classificacao request)
        {
            var response = ClassificacaoModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int ClassificacaoId)
        {
            return Json(ClassificacaoModel.Excluir(ClassificacaoId), JsonRequestBehavior.AllowGet);
        }
    }
}
