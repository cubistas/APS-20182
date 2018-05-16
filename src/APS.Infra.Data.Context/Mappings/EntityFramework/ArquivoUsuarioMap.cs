using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.Data.Context.Mappings.EntityFramework
{
    public class ArquivoUsuarioMap: EntityTypeConfiguration<ArquivoUsuario>
    {
        public ArquivoUsuarioMap()
        {
            ToTable("ArquivoUsuario");

            HasKey(x => x.Id);

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
