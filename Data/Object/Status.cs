using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class Status
    {

        public int idStatus { get; set; }

        [Required(ErrorMessage = "Informe uma descrição para o Status", AllowEmptyStrings = false)]
        [StringLength(20, ErrorMessage = "Limite de 20 caractéres.")]
        public string descricao { get; set; }
    }


    public class StatusView : Status
    {
        public bool newRegister { get; set; }
    }

    public class StatusRequest : Status { }

    public class StatusIndex
    {
        public List<Status> Status { get; set; }
    }

}