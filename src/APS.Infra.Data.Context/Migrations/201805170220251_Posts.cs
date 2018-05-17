namespace APS.Infra.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Posts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Curtida",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdUsuario = c.Long(nullable: false),
                        IdPost = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Post", t => t.IdPost)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario)
                .Index(t => t.IdUsuario)
                .Index(t => t.IdPost);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Latitude = c.Int(nullable: false),
                        Longitude = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        IdUsuario = c.Long(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.IdUsuario)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Animal",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        Tipo = c.String(nullable: false, maxLength: 150, unicode: false),
                        Raca = c.String(nullable: false, maxLength: 150, unicode: false),
                        Descricao = c.String(maxLength: 500, unicode: false),
                        Kilos = c.Decimal(precision: 18, scale: 2),
                        Cor = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Post", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.AnimalArquivo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IdAnimal = c.Long(nullable: false),
                        Conteudo = c.Binary(nullable: false),
                        Arquivo_Caminho = c.String(maxLength: 8000, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 150, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Animal", t => t.IdAnimal, cascadeDelete: true)
                .Index(t => t.IdAnimal);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Curtida", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Curtida", "IdPost", "dbo.Post");
            DropForeignKey("dbo.Post", "IdUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.Animal", "Id", "dbo.Post");
            DropForeignKey("dbo.AnimalArquivo", "IdAnimal", "dbo.Animal");
            DropIndex("dbo.AnimalArquivo", new[] { "IdAnimal" });
            DropIndex("dbo.Animal", new[] { "Id" });
            DropIndex("dbo.Post", new[] { "IdUsuario" });
            DropIndex("dbo.Curtida", new[] { "IdPost" });
            DropIndex("dbo.Curtida", new[] { "IdUsuario" });
            DropTable("dbo.AnimalArquivo");
            DropTable("dbo.Animal");
            DropTable("dbo.Post");
            DropTable("dbo.Curtida");
        }
    }
}
