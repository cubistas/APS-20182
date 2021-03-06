﻿
using APS.Infra.Data.Context.Mappings.EntityFramework;
using APS.Infra.Data.Core.Config;
using Oracle.ManagedDataAccess.Client;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace APS.Infra.Data.Context.Config
{
    public sealed class APSContext : BaseDbContext
    {
        #region Atributos e Propriedades

        internal const string NomeStringConexao = "APSPadrao";

        #endregion

        #region Construtores

        public APSContext() : base(NomeStringConexao)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        #endregion

        #region Métodos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            RemoverConvencoes(modelBuilder);
            ConfigurarTipoPadraoColunasPropriedadesString(modelBuilder);

            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new ArquivoUsuarioMap());
            modelBuilder.Configurations.Add(new AnimalMap());
            modelBuilder.Configurations.Add(new AnimalArquivoMap());
            modelBuilder.Configurations.Add(new CurtidaMap());
            modelBuilder.Configurations.Add(new PostMap());

        }

        private static void RemoverConvencoes(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        private static void ConfigurarTipoPadraoColunasPropriedadesString(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
        }

        #endregion
    }
}
