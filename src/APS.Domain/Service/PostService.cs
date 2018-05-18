using APS.Domain.Interfaces.Service;
using APS.Domain.Core.Service;
using APS.Domain.Models.Posts;
using System.Data.Entity;
using System.Linq;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Domain.Core.Interface;
using APS.Domain.Core.Exceptions;
using APS.Domain.Interfaces.Repository.Post;

namespace APS.Domain.Service
{
    public class PostService : ServiceCRUD<Post>, IPostService
    {
        

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork) :base(unitOfWork, postRepository)
        {
            
        }

        protected override void ValidarCadastro(Post entidade)
        {
            
        }

        protected override void ValidarAtualizar(Post entidade)
        {
            
        }

        private void ValidarPadrao()
        {

        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
