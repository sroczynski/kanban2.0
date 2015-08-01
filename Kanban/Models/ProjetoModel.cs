using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class ProjetoModel
    {
        public static ProjetoIndex Index()
        {
            ProjetoIndex index = new ProjetoIndex() { Projetos = new List<Projeto>() };
            using (KANBANEntities db = new KANBANEntities())
            {
                index.Projetos = db.projeto.Select(x => new Projeto()
                {
                    id = x.id,
                    titulo = x.titulo,
                    descricao = x.descricao
                }).ToList();
            }
            return index;
        }

        public static Result Criar(Projeto request)
        {
            Result response = new Result() { success = true, Message = "Projeto Salvo com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.projeto.Add(new Kanban.projeto()
                {
                    descricao = request.descricao,
                    titulo = request.titulo
                });
                db.SaveChanges();
            }

            return response;
        }

        public static ProjetoView Buscar(int projetoId)
        {
            ProjetoView response = new ProjetoView();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.projeto.Select(x => new ProjetoView()
                {
                    id = x.id,
                    titulo = x.titulo,
                    descricao = x.descricao,
                    newRegister = false
                }).FirstOrDefault(x => x.id == projetoId);
            }

            return response;
        }

        public static Result Editar(ProjetoRequest request)
        {
            Result response = new Result() { success = true, Message = "Projeto Salvo com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.projeto editProject = db.projeto.FirstOrDefault(x => x.id == request.id);
                    editProject.titulo = request.titulo;
                    editProject.descricao = request.descricao;

                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações do projeto, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }


        public static Result Excluir(int projetoId)
        {
            Result response = new Result() { success = true, Message = "Projeto Excluído com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                projeto projetoExcluir = db.projeto.FirstOrDefault(x => x.id == projetoId);

                if (projetoExcluir != null)
                {
                    db.projeto.Remove(projetoExcluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão do projeto. Contate o suporte técnico.";
                }
            }

            return response;
        }

        public static List<SelectListItem> GetProjetoListItem(int? selectedId = null)
        {
            int usuarioId = UsuarioModel.GetUsuarioLogado().idUsuario;
            List<SelectListItem> response = new List<SelectListItem>();
            using (var db = new KANBANEntities())
            {
                var projetosUsuario = db.projeto_x_usuario.Where(x=> x.id_usuario==usuarioId).Select(x =>x.projeto).ToList();

                foreach (var item in projetosUsuario)
                {
                    response.Add(new SelectListItem(){
                        Text = item.titulo,
                        Value = item.id.ToString(),
                        Selected = selectedId.HasValue ? item.id == selectedId : false 
                    });
                }
            }
            return response;
        }
    }
}