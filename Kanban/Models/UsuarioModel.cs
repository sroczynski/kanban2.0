using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kanban.Models
{
	public class UsuarioModel
	{
		public static UsuarioIndex Index()
		{
			UsuarioIndex index = new  UsuarioIndex(){ 
				Usuario = new List<Usuario> () };

			using (var db = new KANBANEntities())
			{
				index.Usuario = db.usuario.Select(x => new Usuario() { 
					idUsuario = x.id, 
					login = x.login,
					nomeUsuario = x.nome_usuario,
					senha = x.senha
				}).ToList();
			}
			return index;
		}

		public static UsuarioView Buscar( int index ){

			UsuarioView response = new UsuarioView();

			using (var db = new KANBANEntities ()) {
				response = db.usuario.Select (x => new UsuarioView() {
					idUsuario = x.id, 
					login = x.login,
					nomeUsuario = x.nome_usuario,
					senha = x.senha,
					newRegister = false
				}).FirstOrDefault (x => x.idUsuario == index);
			}
            return response;
		}

		public static Result Criar(Usuario request)
		{
			Result response = new Result() { success = true, Message = "Usuário salvo com Sucesso" };
			using (KANBANEntities db = new KANBANEntities())
			{
				db.usuario.Add(new Kanban.usuario()
					{
						login = request.login,
						nome_usuario = request.nomeUsuario,
						senha = request.senha,

					});
				db.SaveChanges();
			}

			return response;
		}

		public static Result Editar(Usuario request)
		{
			Result response = new Result() { success = true, Message = "Usuario Salvo com Sucesso!" };

			try
			{
				using (KANBANEntities db = new KANBANEntities())
				{
					Kanban.usuario edit = db.usuario.FirstOrDefault(x => x.id == request.idUsuario);
					edit.nome_usuario = request.nomeUsuario;
					db.SaveChanges();
				}
			}
			catch (Exception)
			{
				response.Message = "Houve erro ao atualizar as informações do Usuario, contate o suporte técnico.";
				response.success = false;
			}

			return response;
		}

		public static Result Excluir(int index)
		{
			Result response = new Result() { success = true, Message = "Usuario Excluído com sucesso." };

			using (KANBANEntities db = new KANBANEntities())
			{
				usuario excluir = db.usuario.FirstOrDefault(x => x.id == index);

				if (excluir != null)
				{
					db.usuario.Remove(excluir);
					db.SaveChanges();
				}
				else
				{
					response.success = false;
					response.Message = "Houve Erro Exclusão do Usuário. Contate o suporte técnico.";
				}
			}

			return response;
		}


        public static List<SelectListItem> GetListItem(int? selectedId = null, int? projetoId = null)
        {
            List<SelectListItem> response = new List<SelectListItem>();
            using (var db = new KANBANEntities())
            {
                foreach (var item in db.usuario.ToList())
                {
                    response.Add(
                        new SelectListItem() { 
                            Text = item.nome_usuario, 
                            Value = item.id.ToString(), 
                            Selected = selectedId.HasValue ? selectedId.Value == item.id : false 
                    });
                    
                }
            }
            return response;
        }
	}
}

