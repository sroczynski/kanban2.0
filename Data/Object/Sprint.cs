using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Sprint
    {

        public int idSprint { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para o Sprint", AllowEmptyStrings = false)]
        [StringLength(50, ErrorMessage = "Limite de 50 caractéres.")]
        public string descricao { get; set; }

        public Sprint idSprintDependencia;

        [DataType(DataType.DateTime)]
        public DateTime dtInicio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime dtFim { get; set; }

        public int projetoId { get; set; }

        public List<Tarefa> tarefa { get; set; }
    }

    public class SprintView : Sprint
    {
        public bool newRegister { get; set; }
    }

    public class SprintRequest : Sprint { }

    public class SprintIndex : Sprint { }
}