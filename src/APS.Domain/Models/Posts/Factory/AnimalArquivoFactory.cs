using APS.Domain.Models.Common.Anexos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class AnimalArquivo
    {
        public static AnimalArquivo CriarNovo(
                long idAnimal,
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = 0,
                IdAnimal = idAnimal,
                Arquivo = ArquivoFisico.CriarExistente(
                        nome,
                        arquivo
                    )
            };
        }

        public static AnimalArquivo CriarUpload(
                long id,
                long idAnimal,
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = id,
                IdAnimal = idAnimal,
                Arquivo = ArquivoFisico.CriarUpload(
                        nome,
                        arquivo
                    )
            };
        }

        public static AnimalArquivo Criar(
                long id,
                long idAnimal,
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = id,
                IdAnimal = idAnimal,
                Arquivo = ArquivoFisico.CriarExistente(
                        nome,
                        arquivo
                    )
            };
        }
    }
}
