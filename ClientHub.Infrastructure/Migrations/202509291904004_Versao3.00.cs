namespace ClientHub.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Versao300 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.cliente", "cpf_cnpj", unique: true, name: "IX_CpfCnpj");
        }
        
        public override void Down()
        {
            DropIndex("dbo.cliente", "IX_CpfCnpj");
        }
    }
}
