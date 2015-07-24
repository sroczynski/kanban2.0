using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Object
{
    public class UsuarioGrupo {

		public int idUsuarioGrupo{ get; set; }
		
		[StringLength(20, ErrorMessage="Limite de 20 caractéres.")]
        [Required(ErrorMessage="Informe uma descrição para o Grupo",AllowEmptyStrings=false)]
		public string descricao{ get; set; }
		
		[Required(ErrorMessage="Informe um usuário Líder ",AllowEmptyStrings=false)]
		public Usuario usuarioLider { get; set; }
		
		public bool ativo{ get; set; }
		
		public List<Fases> listFase;
		
		public List<Permissao> listPermissao;
		
		public List<Usuario> listUsuario;
		
	}


    public class UsuarioGrupoView : UsuarioGrupo
    {
        public bool newRegister { get; set; }
    }

    public class UsuarioGrupoRequest : UsuarioGrupo { }

    public class UsuarioGrupoIndex
    {
        public List<UsuarioGrupo> UsuarioGrupo { get; set; }
    }
}