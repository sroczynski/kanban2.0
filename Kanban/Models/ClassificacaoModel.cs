using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class ClassificacaoModel
    {
        public static ClassificacaoIndex Index()
        {
            ClassificacaoIndex index = new ClassificacaoIndex()
            {
                Classificacao = new List<Classificacao>()
            };

            using (var db = new KANBANEntities())
            {
                index.Classificacao = db.tipo.Select(x => new Classificacao()
                {
                    idClassificacao = x.id,
                    descricao = x.descricao
                }).ToList();
            }
            return index;
        }

        public static ClassificacaoView Buscar(int index)
        {

            ClassificacaoView response = new ClassificacaoView();

            using (var db = new KANBANEntities())
            {
                response = db.tipo.Select(x => new ClassificacaoView()
                {
                    idClassificacao = x.id,
                    descricao = x.descricao,
                    newRegister = false
                }).FirstOrDefault(x => x.idClassificacao == index);
            }
            return response;
        }

        public static Result Criar(Classificacao request)
        {
            Result response = new Result() { success = true, Message = "Classificação salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.tipo.Add(new Kanban.tipo()
                    {
                        descricao = request.descricao
                    });
                db.SaveChanges();
            }

            return response;
        }

        public static Result Editar(Classificacao request)
        {
            Result response = new Result() { success = true, Message = "Classificacao Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.classificacao edit = db.classificacao.FirstOrDefault(x => x.id == request.idClassificacao);
                    edit.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Classificação, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "Classificação Excluída com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                classificacao excluir = db.classificacao.FirstOrDefault(x => x.id == index);

                if (excluir != null)
                {
                    db.classificacao.Remove(excluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Classificação. Contate o suporte técnico.";
                }
            }

            return response;
        }


        public static List<SelectListItem> GetClassificacaoListItem(int? selected = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();
            using (var db = new KANBANEntities())
            {
                foreach(var item in db.classificacao.ToList())
                {
                    response.Add(
                        new SelectListItem() { 
                            Text = item.descricao, 
                            Value = item.id.ToString(), 
                            Selected = selected.HasValue ? item.id == selected : false 
                        });

                }
            }
            return response;
        }
    }
}

