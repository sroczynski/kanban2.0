using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Object
{
    public class GrupoUsuariosFases
    {
        public int id { get; set; }

        public int idGrupoUsuariosFases { get; set; }

        public int idFases { get; set; }
    }
    
    public class GrupoUsuariosFasesView : GrupoUsuariosFases
    {
        public bool newRegister { get; set; }
    }

    public class GrupoUsuariosFasesRequest : GrupoUsuariosFases { }

    public class GrupoUsuariosFasesIndex
    {
        public List<GrupoUsuariosFases> GrupoUsuariosFases { get; set; }
    }
}
