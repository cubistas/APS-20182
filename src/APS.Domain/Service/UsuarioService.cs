using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Usurios;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Domain.Core.Interface;
using APS.Domain.Core.Exceptions;

namespace APS.Domain.Service
{
    public class UsuarioService: ServiceCRUD<Usuario>, IUsuarioService
    {
        

        public UsuarioService(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork) :base(unitOfWork, usuarioRepository)
        {
            
        }

        protected override void ValidarCadastro(Usuario entidade)
        {
            ValidarRegras(entidade)
                .Equals(x => x.Senha, x => x.ConfirmarSenha, "Senha diferentes");

            this.ValidacaoBasica(entidade);

            ValidarRegras().IsValid();
        }

        protected override void ValidarAtualizar(Usuario entidade)
        {

            this.ValidacaoBasica(entidade);

            ValidarRegras().IsValid();
        }        


        private void ValidacaoBasica(Usuario entidade) {
            ValidarRegras(entidade)
                .NotEmpty(x => x.Login, "Login vazio")
                .NotEmpty(x => x.Nome, "Nome vazio")
                .NotEmpty(x => x.Senha, "Senha vazio")
                .IsValidEmail(x => x.Email, "Email inválido")
                .IsEnum(x => x.TipoUsuario, "Enum inválido");

            if (!string.IsNullOrEmpty(entidade.EmailParaContato))
                ValidarRegras(entidade).IsValidEmail(x => x.Email, "Email para contato não é valido inválido");

            if (entidade.ImagemPerfil?.Arquivo != null)
            {
                ValidarRegras(entidade)
                   .NotEmpty(x => x.ImagemPerfil.Arquivo.Nome, "Nome da imagem vazio")
                   .NotEmpty(x => x.ImagemPerfil.Arquivo.Conteudo, "O arquivo está vazio");
            }
            else
            {
                ValidarRegras().AddError("Imagem vazia"); 
            }

        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
