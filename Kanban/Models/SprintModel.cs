using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class SprintModel
    {
        public static SprintIndex Index()
        {
            SprintIndex index = new SprintIndex() { Sprint = new List<Sprint>() };
            using (var db = new KANBANEntities())
            {
                index.Sprint = db.sprints.Select(x => new Sprint()
                {
                    idSprint = x.id,
                    descricao = x.descricao
                }).ToList();
            }
            return index;
        }

        public static Result Criar(Sprint request)
        {
            Result response = new Result() { success = true, Message = "Sprint salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.sprints.Add(new Kanban.sprints()
                {
                    descricao = request.descricao,
                });
                db.SaveChanges();
            }

            return response;
        }

        public static SprintView Buscar(int index)
        {

            SprintView view = new SprintView();
            using (KANBANEntities db = new KANBANEntities())
            {

                view = db.sprints.Select(x => new SprintView()
                {

                    idSprint = x.id,
                    descricao = x.descricao,
                    newRegister = false
                }).FirstOrDefault(x => x.idSprint == index);
            }
            return view;
        }


        public static Result Editar(Sprint request)
        {
            Result response = new Result() { success = true, Message = "Sprint Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.sprints editSprint = db.sprints.FirstOrDefault(x => x.id == request.idSprint);
                    editSprint.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da sprint, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "Sprint Excluída com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                sprints excluir = db.sprints.FirstOrDefault(x => x.id == index);

                if (excluir != null)
                {
                    db.sprints.Remove(excluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da sprint. Contate o suporte técnico.";
                }
            }

            return response;
        }



        /*
         *
         * Compartilhados.
         */


        public static List<SelectListItem> GetSprints(int? projetoId = null, int? select = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();

            using (var db = new KANBANEntities())
            {

                foreach (var item in db.sprints.ToList())
                {
                    response.Add(new SelectListItem()
                    {
                        Text = item.descricao,
                        Value = item.id.ToString(),
                        Selected = select.HasValue ? item.id == select.Value : false
                    }
                    );
                }
            }

            return response;
        }
    }
}