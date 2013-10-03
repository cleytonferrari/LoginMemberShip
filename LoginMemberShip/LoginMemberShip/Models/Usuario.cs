using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginMemberShip.Models
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string[] Permissoes { get; set; }


        //Para simplificar sera montado uma lista de usuarios na memoria
        public static List<Usuario> ListaDeUsuario()
        {
            return new List<Usuario>
                       {
                           new Usuario{Login = "cleyton",Senha = "171099", Permissoes = new []{"Administrador"}},
                           new Usuario{Login = "anderson",Senha = "171099", Permissoes = new []{"Redator"}}
                       };
        }
    }
}