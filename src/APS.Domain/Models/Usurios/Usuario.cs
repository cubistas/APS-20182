using APS.Domain.Core.Models.Common;
using APS.Domain.Models.Posts;
using System.Collections.Generic;

namespace APS.Domain.Models.Usurios
{
    public partial class Usuario : Entity
    {        

        private Usuario(long id)
        {
            Id = id;
        }

        protected Usuario() { }

        public string Nome { get; private set; }

        public string Senha { get; private set; }

        public string ConfirmarSenha { get; private set; }

        public string Login { get; private set; }

        public string Email { get; private set; }

        public string EmailParaContato { get; private set; }

        public string Telefone { get; private set; }

        public eTipoUsuario TipoUsuario { get; private set; }

        public virtual ArquivoUsuario ImagemPerfil { get; private set; }

        public virtual ICollection<Curtida> Curtidas { get; private set; }

        public virtual ICollection<Post> Posts { get; private set; }

    }
}
