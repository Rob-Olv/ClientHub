using ClientHub.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ClientHub.Infrastructure
{
    public class EstadoRepository : BaseRepository, IEstadoRepository
    {
        public EstadoRepository(AppDbContext dbContext): base(dbContext)
        {
        }

        public IEnumerable<Estado> GetAll()
        {
            var estados = DbContext.Estados.ToList();

            return estados;
        }
    }
}
