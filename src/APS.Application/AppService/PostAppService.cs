using APS.Application.Interfaces;
using APS.Domain.Interfaces.Service;
using System;
using APS.Application.ViewModel.Posts;
using AutoMapper;
using APS.Domain.Models.Posts;
using System.Collections.Generic;
using System.Linq;

namespace APS.Application.AppService
{
    public sealed class PostAppService : IPostAppService
    {
        private readonly IPostService postService;
        private readonly IMapper mapper;
        public PostAppService(IPostService postService, IMapper mapper)
        {
            this.postService = postService;
            this.mapper = mapper;
        }

        public ICollection<CadastroViewModel> BuscarTodos()
        {
            var lista = postService.BuscarTodos();
            return mapper.Map<ICollection<CadastroViewModel>>(lista);
        }

        public void Cadastrar(CadastroViewModel cadastroViewModel)
        {
            //var post = mapper.Map<Post>(cadastroViewModel);

            var post = Post.Criar(
                    0,
                    1,
                    10000,
                    6446546,
                    DateTime.Now,
                    ObterAnimail()
                );

            postService.Cadastrar(post);
        }

        private Animal ObterAnimail()
        {
            return Animal.Criar(
                    0,
                    "Hue",
                    "Peidão",
                    "negra",
                    "dididi he",
                    10,
                    "#ccc",
                    new List<AnimalArquivo>()
                    {
                        AnimalArquivo.CriarUpload(0,0,"HUe.jpg", new byte[]{ 00,11,22,77,}),
                        AnimalArquivo.CriarUpload(0,0,"zz.jpg", new byte[]{ 00,11,22,77,})
                    }
                );
        }

        public void Atualizar(CadastroViewModel cadastroViewModel)
        {
            var post = mapper.Map<Post>(cadastroViewModel);
            postService.Atualizar(post);
        }

        public CadastroViewModel BuscarPorId(long id)
        {
            return mapper.Map<CadastroViewModel>(
                postService.BuscarPorId(id)
            );
        }

        public void Remover(long id)
        {
            postService.Remover(id);
        }

        public void Dispose()
        {
            postService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
