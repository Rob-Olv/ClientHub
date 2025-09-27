using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClientHub.Domain
{
    public class Cliente : BaseDomain
    {
        public string Nome { get; set; }
        public string CEP { get; set; }
        [NotMapped]
        public CPF_CNPJ CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }

        public string CpfCnpjValue
        {
            get => CpfCnpj?.Value;
            set => CpfCnpj = string.IsNullOrWhiteSpace(value) ? null : new CPF_CNPJ(value);
        }
    }
}
