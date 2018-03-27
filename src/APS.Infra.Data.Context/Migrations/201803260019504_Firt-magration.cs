namespace APS.Infra.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firtmagration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Nome = c.String(maxLength: 8000, unicode: false),
                        Senha = c.String(maxLength: 8000, unicode: false),
                        Login = c.String(maxLength: 8000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
