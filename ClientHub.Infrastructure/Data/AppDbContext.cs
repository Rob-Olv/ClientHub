using ClientHub.Domain;
using System.Data.Entity;

namespace ClientHub.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("ClientHubConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppDbContext>());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new CidadeConfig());
            modelBuilder.Configurations.Add(new EstadoConfig());
        }
    }
}
