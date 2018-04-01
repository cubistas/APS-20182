using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Usurios;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Domain.Core.Interface;
using APS.Domain.Core.Exception;

namespace APS.Domain.Service
{
    public class UsuarioService: ServiceCRUD<Usuario>, IUsuarioService
    {
        

        public UsuarioService(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork) :base(unitOfWork, usuarioRepository)
        {
            
        }

        protected override void ValidarCadastro(Usuario entidade)
        {
            if (entidade.Nome.Length<3)
            {
                throw new ServiceException("Erro");
            }
        }

        protected override void ValidarAtualizar(Usuario entidade)
        {
            
            ValidarRegras(entidade)
                .AddValidacao(()=> (repositorio.Get(y => y.Nome == entidade.Nome && y.Id != entidade.Id) == null),
                "Nome repetido")
                .NotNull(x => x.Login, "Login vazio")
                .NotEmpty(x => x.Nome, "Nome vazio")
                .Length(x=> x.Login, 3, 4, "tamanho");

            if (entidade.Senha == "12345")
                ValidarRegras().AddError("erro senha");

            ValidarRegras().IsValid();
        }

        protected override void ValidarRemover(Usuario entidade)
        {
            if (entidade.Nome.Length < 3)
            {
                throw new ServiceException("Erro");
            }
        }

        public override void Dispose()
        {

        }
    }
}
