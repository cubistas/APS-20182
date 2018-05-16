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
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = 0,
                Arquivo = ArquivoFisico.CriarExistente(
                        nome,
                        arquivo
                    )
            };
        }

        public static AnimalArquivo CriarUpload(
                long id,
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = id,
                Arquivo = ArquivoFisico.CriarUpload(
                        nome,
                        arquivo
                    )
            };
        }

        public static AnimalArquivo CriarExistente(
                long id,
                string nome,
                byte[] arquivo
            )
        {
            return new AnimalArquivo()
            {
                Id = id,
                Arquivo = ArquivoFisico.CriarExistente(
                        nome,
                        arquivo
                    )
            };
        }
    }
}
