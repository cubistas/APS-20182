using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Usurios;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;

namespace APS.Domain.Service
{
    public sealed class UsuarioService :ServiceCommon, IUsuarioService
    {

        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public void Dispose()
        {

        }

        public string Mensagem()
        {
            var usuarios = usuarioRepository.All().ToList();
            return "Oi, sucesso!!!";
        }

        public bool Validar()
        {
            return true;
        }
    }
}
