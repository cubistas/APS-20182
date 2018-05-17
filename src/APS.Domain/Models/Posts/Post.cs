using APS.Domain.Core.Models.Common;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Post : Entity
    {
        protected Post() { }
        public Post(long id) { Id = id; }

        public int Latitude { get; private set; }

        public int Longitude { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public long IdUsuario { get; private set; }

        public virtual Usuario Usuario { get; private set; }

        public virtual Animal Animal { get; private set; }

        public eStatusPost Status { get; private set; }

        public virtual ICollection<Curtida> Curtidas { get; private set; }
        
    }
}
