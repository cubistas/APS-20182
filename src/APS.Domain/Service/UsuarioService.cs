using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
namespace APS.Domain.Service
{
    public sealed class UsuarioService :ServiceCommon, IUsuarioService
    {

        public UsuarioService()
        {

        }

        public void Dispose()
        {

        }

        public string Mensagem()
        {
            return "Oi, sucesso!!!";
        }

        public bool Validar()
        {
            return true;
        }
    }
}
