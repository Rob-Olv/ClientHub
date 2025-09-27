using ClientHub.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClientHub.Infrastructure
{
    public class CidadeConfig : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfig()
        {
            ToTable("cidade");
            HasKey(c => c.Id);
            Property(x => x.Id).HasColumnName("id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();

            Property(x => x.EstadoId).HasColumnName("estadoId");
            HasRequired(x => x.Estado).WithMany(x => x.Cidades).WillCascadeOnDelete(false);
        }
    }
}
