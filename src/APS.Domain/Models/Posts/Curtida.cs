using APS.Domain.Core.Models.Common;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Curtida : Entity
    {
        protected Curtida() { }

        public Curtida(long id) { Id = id; }

        public long IdUsuario { get; private set; }
        public virtual Usuario Usuario { get; private set; }

        public long IdPost { get; private set; }
        public virtual Post Post { get; private set; }
        
    }
}
