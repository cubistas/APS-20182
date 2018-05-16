using APS.Application.ViewModel.Common;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.ViewModel.Usuario
{
    public sealed class CadastroViewModel
    {

        public CadastroViewModel()
        {
            ImagemPerfil = new AnexoViewModel();
        }

        public long Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public string EmailParaContato { get; set; }

        public string Telefone { get; set; }

        public eTipoUsuario TipoUsuario { get => eTipoUsuario.Padrao; }

        public AnexoViewModel ImagemPerfil { get; set; }
    }
}
