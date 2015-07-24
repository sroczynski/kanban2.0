using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class GrupoUsuarios
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public string corGrupo { get; set; }

        public int idUsuarioLider { get; set; }

        public bool ativo { get; set; }
    }


    public class GrupoUsuariosView : GrupoUsuarios
    {
        public bool newRegister { get; set; }
    }

    public class GrupoUsuariosRequest : GrupoUsuarios { }

    public class GrupoUsuariosIndex
    {
        public List<GrupoUsuarios> GrupoUsuarios { get; set; }
    }
}
