using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Object
{
    public class Usuario
    {

        public int idUsuario { get; set; }

        
        [StringLength(50, ErrorMessage = "Limite de 50 caractéres.")]
        [Required(ErrorMessage="Informe o nome do Usuário",AllowEmptyStrings=false)]
        public string nomeUsuario { get; set; }


        [StringLength(50, ErrorMessage = "Limite de 50 caractéres.")]
        [Required(ErrorMessage="Informe um login",AllowEmptyStrings=false)]
        public string login { get; set; }

        [StringLength(20, ErrorMessage = "Limite de 20 caractéres.")]
        [Required(ErrorMessage="Informe uma senha",AllowEmptyStrings=false)]
        public string senha { get; set; }
    }


    public class UsuarioView : Usuario
    {
        public bool newRegister { get; set; }
    }

    public class UsuarioRequest : Usuario { }

    public class UsuarioIndex
    {
        public List<Usuario> Usuario { get; set; }
    }

    public class UsuarioLogin
    {
        public string Login { get; set; }

        public string Senha { get; set; }
    }

}