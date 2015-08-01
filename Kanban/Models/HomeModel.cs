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
        public static Data.Object.Kanban Index(int projetoId)
        {
            Data.Object.Kanban response = new Data.Object.Kanban();
            using (var db = new KANBANEntities())
            {

                if (projetoId == 0)
                {
                    int usuarioId = UsuarioModel.GetUsuarioLogado().idUsuario;
                    projetoId = db.projeto_x_usuario.FirstOrDefault(x => x.id_usuario == usuarioId).id_projeto;
                }

                response.Fases = db.fases.Where(x => x.projetoId == projetoId).Select(x => new Fases() { idFase = x.id, descricao = x.descricao }).ToList();
                response.Tarefas = db.tarefas.Where(x => x.id_projeto == projetoId).Select(x => new TarefaIndex() { id = x.id, titulo = x.Titulo, descricao = x.descricao, dtCriacao = x.dt_criacao, idFase = x.idFase.Value }).ToList();
            }
            return response;
        }
    }
}