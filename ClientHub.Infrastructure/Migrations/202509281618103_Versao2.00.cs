namespace ClientHub.Infrastructure.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Versao200 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO dbo.estado (nome, uf, criado_em)
            VALUES ('Minas Gerais', 'MG', GETDATE()),
                   ('São Paulo', 'SP', GETDATE()),
                   ('Rio de Janeiro', 'RJ', GETDATE()),
                   ('Bahia', 'BA', GETDATE());
            ");

            Sql(@"
            INSERT INTO dbo.cidade (nome, estadoId, criado_em)
            VALUES 
                ('Belo Horizonte', (SELECT id FROM dbo.estado WHERE uf = 'MG'), GETDATE()),
                ('São Paulo', (SELECT id FROM dbo.estado WHERE uf = 'SP'), GETDATE()),
                ('Saquarema', (SELECT id FROM dbo.estado WHERE uf = 'RJ'), GETDATE()),
                ('Salvador', (SELECT id FROM dbo.estado WHERE uf = 'BA'), GETDATE());
            ");
        }

        public override void Down()
        {
        }
    }
}
