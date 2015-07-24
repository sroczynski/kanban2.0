using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class TarefaModel
    {
        public static List<TarefaIndex> Index()
        {
            List<TarefaIndex> response = new List<TarefaIndex>();
            using (var db = new KANBANEntities())
            {
                response = db.tarefas.Select(x => new TarefaIndex()
                {
                    id = x.id,
                    projeto = x.projeto.titulo,
                    dtCriacao = x.dt_criacao,
                    titulo = x.descricao
                }).ToList();
            }
            return response;
        }

        /// <summary>
        /// Retorno os dados dos objetos de tela da Tarefa
        /// </summary>
        /// <returns></returns>
        public static TarefaView CriarView()
        {
            TarefaView response = new TarefaView();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = new TarefaView()
                {
                    newRegister = true,
                    Projeto = ProjetoModel.GetProjetoListItem(),
                    Status = StatusModel.GetStatusListItem(1),
                    Sprint = SprintModel.GetSprints(),
                    Classificacao = ClassificacaoModel.GetClassificacaoListItem(),
                    Usuarios = UsuarioModel.GetListItem(),
                    Tipo = TipoModel.GetListItem(),
                    Tarefas = TarefaModel.GetListItem()
                };
            }
            return response;
        }

        public static TarefaView EditarView()
        {
            TarefaView response = new TarefaView();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = new TarefaView()
                {
                    newRegister = true,
                    Projeto = ProjetoModel.GetProjetoListItem(),
                    Status = StatusModel.GetStatusListItem(1),
                    Sprint = SprintModel.GetSprints(),
                    Classificacao = ClassificacaoModel.GetClassificacaoListItem(),
                    Usuarios = UsuarioModel.GetListItem(),
                    Tipo = TipoModel.GetListItem(),
                    Tarefas = TarefaModel.GetListItem()
                };
            }
            return response;
        }

        public static List<SelectListItem> GetListItem(int? select = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();

            using (var db = new KANBANEntities())
            {
                foreach (var item in db.tarefas.ToList())
                {
                    response.Add(new SelectListItem()
                    {
                        Text = item.descricao,
                        Value = item.id.ToString(),
                        Selected = select.HasValue ? item.id == select.Value : false
                    });
                }
            }

            return response;
        }

        public static Result Criar(Tarefa request)
        {
            Result response = new Result() { success = true, Message = "Tarefa Salva com Sucesso." };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.tarefas.Add(new Kanban.tarefas()
                {
                    descricao = request.descricao,
                    dt_criacao = DateTime.Now,
                    id_projeto = request.idProjeto,
                    id_sprints = request.idSprint,
                    id_status = request.idStatus,
                    id_classificacao = request.idClassificacao,
                    id_tipo = request.idTipo,
                    id_tarefa_agrupador = request.idTarefaAgrupador
                });
                db.SaveChanges();
            }
            return response;
        }

        public static TarefaView EditarView(int tarefaId)
        {
            TarefaView response = new TarefaView();
            using (KANBANEntities db = new KANBANEntities())
            {
                var tarefa = db.tarefas.FirstOrDefault(x => x.id == tarefaId);
                response.newRegister = false;
                response.TarefaId = tarefa.id;
                response.Descricao = tarefa.descricao;
                response.indice = tarefa.indice;
                response.DataCriacao = tarefa.dt_criacao;
                response.TempoEstimado = tarefa.tempo_trabalhado.HasValue ? tarefa.tempo_estimado.Value : new TimeSpan();
                response.TempoTrabalhado = tarefa.tempo_trabalhado.HasValue ? tarefa.tempo_trabalhado.Value : new TimeSpan();
                response.Projeto = ProjetoModel.GetProjetoListItem(tarefa.id_projeto);
                response.Sprint = SprintModel.GetSprints(tarefa.id_projeto, tarefa.id_sprints);
                response.Status = StatusModel.GetStatusListItem(tarefa.id_status);
                response.Classificacao = ClassificacaoModel.GetClassificacaoListItem(tarefa.id_classificacao);
                response.Tipo = TipoModel.GetListItem(tarefa.id_tipo);
                response.Fases = FasesModel.GetListItem(1);
            }
            return response;
        }

        public static Result Editar(Tarefa request)
        {
            Result response = new Result() { success = true, Message = "Tarefa Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.tarefas tarefaEdit = db.tarefas.FirstOrDefault(x => x.id == request.id);
                    tarefaEdit.id_projeto = request.idProjeto;
                    tarefaEdit.descricao = request.descricao;
                    tarefaEdit.id_status = request.status.idStatus;
                    tarefaEdit.id_tipo = request.tipo.idTipo;

                    tarefaEdit.descricao = request.descricao;
                    tarefaEdit.indice = request.indice;
                    tarefaEdit.tempo_estimado = request.tempoEstimado;
                    tarefaEdit.id_projeto = request.idProjeto;
                    tarefaEdit.id_sprints = request.idSprint;
                    tarefaEdit.id_tarefa_dependencia = request.idTarefaDependencia;
                    tarefaEdit.id_classificacao = request.idClassificacao;
                    
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Tarefa, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }


    }
}