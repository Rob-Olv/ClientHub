using ClientHub.Domain;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ClientHub.Application
{
    public class RelatorioService
    {
        private readonly IClienteRepository _clienteRepository;

        public RelatorioService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<ClienteDTO> FiltrarRelatorio(int? idInicial, int? idFinal, int? cidadeId, int? estadoId)
        {
            var clienteModel = _clienteRepository.GetClientByFilterReport(idInicial, idFinal, cidadeId, estadoId);

            var clientes = clienteModel
                .Select(c => new ClienteDTO
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    CPF_CNPJ = c.CpfCnpj.ToString(),
                    CEP = c.CEP,
                    Bairro = c.Bairro,
                    CidadeNome = c.Cidade.Nome,
                    EstadoNome = c.Cidade.Estado.Nome
                })
                .ToList();

            return clientes;
        }
    }
}
