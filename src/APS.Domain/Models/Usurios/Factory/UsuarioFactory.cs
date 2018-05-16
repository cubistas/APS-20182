using APS.Domain.Models.Common.Anexos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Usurios
{
    public partial class Usuario
    {
        public static Usuario CriarNovo(
                string nome,
                string senha,
                string login,
                string email,
                string emailParaContato,
                string telefone,
                eTipoUsuario tipoUsuario,
                ArquivoUsuario ImagemPerfil
            )
        {
            return new Usuario(0)
            {
                Login = login,
                Nome = nome,
                Senha = senha,
                Email = email,
                EmailParaContato = emailParaContato,
                ImagemPerfil = ImagemPerfil,
                Telefone = telefone,
                TipoUsuario = tipoUsuario
            };
        }

        public static Usuario Criar(
                long id,
                string nome,
                string senha,
                string ConfirmaSenha,
                string email,
                string login,
                string emailParaContato,
                string telefone,
                eTipoUsuario tipoUsuario,
                ArquivoUsuario ImagemPerfil
            )
        {
            return new Usuario(id)
            {
                Login = login,
                Nome = nome,
                Senha = senha,
                ConfirmarSenha = ConfirmaSenha,
                Email = email,
                EmailParaContato = emailParaContato,
                ImagemPerfil = ImagemPerfil,
                Telefone = telefone,
                TipoUsuario = tipoUsuario
            };
        }
    }
}
