using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Animal
    {
        public static Animal Criar(
                long id,
                string nome,
                string tipo,
                string raca,
                string descricao,
                decimal kilos,
                ICollection<AnimalArquivo> imagensAnimal
            )
        {
            return new Animal(id)
            {
                Nome = nome,
                Tipo = tipo,
                Raca = raca,
                Descricao = descricao,
                Kilos = kilos,
                ImagensAnimal = imagensAnimal
            };
        }


        public static Animal CriarNovo(
                string nome,
                string tipo,
                string raca,
                string descricao,
                decimal kilos,
                ICollection<AnimalArquivo> imagensAnimal
            )
        {
            return new Animal(0)
            {
                Nome = nome,
                Tipo = tipo,
                Raca = raca,
                Descricao = descricao,
                Kilos = kilos,
                ImagensAnimal = imagensAnimal
            };
        }
    }
}
