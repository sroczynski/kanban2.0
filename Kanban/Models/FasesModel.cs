using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kanban.Models
{
	public class FasesModel
	{
		public static FasesIndex Index()
		{
			FasesIndex index = new  FasesIndex(){ 
				Fases = new List<Fases> () };

			using (var db = new KANBANEntities())
			{
				index.Fases = db.tipo.Select(x => new Fases() { 
					idFase = x.id, 
					descricao = x.descricao
				}).ToList();
			}
			return index;
		}

		public static FasesView Buscar( int index ){

			FasesView response = new FasesView();

			using (var db = new KANBANEntities ()) {
				response = db.fases.Select (x => new FasesView() {
					idFase = x.id,
					descricao = x.descricao,
					newRegister = false
				}).FirstOrDefault (x => x.idFase == index);
			}
            return response;
		}

		public static Result Criar(Fases request)
		{
			Result response = new Result() { success = true, Message = "Fase salva com Sucesso" };
			using (KANBANEntities db = new KANBANEntities())
			{
				db.fases.Add(new Kanban.fases()
					{
						descricao = request.descricao
					});
				db.SaveChanges();
			}

			return response;
		}

		public static Result Editar(Fases request)
		{
			Result response = new Result() { success = true, Message = "Fase Salvo com Sucesso!" };

			try
			{
				using (KANBANEntities db = new KANBANEntities())
				{
					Kanban.fases edit = db.fases.FirstOrDefault(x => x.id == request.idFase);
					edit.descricao = request.descricao;
					db.SaveChanges();
				}
			}
			catch (Exception)
			{
				response.Message = "Houve erro ao atualizar as informações do Fase, contate o suporte técnico.";
				response.success = false;
			}

			return response;
		}

		public static Result Excluir(int index)
		{
			Result response = new Result() { success = true, Message = "Fase Excluída com sucesso." };

			using (KANBANEntities db = new KANBANEntities())
			{
				fases excluir = db.fases.FirstOrDefault(x => x.id == index);

				if (excluir != null)
				{
					db.fases.Remove(excluir);
					db.SaveChanges();
				}
				else
				{
					response.success = false;
					response.Message = "Houve Erro Exclusão da Fase. Contate o suporte técnico.";
				}
			}

			return response;
		}

        public static List<SelectListItem> GetListItem(int? selectedId = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();
            using (var db = new KANBANEntities())
            {
                foreach (var item in db.fases.ToList())
                {
                    response.Add(
                        new SelectListItem()
                        {
                            Text = item.descricao,
                            Value = item.id.ToString(),
                            Selected = selectedId.HasValue ? item.id == selectedId : false
                        }
                    );
                }

            }
            return response;
        }
	}
}

