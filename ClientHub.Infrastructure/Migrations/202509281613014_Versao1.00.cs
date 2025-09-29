namespace ClientHub.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao100 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.cliente", "criado_em", c => c.DateTime(nullable: false));
            AddColumn("dbo.cidade", "criado_em", c => c.DateTime(nullable: false));
            AddColumn("dbo.estado", "criado_em", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.estado", "criado_em");
            DropColumn("dbo.cidade", "criado_em");
            DropColumn("dbo.cliente", "criado_em");
        }
    }
}
