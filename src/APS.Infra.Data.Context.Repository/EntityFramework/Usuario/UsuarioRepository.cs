using APS.Domain.Interfaces.Repository.Usuario;
using APS.Infra.Data.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioModel = APS.Domain.Models.Usurios.Usuario;

namespace APS.Infra.Data.Context.Repository.EntityFramework.Usuario
{
    public sealed class UsuarioRepository : IUsuarioRepository
    {

        private readonly IDbContext dbContext;

        public UsuarioRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<UsuarioModel> All()
        {
            return dbContext.Set<UsuarioModel>().AsEnumerable();
        }
        
    }
}
