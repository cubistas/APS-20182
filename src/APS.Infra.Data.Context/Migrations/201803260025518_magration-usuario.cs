namespace APS.Infra.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class magrationusuario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Usuarios", "Login", c => c.String(nullable: false, maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Login", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
