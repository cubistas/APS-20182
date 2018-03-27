using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Interfaces.Repository.Usuario
{
    public interface IUsuarioRepository
    {
        IEnumerable<Models.Usurios.Usuario> All();
    }
}
