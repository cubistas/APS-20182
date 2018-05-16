using APS.Application.ViewModel.Usuario;
using APS.Domain.Models.Common.Anexos;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.AutoMapper.ViewModelToDomain
{
    public sealed class UsuarioMap
    {
        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<CadastroViewModel, Usuario>()
                .ConvertUsing(x =>
                    Usuario.Criar(
                            x.Id,
                            x.Nome,
                            x.Senha,
                            x.ConfirmarSenha,
                            x.Email,
                            x.Login,
                            x.EmailParaContato,
                            x.Telefone,
                            x.TipoUsuario,
                            ArquivoUsuario.CriarUpload(
                                    x.Id,
                                    x.ImagemPerfil.Nome,
                                    string.IsNullOrEmpty(x.ImagemPerfil.Arquivo) ? 
                                        null : Convert.FromBase64String(x.ImagemPerfil.Arquivo)
                                )
                        )
                );
        }
    }
}
