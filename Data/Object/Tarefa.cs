using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Data.Object
{
    public class Tarefa
    {
        public int id { get; set; }
      
        [Required]
        public int idSprint { get; set; }

        [Required]
        public int idProjeto { get; set; }

        [StringLength(500, ErrorMessage="Limite de 500 caractéres.")]
        [Required(ErrorMessage="Informe uma descrição para a Tarefa",AllowEmptyStrings=false)]
        public string descricao { get; set; }

        [Required]
        public int idStatus { get; set; }

        public int idGrupoUsuariosFases { get; set; }

        public int indice { get; set; }

        [Required(ErrorMessage="Informe uma Status para a Tarefa",AllowEmptyStrings=false)]
        public Status status { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoEstimado { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan tempoTrabalhado { get; set; }

        [Required]
        public int idTipo { get; set; }

        public int idClassificacao { get; set; }
        
        [Required(ErrorMessage="Informe algum Tipo para a Tarefa",AllowEmptyStrings=false)]
        public Tipo tipo { get; set; }

        [Required(ErrorMessage="Informe uma Classificação para a Tarefa",AllowEmptyStrings=false)]
        public Classificacao classificacao { get; set; }
        
        public bool tarefaPlanejada { get; set; }
        
        public int idTarefaDependencia { get; set; }

        public DateTime dtCriacao { get; set; }

        public int idTarefaAgrupador { get; set; }

        public DateTime dataCriacao { get; set; }
        
        public Tarefa tarefaDependencia;
        
        // Tarefa que irá agrupar as demais tarefas, por exemplo uma tarefa do Tipo Etapa
        public Tarefa tarefaAgrupador{ get; set; }
        
        public List<Comentario> listComentario{get; set; }
        
        [Required]
        public Usuario usuarioCriador{ get; set; }
    }

    public class TarefaIndex
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public DateTime dtCriacao  { get; set; }
        public string projeto { get; set; }
    }

    public class TarefaView
    {
        public bool newRegister { get; set; }
        
        public int TarefaId { get; set; }
        public string Descricao { get; set; }
        public int indice { get; set; }
        public string UsuarioCriador { get; set; }

        public List<SelectListItem> Sprint { get; set; }
        public List<SelectListItem> Projeto { get; set; }
        public List<SelectListItem> Status { get; set; }
        public List<SelectListItem> Fases { get; set; }
        public List<SelectListItem> Tipo { get; set; }
        public List<SelectListItem> Classificacao { get; set; }
        public List<SelectListItem> Usuarios { get; set; }
        public List<SelectListItem> Tarefas { get; set; }

        public TimeSpan TempoEstimado { get; set; }
        public TimeSpan TempoTrabalhado { get; set; }
        
        public DateTime DataCriacao { get; set; }
        //grupoUsuarioxFase - tarefa_planejada - tarefa_dependencia - tarefa_agrupador
    }

}
