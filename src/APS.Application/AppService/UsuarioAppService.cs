using APS.Application.Interfaces;
using APS.Domain.Interfaces.Service;

namespace APS.Application.AppService
{
    public sealed class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService usuarioService;
        public UsuarioAppService(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        public void Dispose()
        {
            usuarioService.Dispose();
        }

        public string OlaPutedo()
        {
            return usuarioService.Mensagem();
        }
    }
}
