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
    public sealed class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            ToTable("Post");

            HasKey(x => x.Id);

            Property(x => x.Latitude)
                .IsRequired();

            Property(x => x.Longitude)
                .IsRequired();

            Property(x => x.DataCriacao)
                .IsRequired();

            Property(x => x.Status)
                .IsRequired();

            HasRequired(x => x.Usuario)
                .WithMany(x => x.Posts)
                .HasForeignKey(x => x.IdUsuario);
            
        }
    }
}
