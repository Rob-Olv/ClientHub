namespace ClientHub.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 80),
                        cep = c.String(nullable: false, maxLength: 8),
                        endereco = c.String(nullable: false, maxLength: 100),
                        numero = c.String(nullable: false, maxLength: 20),
                        complemento = c.String(maxLength: 60),
                        bairro = c.String(nullable: false, maxLength: 100),
                        data_nascimento = c.DateTime(nullable: false),
                        cidadeId = c.Int(nullable: false),
                        cpf_cnpj = c.String(nullable: false, maxLength: 14),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cidade", t => t.cidadeId)
                .Index(t => t.cidadeId);
            
            CreateTable(
                "dbo.cidade",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        estadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.estado", t => t.estadoId)
                .Index(t => t.estadoId);
            
            CreateTable(
                "dbo.estado",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50),
                        uf = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.cliente", "cidadeId", "dbo.cidade");
            DropForeignKey("dbo.cidade", "estadoId", "dbo.estado");
            DropIndex("dbo.cidade", new[] { "estadoId" });
            DropIndex("dbo.cliente", new[] { "cidadeId" });
            DropTable("dbo.estado");
            DropTable("dbo.cidade");
            DropTable("dbo.cliente");
        }
    }
}
