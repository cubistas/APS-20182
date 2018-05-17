using APS.Domain.Models.Posts;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.Data.Context.Mappings.EntityFramework
{
    public sealed class CurtidaMap : EntityTypeConfiguration<Curtida>
    {
        public CurtidaMap()
        {
            ToTable("Curtida");

            HasKey(x => x.Id);

            HasRequired(x => x.Usuario)
                .WithMany(x => x.Curtidas)
                .HasForeignKey(x => x.IdUsuario);

            HasRequired(x => x.Post)
                .WithMany(x => x.Curtidas)
                .HasForeignKey(x => x.IdPost);
        }
    }
}
