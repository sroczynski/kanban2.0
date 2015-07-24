using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object{
	
	public class Tipo {
		
		public int idTipo{ get; set; }
		
		[StringLength(20, ErrorMessage="Limite de 20 caractéres.")]
		[Required(ErrorMessage="Informe uma descrição para o Tipo",AllowEmptyStrings=false)]
		public string descricao{ get; set; }
		
		[Required]
		public bool inicial{ get; set; }

        [Required]
        public bool final { get; set; }
	}
    
    public class TipoView : Tipo
    {
        public bool newRegister { get; set; }
    }

    public class TipoRequest : Tipo { }

    public class TipoIndex
    {
        public List<Tipo> Tipo { get; set; }
    }
}