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
        public static Data.Object.Kanban Index(int projetoId, int sprintId)
        {
            Data.Object.Kanban response = new Data.Object.Kanban();
            using (var db = new KANBANEntities())
            {
                int usuarioId = UsuarioModel.GetUsuarioLogado().idUsuario;
                if (projetoId == 0)
                    projetoId = db.projeto_x_usuario.FirstOrDefault(x => x.id_usuario == usuarioId).id_projeto;

                if (sprintId == 0)
                {
                    var sprintProjeto = db.sprints.FirstOrDefault(x => x.idProjeto == projetoId);
                    if (sprintProjeto != null)
	                {
                        sprintId = sprintProjeto.id; 
	                }
                }

                response.Fases = db.fases.Where(x => x.projetoId == projetoId).Select(x => new Fases() { idFase = x.id, descricao = x.descricao }).ToList();
                response.Tarefas = db.tarefas.Where(x => projetoId != 0 && x.id_projeto == projetoId && sprintId != 0 && x.id_sprints == sprintId).Select(x => new TarefaIndex() { id = x.id, titulo = x.Titulo, descricao = x.descricao, dtCriacao = x.dt_criacao, idFase = x.idFase.Value }).ToList();
            }
            return response;
        }
    }
}