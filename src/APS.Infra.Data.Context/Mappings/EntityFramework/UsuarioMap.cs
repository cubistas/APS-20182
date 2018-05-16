using APS.Domain.Models.Usurios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Infra.Data.Context.Mappings.EntityFramework
{
    public sealed class UsuarioMap: EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuarios");

            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Senha)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Login)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(150)
                .IsRequired();

            HasRequired(x => x.ImagemPerfil)
                .WithOptional(x => x.Usuario);

            Property(x => x.EmailParaContato)
                .HasMaxLength(150)
                .IsOptional();

            Property(x => x.Telefone)
                .HasMaxLength(20)
                .IsOptional();

            Property(x => x.TipoUsuario)
                .IsRequired();

            Ignore(x => x.ConfirmarSenha);
        }
    }
}
