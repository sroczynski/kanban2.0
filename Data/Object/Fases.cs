using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Fases
    {
        public int idFase { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para a Fase", AllowEmptyStrings = false)]
        [StringLength(20, ErrorMessage = "Limite de 20 caractéres.")]
        public string descricao { get; set; }

        public bool ativo { get; set; }
    }

    public class FasesView : Fases
    {
        public bool newRegister { get; set; }
    }

    public class FasesRequest : Fases { }

    public class FasesIndex
    {
        public List<Fases> Fases { get; set; }
    }
}
