using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Usurios;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Domain.Core.Interface;

namespace APS.Domain.Service
{
    public sealed class UsuarioService: ServiceCRUD<Usuario>, IUsuarioService
    {
        

        public UsuarioService(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork) :base(unitOfWork, usuarioRepository)
        {
            
        }

        public string Mensagem()
        {
            var teste = BuscarTodos().ToList();
            return "Oi, sucesso!!!";
        }


        public override void Dispose()
        {

        }
    }
}
