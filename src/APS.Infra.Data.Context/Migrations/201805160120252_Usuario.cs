namespace APS.Infra.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 150, unicode: false),
                        ConfirmarSenha = c.String(maxLength: 8000, unicode: false),
                        Login = c.String(nullable: false, maxLength: 150, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        EmailParaContato = c.String(maxLength: 150, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        TipoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ArquivoUsuario", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ArquivoUsuario",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Conteudo = c.Binary(nullable: false),
                        Arquivo_Caminho = c.String(maxLength: 8000, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Id", "dbo.ArquivoUsuario");
            DropIndex("dbo.Usuarios", new[] { "Id" });
            DropTable("dbo.ArquivoUsuario");
            DropTable("dbo.Usuarios");
        }
    }
}
