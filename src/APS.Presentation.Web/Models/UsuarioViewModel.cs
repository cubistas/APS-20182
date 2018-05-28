using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APS.Presentation.Web.Models
{
    public class UsuarioViewModel
    {
        public int Codigo { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        public UsuarioViewModel() { }
    }

    public class LoginUsuarioViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public LoginUsuarioViewModel() { }
    }
}