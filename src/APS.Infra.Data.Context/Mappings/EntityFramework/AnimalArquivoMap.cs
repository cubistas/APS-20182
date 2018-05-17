using APS.Domain.Models.Posts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.Data.Context.Mappings.EntityFramework
{
    public sealed class AnimalArquivoMap: EntityTypeConfiguration<AnimalArquivo>
    {
        public AnimalArquivoMap()
        {
            ToTable("AnimalArquivo");

            HasKey(x => x.Id);

            HasRequired(x => x.Animal)
                .WithMany(x => x.ImagensAnimal)
                .HasForeignKey(d => d.IdAnimal)
                .WillCascadeOnDelete(true);

            Property(x => x.Arquivo.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Arquivo.Conteudo)
                .HasColumnName("Conteudo")
                .IsRequired();
        }
    }
}
