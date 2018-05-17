using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Curtida
    {
        public static Curtida Criar(
                long id,
                long idUsuario,
                long idPost
            )
        {
            return new Curtida(id)
            {
                IdUsuario = idUsuario,
                IdPost = idPost,
            };
        }

        public static Curtida CriarNovo(
                long idUsuario,
                long idPost
            )
        {
            return new Curtida(0)
            {

                IdUsuario = idUsuario,
                IdPost = idPost,
            };
        }
    }
}
