//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanban
{
    using System;
    using System.Collections.Generic;
    
    public partial class tarefa_x_comentario
    {
        public int id { get; set; }
        public int id_tarefas { get; set; }
        public Nullable<System.DateTime> dt_comentário { get; set; }
        public string descricao { get; set; }
        public string anexo { get; set; }
    
        public virtual tarefas tarefas { get; set; }
        public virtual tarefas tarefas1 { get; set; }
    }
}
