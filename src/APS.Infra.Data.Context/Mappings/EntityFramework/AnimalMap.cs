using APS.Domain.Models.Posts;
using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.Data.Context.Mappings.EntityFramework
{
    public sealed class AnimalMap : EntityTypeConfiguration<Animal>
    {
        public AnimalMap()
        {
            ToTable("Animal");

            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Tipo)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Raca)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Descricao)
                .HasMaxLength(500)
                .IsOptional();

            Property(x => x.Kilos)
                .IsOptional();

            Property(x => x.Cor)
                .HasMaxLength(15)
                .IsOptional();

            HasRequired(x => x.Post)
                .WithOptional(x => x.Animal);
        }
    }
}
