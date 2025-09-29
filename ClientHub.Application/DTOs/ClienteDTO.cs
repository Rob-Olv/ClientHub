using System;

namespace ClientHub.Application
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CidadeId { get; set; }
        public string CidadeNome { get; set; }
        public string EstadoNome { get; set; }
    }
}
