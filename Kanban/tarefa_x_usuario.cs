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
    
    public partial class tarefa_x_usuario
    {
        public int id { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> id_tarefas { get; set; }
        public Nullable<bool> ativo { get; set; }
        public Nullable<int> id_usuario_proximo { get; set; }
        public Nullable<System.DateTime> dt_criacao { get; set; }
        public Nullable<int> id_grupo_usuarios_proximo { get; set; }
        public Nullable<int> indice { get; set; }
        public Nullable<System.DateTime> dt_inicio_tarefa { get; set; }
        public Nullable<System.DateTime> dt_fim_tarefa { get; set; }
    
        public virtual grupo_usuarios grupo_usuarios { get; set; }
        public virtual tarefas tarefas { get; set; }
        public virtual usuario usuario { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}