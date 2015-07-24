using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Kanban.Models
{
    public class GrupoUsuariosModel
    {
        public static GrupoUsuariosIndex Index()
        {
            GrupoUsuariosIndex index = new GrupoUsuariosIndex()
            {
                GrupoUsuarios = new List<GrupoUsuarios>()
            };

            using (var db = new KANBANEntities())
            {
                index.GrupoUsuarios = db.grupo_usuarios.Select(x => new GrupoUsuarios()
                {
                    id = x.id,
                    idUsuarioLider = x.id_usuario_lider
                }).ToList();
            }
            return index;
        }

        public static GrupoUsuariosView Buscar(int index)
        {

            GrupoUsuariosView response = new GrupoUsuariosView();

            using (var db = new KANBANEntities())
            {
                response = db.grupo_usuarios.Select(x => new GrupoUsuariosView()
                {                    
                    id = x.id,
                    idUsuarioLider = x.id_usuario_lider,
                    newRegister = false
                }).FirstOrDefault(x => x.id == index);
            }
            return response;
        }

        public static Result Criar(GrupoUsuarios request)
        {
            Result response = new Result() { success = true, Message = "Usuário salvo com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.grupo_usuarios.Add(new Kanban.grupo_usuarios()
                {
                    id = request.id,
                    id_usuario_lider = request.idUsuarioLider

                });
                db.SaveChanges();
            }

            return response;
        }

        public static Result Editar(GrupoUsuarios request)
        {
            Result response = new Result() { success = true, Message = "GrupoUsuarios Salvo com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.grupo_usuarios edit = db.grupo_usuarios.FirstOrDefault(x => x.id == request.id);
                    edit.id = request.id;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações do GrupoUsuarios, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "GrupoUsuarios Excluído com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                grupo_usuarios excluir = db.grupo_usuarios.FirstOrDefault(x => x.id == index);

                if (excluir != null)
                {
                    db.grupo_usuarios.Remove(excluir);
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
                response = db.grupo_usuarios
                    .Select(x => new SelectListItem() { Text = x.id.ToString(), Value = x.id.ToString(), Selected = selectedId.HasValue ? selectedId.Value == x.id : false }).ToList();
            }
            return response;
        }

    }
}