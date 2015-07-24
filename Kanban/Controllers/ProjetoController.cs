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
    public class ProjetoController : Controller
    {
        //
        // GET: /Projeto/

        public ActionResult Index()
        {
            return View(ProjetoModel.Index());
        }
        
        [HttpGet]
        public ActionResult Criar()
        {
            return View("ProjetoManager", new ProjetoView() { newRegister = true});
        }

        [HttpPost]
        public ActionResult Criar(Projeto request)
        {
            Result response = ProjetoModel.Criar(request);
            return Json(response);
        }

        
        [HttpGet]
        public ActionResult Editar(int projetoId)
        {
            ProjetoView model = ProjetoModel.Buscar(projetoId);
            return View("ProjetoManager", model);
        }

        [HttpPost]
        public ActionResult Editar(ProjetoRequest request)
        {
            var response = ProjetoModel.Editar(request);
            return Json(response);
        }

        public ActionResult Excluir(int projetoId)
        {
            return Json(ProjetoModel.Excluir(projetoId),JsonRequestBehavior.AllowGet);
        }
    }
}
