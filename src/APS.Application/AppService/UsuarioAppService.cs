using APS.Application.Interfaces;
using APS.Domain.Interfaces.Service;
using System;
using APS.Application.ViewModel.Usuario;
using AutoMapper;
using APS.Domain.Models.Usurios;

namespace APS.Application.AppService
{
    public sealed class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService usuarioService;
        private readonly IMapper mapper;
        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper)
        {
            this.usuarioService = usuarioService;
            this.mapper = mapper;
        }

        public void Cadastrar(CadastroViewModel cadastroViewModel)
        {
            var usuario = mapper.Map<Usuario>(cadastroViewModel);
            usuarioService.Cadastrar(usuario);
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
