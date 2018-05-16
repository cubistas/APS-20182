namespace APS.Infra.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuario1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "ConfirmarSenha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "ConfirmarSenha", c => c.String(maxLength: 8000, unicode: false));
        }
    }
}
