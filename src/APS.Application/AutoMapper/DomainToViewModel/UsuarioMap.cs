using APS.Application.ViewModel.Usuario;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.AutoMapper.DomainToViewModel
{
    public sealed class UsuarioMap
    {
        public static void Map(DomainToViewModelMappingProfile profile)
        {
            profile.CreateMap<Usuario, CadastroViewModel>();
        }
    }
}
