using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Object
{
    public class TarefaUsuario {

		public int idTarefaUsuario{ get; set; }
		
		public Usuario usuario{ get; set; }
		
		[Required(ErrorMessage = "É necessário informar uma Tarefa", AllowEmptyStrings = false)]
        public Tarefa tarefa{ get; set; }
		
		public bool ativo{ get; set; }
		
		public Usuario proximoUsuario{ get; set; }
		
		[DataType(DataType.Time)]
		[Required(ErrorMessage = "Informe a Data de Criação", AllowEmptyStrings = false)]
		public TimeSpan dtCriacao{ get; set; }
		
		public UsuarioGrupo proximoUsuarioGrupo{ get; set; }
		
		[Required(ErrorMessage = "É necessário informar um índice", AllowEmptyStrings = false)]
		public int indice{ get; set; }
		
		[DataType(DataType.Time)]
		public TimeSpan dtInicioTarefa{ get; set; }
		
		[DataType(DataType.Time)]
		public TimeSpan dtFimTarefa{ get; set; }
	}


    public class TarefaUsuarioView : TarefaUsuario
    {
        public bool newRegister { get; set; }
    }

    public class TarefaUsuarioRequest : TarefaUsuario { }

    public class TarefaUsuarioIndex
    {
        public List<TarefaUsuario> TarefaUsuario { get; set; }
    }
}