using ClientHub.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientHub.Infrastructure
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        public ClienteRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public void Add(Cliente cliente)
        {
            DbContext.Clientes.Add(cliente);
            DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var cliente = DbContext.Clientes.Find(id);

            if (cliente != null)
            {
                DbContext.Clientes.Remove(cliente);
                DbContext.SaveChanges();
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            return DbContext.Clientes.ToList();
        }

        public async Task<Cliente> GetById(int id)
        {
            var cliente = await DbContext.Clientes.FindAsync(id);

            return cliente;
        }

        public async Task Update(Cliente cliente)
        {
            DbContext.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public List<Cliente> GetClientByFilterReport(int? idInicial, int? idFinal, int? cidadeId, int? estadoId)
        {
            var query = DbContext.Clientes.AsQueryable();

            if (idInicial.HasValue)
                query = query.Where(c => c.Id >= idInicial.Value);

            if (idFinal.HasValue)
                query = query.Where(c => c.Id <= idFinal.Value);

            if (cidadeId.HasValue)
                query = query.Where(c => c.CidadeId == cidadeId.Value);

            if (estadoId.HasValue)
                query = query.Where(c => c.Cidade.Estado.Id == estadoId.Value);

            return query.ToList();
        }

        public int GetCountAllClients()
        {
            return DbContext.Clientes.Count();
        }

        public string GetLastClient()
        {
            var lastClient = DbContext.Clientes
            .OrderByDescending(x => x.Id) 
            .Select(x => x.Nome)
            .FirstOrDefault();

            return lastClient;
        }

        public DateTime GetLastDateCreateClient()
        {
            var lastCreateClient = DbContext.Clientes
                .OrderByDescending(x => x.Id)
                .Select(x => x.CriadoEm)
                .FirstOrDefault();

            return lastCreateClient;
        }
    }
}
