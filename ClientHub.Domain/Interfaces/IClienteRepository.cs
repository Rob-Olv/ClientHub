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
        void Add(Cliente cliente);
        Task Update(Cliente cliente);
        void Delete(int id);
    }
}
