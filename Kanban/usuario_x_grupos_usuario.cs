//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kanban
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario_x_grupos_usuario
    {
        public int id { get; set; }
        public Nullable<int> id_grupos_usuario { get; set; }
        public Nullable<int> id_usuario { get; set; }
    
        public virtual grupo_usuarios grupo_usuarios { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
