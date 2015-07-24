using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Permissao {

		public int idPermissao{ get; set; }
		
		[Required(ErrorMessage="Informe uma descrição para a Permissão",AllowEmptyStrings=false)]
		[StringLength(20, ErrorMessage="Limite de 20 caractéres.")]
		public string descricao{ get; set; }
	}

    public class PermissaoView : Permissao
    {
        public bool newRegister { get; set; }
    }

    public class PermissaoRequest : Permissao { }

    public class PermissaoIndex
    {
        public List<Permissao> Permissao { get; set; }
    }
}