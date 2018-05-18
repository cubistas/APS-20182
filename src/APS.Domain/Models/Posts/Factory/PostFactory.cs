using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Post
    {

        public static Post Criar(
                long id,
                long idUsuario,
                int latitude,
                int longitude,
                DateTime dataCriacao,
                Animal animal
            )
        {
            return new Post(id)
            {
                IdUsuario = idUsuario,
                Latitude = latitude,
                Longitude = longitude,
                DataCriacao = dataCriacao,
                Animal = animal,
                Status = eStatusPost.Criacao
            };
        }

    }
}
