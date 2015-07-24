using Data.Object;
using Data.Object.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class PermissaoModel
    {

        public static PermissaoIndex Index()
        {
            PermissaoIndex index = new PermissaoIndex()
            {
                Permissao = new List<Permissao>()
            };

            using (var db = new KANBANEntities())
            {
                index.Permissao = db.permissao.Select(x => new Permissao()
                {
                    idPermissao = x.id,
                    descricao = x.titulo
                }).ToList();
            }
            return index;
        }

        public static PermissaoView Buscar(int index)
        {

            PermissaoView response = new PermissaoView();

            using (var db = new KANBANEntities())
            {
                response = db.permissao.Select(x => new PermissaoView()
                {
                    idPermissao = x.id,
                    descricao = x.titulo,
                    newRegister = false
                }).FirstOrDefault(x => x.idPermissao == index);
            }
            return response;
        }

        public static Result Criar(Permissao request)
        {
            Result response = new Result() { success = true, Message = "Permissao salva com Sucesso" };
            using (KANBANEntities db = new KANBANEntities())
            {
                db.permissao.Add(new Kanban.permissao()
                {
                    titulo = request.descricao
                });
                db.SaveChanges();
            }

            return response;
        }

        public static Result Editar(Permissao request)
        {
            Result response = new Result() { success = true, Message = "Permissao Salva com Sucesso!" };

            try
            {
                using (KANBANEntities db = new KANBANEntities())
                {
                    Kanban.permissao edit = db.permissao.FirstOrDefault(x => x.id == request.idPermissao);
                    edit.titulo = request.descricao;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                response.Message = "Houve erro ao atualizar as informações do Permissao, contate o suporte técnico.";
                response.success = false;
            }

            return response;
        }

        public static Result Excluir(int index)
        {
            Result response = new Result() { success = true, Message = "Permissao Excluída com sucesso." };

            using (KANBANEntities db = new KANBANEntities())
            {
                permissao excluir = db.permissao.FirstOrDefault(x => x.id == index);

                if (excluir != null)
                {
                    db.permissao.Remove(excluir);
                    db.SaveChanges();
                }
                else
                {
                    response.success = false;
                    response.Message = "Houve Erro Exclusão da Permissao. Contate o suporte técnico.";
                }
            }

            return response;
        }
    }
}