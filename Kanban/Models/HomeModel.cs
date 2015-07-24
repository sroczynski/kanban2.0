using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class HomeModel
    {
        public static ProjetoIndex Index()
        {
            ProjetoIndex response = new ProjetoIndex();
            using (var db = new KANBANEntities())
            {
                response.Fases = db.fases.Select(x => new Fases() { idFase = x.id, descricao = x.descricao }).ToList();

                response.Projetos = db.projeto.Select(x => new Projeto() { id = x.id, titulo = x.titulo, descricao = x.descricao }).ToList();
            }

            return response;
        }
    }
}