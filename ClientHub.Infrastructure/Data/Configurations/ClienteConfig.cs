using ClientHub.Domain;
using System.Data.Entity.ModelConfiguration;

namespace ClientHub.Infrastructure
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("cliente");
            HasKey(c => c.Id);
            Property(x => x.Id).HasColumnName("id").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(80).IsRequired();
            Property(x => x.CEP).HasColumnName("cep").HasMaxLength(8).IsRequired();
            Property(x => x.CpfCnpjValue).HasColumnName("cpf_cnpj").HasMaxLength(14).IsRequired();
            Property(x => x.Endereco).HasColumnName("endereco").HasMaxLength(100).IsRequired();
            Property(x => x.Numero).HasColumnName("numero").HasMaxLength(20).IsRequired();
            Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(60);
            Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(100).IsRequired();
            Property(x => x.DataNascimento).HasColumnName("data_nascimento");

            Property(x => x.CidadeId).HasColumnName("cidadeId");
            HasRequired(x => x.Cidade).WithMany(x => x.Clientes).HasForeignKey(c => c.CidadeId).WillCascadeOnDelete(false);
        }
    }
}
