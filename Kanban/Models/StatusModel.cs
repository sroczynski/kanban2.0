using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class StatusModel
    {
        public static StatusIndex Index()
        {
            StatusIndex index = new StatusIndex() { Status = new List<Status>() };
            using (var db = new KANBANEntities())
            {
                index.Status = db.status.Select(x => new Status()
                {
                    idStatus = x.id,
                    descricao = x.descricao
                }).ToList();
            }
            return index;
        }

        public static Result Criar(Status request)
        {
            Result response = new Result() { success = true, Message = "Status salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.status.Add(new Kanban.status()
                {
                    descricao = request.descricao
                });
                db.SaveChanges();
            }

            return response;
        }

        public static StatusView Buscar(int index)
        {
            StatusView response = new StatusView();

            using (KANBANEntities db = new KANBANEntities())
            {
                response = db.status.Select(x => new StatusView()
                {
                    idStatus = x.id,
                    descricao = x.descricao,
                    newRegister = false
                }).FirstOrDefault(x => x.idStatus == index);
            }

            return response;
        }


        public static Result Editar(Status request)
        {
            Result response = new Result() { success = true, Message = "Status Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.status editStatus = db.status.FirstOrDefault(x => x.id == request.idStatus);
                    editStatus.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Status, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "Status Excluída com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                status excluir = db.status.FirstOrDefault(x => x.id == index);

                if (excluir != null)
                {
                    db.status.Remove(excluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Status. Contate o suporte técnico.";
                }
            }

            return response;
        }

        public static List<SelectListItem> GetStatusListItem(int? selected = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();

            using (var db = new KANBANEntities())
            {
                foreach (var item in db.status.ToList())
                {
                    response.Add(
                    new SelectListItem() { 
                        Text = item.descricao, 
                        Value = item.id.ToString(), 
                        Selected = selected.HasValue ? selected.Value == item.id : false 
                    });
                }


            }

            return response;
        }

    }
}