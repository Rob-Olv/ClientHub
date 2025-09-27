using ClientHub.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClientHub.Infrastructure
{
    public class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        public EstadoConfig()
        {
            ToTable("estado");
            HasKey(c => c.Id);
            Property(x => x.Id).HasColumnName("id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            Property(x => x.Uf).HasColumnName("uf").HasMaxLength(2).IsRequired();
        }
    }
}
