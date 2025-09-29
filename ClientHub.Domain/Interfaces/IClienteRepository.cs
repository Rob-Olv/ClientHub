using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClientHub.Domain
{
    public interface IClienteRepository
    {
        Task<Cliente> GetById(int id);
        IEnumerable<Cliente> GetAll();
        List<Cliente> GetClientByFilterReport(int? idInicial, int? idFinal, int? cidadeId, int? estadoId);
        int GetCountAllClients();
        string GetLastClient();
        DateTime GetLastDateCreateClient();
        Task Add(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(int id);
        Task<bool> ExistsByCpfCnpj(string cpfCnpj);
    }
}
