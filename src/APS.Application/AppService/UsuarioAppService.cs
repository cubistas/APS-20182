using APS.Application.Interfaces;
using APS.Domain.Interfaces.Service;
using System;

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
            GC.SuppressFinalize(this);
        }

        public string OlaPutedo()
        {
            return usuarioService.Mensagem();
        }
    }
}
