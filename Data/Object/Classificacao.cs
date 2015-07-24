using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{

    public class Classificacao
    {
        public int idClassificacao { get; set; }

        [Required(ErrorMessage = "É necessario informar uma descrição para a classificação", AllowEmptyStrings = false)]
        [StringLength(20, ErrorMessage = "Limite de 20 caractéres.")]
        public string descricao { get; set; }

        [Required]
        public bool ativo { get; set; }
            
    }

    public class ClassificacaoView : Classificacao
    {
        public bool newRegister { get; set; }
    }

    public class ClassificacaoRequest : Classificacao { }

    public class ClassificacaoIndex
    {
        public List<Classificacao> Classificacao { get; set; }
    }
}