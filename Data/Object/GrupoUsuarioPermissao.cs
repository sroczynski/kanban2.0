using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class GrupoUsuarioPermissao
    {
        public int id { get; set; }

        public int idPermissao { get; set; }

        public int idGrupoUsuario { get; set; }
    }

    public class GrupoUsuarioPermissaoView : GrupoUsuarioPermissao
    {
        public bool newRegister { get; set; }
    }

    public class GrupoUsuarioPermissaoRequest : GrupoUsuarioPermissao { }

    public class GrupoUsuarioPermissaoIndex
    {
        public List<GrupoUsuarioPermissao> GrupoUsuarioPermissao { get; set; }
    }
}
