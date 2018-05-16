using APS.Application.ViewModel.Posts;
using APS.Domain.Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.AutoMapper.ViewModelToDomain
{
    public static class PostMap
    {

        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<AnimalViewModel, Animal>()
                .ConstructUsing(x=> 
                    Animal.Criar(
                            x.Id,
                            x.Nome,
                            x.Tipo,
                            x.Raca,
                            x.Descricao,
                            x.Kilos,
                            profile.Mapper.Map<ICollection<AnimalArquivo>>(x.ImagensAnimal)
                        )
                );
        }
    }
}
