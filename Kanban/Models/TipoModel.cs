using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class TipoModel
    {
		public static TipoIndex Index()
        {
			TipoIndex index = new TipoIndex (){ Tipo = new List<Tipo> () };
            using (var db = new KANBANEntities())
            {
				index.Tipo = db.tipo.Select(x => new Tipo() { 
					idTipo = x.id, 
					descricao = x.descricao
				}).ToList();
            }
            return index;
        }

		public static TipoView Buscar( int index ){
		
			TipoView response = new TipoView ();

			using (var db = new KANBANEntities ()) {
				response = db.tipo.Select (x => new TipoView () {
					idTipo = x.id,
					descricao = x.descricao,
					newRegister = false
				}).FirstOrDefault (x => x.idTipo == index);
			}
            return response;
		}

        public static Result Criar(Tipo request)
        {
            Result response = new Result() { success = true, Message = "Tipo salva com Sucesso" };
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

        public static Result Editar(Tipo request)
        {
            Result response = new Result() { success = true, Message = "Tipo Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.tipo editTipo = db.tipo.FirstOrDefault(x => x.id == request.idTipo);
                    editTipo.descricao = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações da Tipo, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "Tipo Excluída com sucesso." };
            
            using (KANBANEntities db = new KANBANEntities())
            {
                tipo TipoExcluir = db.tipo.FirstOrDefault(x => x.id == index);

                if (TipoExcluir != null)
                {
                    db.tipo.Remove(TipoExcluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Tipo. Contate o suporte técnico.";
                }
            }

            return response;
        }

        public static List<SelectListItem> GetListItem(int? selectedId = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();
            using (var db = new KANBANEntities())
            {
                foreach (var item in db.tipo.ToList())
                {
                    response.Add(
                        new SelectListItem() { 
                            Text = item.descricao, 
                            Value = item.id.ToString(), 
                            Selected = selectedId.HasValue ? item.id == selectedId.Value : false 
                        }
                    );                    
                }
            }
            return response;
        }
    }
}