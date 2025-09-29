using ClientHub.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientHub.Application
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAll();
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            var cliente = await _clienteRepository.GetById(id);

            return cliente;
        }

        public void CreateCliente(ClienteDTO clienteDto)
        {
            var cliente = new Cliente
            {
                Nome = clienteDto.Nome,
                CEP = clienteDto.CEP,
                CpfCnpj = new CPF_CNPJ(clienteDto.CPF_CNPJ),
                Endereco = clienteDto.Endereco,
                Numero = clienteDto.Numero,
                Complemento = clienteDto.Complemento,
                Bairro = clienteDto.Bairro,
                DataNascimento = clienteDto.DataNascimento,
                CidadeId = clienteDto.CidadeId
            };

            _clienteRepository.Add(cliente);
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.Delete(id);
        }

        public async Task UpdateCliente(ClienteDTO clienteDto)
        {
            var cliente = await GetClienteById(clienteDto.Id);

            cliente.Nome = clienteDto.Nome;
            cliente.CEP = clienteDto.CEP;
            cliente.CpfCnpj = new CPF_CNPJ(clienteDto.CPF_CNPJ);
            cliente.Endereco = clienteDto.Endereco;
            cliente.Numero = clienteDto.Numero;
            cliente.Complemento = clienteDto.Complemento;
            cliente.Bairro = clienteDto.Bairro;
            cliente.DataNascimento = clienteDto.DataNascimento;
            cliente.CidadeId = clienteDto.CidadeId;

            await _clienteRepository.Update(cliente);
        }

        public int GetCountAllClients()
        {
            return _clienteRepository.GetCountAllClients();
        }

        public string GetLastClient()
        {
            return _clienteRepository.GetLastClient();
        }

        public DateTime GetLastCreateClient()
        {
            return _clienteRepository.GetLastDateCreateClient();
        }
    }
}
