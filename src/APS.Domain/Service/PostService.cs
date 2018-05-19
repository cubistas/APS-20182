using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Posts;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Domain.Core.Interface;
using APS.Domain.Core.Exceptions;
using APS.Domain.Interfaces.Repository.Post;
using System;
using APS.Domain.Core.Validation;

namespace APS.Domain.Service
{
    public class PostService : ServiceCRUD<Post>, IPostService
    {
        

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork) :base(unitOfWork, postRepository)
        {
            
        }

        protected override void ValidarCadastro(Post entidade)
        {
            ValidarPadrao(entidade);

            ValidarRegras(entidade).IsValid();
        }

        protected override void ValidarAtualizar(Post entidade)
        {
            ValidarPadrao(entidade);

            ValidarRegras(entidade).IsValid();
        }

        private void ValidarPadrao(Post entidade)
        {
            ValidarRegras(entidade)
                .Greater(x => x.IdUsuario, 1, "Id usuário inválido")
                .IsEnum(x => x.Status, "Enum inválido");

            ValidarEntidadeAnimal(entidade);

        }

        private void ValidarEntidadeAnimal(Post entidade)
        {
            if (entidade.Animal != null)
            {
                var validar = new ValidationRule<Animal>(entidade.Animal)
                    .NotEmpty(x => x.Nome, "Nome está vazio")
                    .NotEmpty(x => x.Tipo, "Tipo está vazio")
                    .NotEmpty(x => x.Raca, "Raça está vazio")
                    .NotEmpty(x => x.Descricao, "Descrição está vazio")
                    .NotEmpty(x => x.Cor, "Cor está vazio")
                    .Greater(x => x.Kilos, (decimal)0.01, "Kilos inválidos");

                foreach (var imagens in entidade.Animal.ImagensAnimal)
                {
                    validar.AddError(
                        new ValidationRule<AnimalArquivo>(imagens)
                           .NotEmpty(x => x.Arquivo.Nome, "Nome da imagem vazio")
                           .NotEmpty(x => x.Arquivo.Conteudo, "O arquivo está vazio")
                           .GetErros()
                        );
                }

                validar.IsValid();
            }
            else
            {
                ValidarRegras(entidade).AddError("Animal está nulo");
            }
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
