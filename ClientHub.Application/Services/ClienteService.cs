using ClientHub.Domain;
using System.Collections.Generic;

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

        public void CreateCliente(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }
    }
}
