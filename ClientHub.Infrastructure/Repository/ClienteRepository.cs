using ClientHub.Domain;
using System.Collections.Generic;
using System.Linq;

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
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return DbContext.Clientes.ToList();
        }

        public Cliente GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
