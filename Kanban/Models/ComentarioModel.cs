using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kanban.Models
{
	public class ComentarioModel
	{
		public static ComentarioIndex Index()
		{
			ComentarioIndex index = new  ComentarioIndex(){ 
				Comentarios = new List<Comentario> () };

			using (var db = new KANBANEntities())
			{
				index.Comentarios = db.tarefa_x_comentario.Select(x => new Comentario() { 
					idComentario = x.id, 
					descricao = x.descricao
				}).ToList();
			}
			return index;
		}

		public static ComentarioView Buscar( int index ){

			ComentarioView response = new ComentarioView ();

			using (var db = new KANBANEntities ()) {
				response = db.tarefa_x_comentario.Select (x => new ComentarioView () {
					idComentario = x.id,
					descricao = x.descricao,
					newRegister = false
				}).FirstOrDefault (x => x.idComentario == index);
			}
            return response;
		}

		public static Result Criar(Comentario request)
		{
			Result response = new Result() { success = true, Message = "Comentario salvo com Sucesso" };
			using (KANBANEntities db = new KANBANEntities())
			{
				db.tarefa_x_comentario.Add(new Kanban.tarefa_x_comentario()
					{
						descricao = request.descricao
					});
				db.SaveChanges();
			}

			return response;
		}

		public static Result Editar(Comentario request)
		{
			Result response = new Result() { success = true, Message = "Comentario Salvo com Sucesso!" };

			try
			{
				using (KANBANEntities db = new KANBANEntities())
				{
					Kanban.tarefa_x_comentario edit = db.tarefa_x_comentario.FirstOrDefault(x => x.id == request.idComentario);
					edit.descricao = request.descricao;
					db.SaveChanges();
				}
			}
			catch (Exception)
			{
				response.Message = "Houve erro ao atualizar as informações do Comentário, contate o suporte técnico.";
				response.success = false;
			}

			return response;
		}

		public static Result Excluir(int index)
		{
			Result response = new Result() { success = true, Message = "Comentário Excluído com sucesso." };

			using (KANBANEntities db = new KANBANEntities())
			{
				tarefa_x_comentario excluir = db.tarefa_x_comentario.FirstOrDefault(x => x.id == index);

				if (excluir != null)
				{
					db.tarefa_x_comentario.Remove(excluir);
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
	}
}

