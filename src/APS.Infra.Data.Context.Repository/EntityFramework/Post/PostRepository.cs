using APS.Domain.Interfaces.Repository.Post;
using APS.Domain.Interfaces.Repository.Usuario;
using APS.Infra.Data.Context.Repository.EntityFramework.Usuario.Common;
using APS.Infra.Data.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostDom = APS.Domain.Models.Posts.Post;

namespace APS.Infra.Data.Context.Repository.EntityFramework.Post
{
    public sealed class PostRepository : Repository<PostDom>, IPostRepository
    {


        public PostRepository(IDbContext dbContext):base(dbContext)
        {
        }
       
        
    }
}
