using APS.Domain.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Usurios
{
    public sealed class Usuario : Entity
    {

        #region Factor
        public static Usuario CriarNovo(
                string nome,
                string senha,
                string login
            )
        {
            return new Usuario(0)
            {
                Login = login,
                Nome = nome,
                Senha = senha
            };
        }

        public static Usuario Criar(
                long id,
                string nome,
                string senha,
                string login
            )
        {
            return new Usuario(id)
            {
                Login = login,
                Nome = nome,
                Senha = senha
            };
        } 
        #endregion

        private Usuario(long id)
        {
            Id = id;
        }

        protected Usuario() { }

        public string Nome { get; private set; }
        public string Senha { get; private set; }
        public string Login { get; private set; }
    }
}
