using ClientHub.Domain;
using System.Collections.Generic;
using System.Linq;

namespace ClientHub.Infrastructure
{
    public class CidadeRepository : BaseRepository, ICidadeRepository
    {
        public CidadeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Cidade> GetAll()
        {
            return DbContext.Cidades.ToList();
        }

        public IEnumerable<Cidade> GetAllForState(int stateId)
        {
            var cidades = DbContext.Cidades
                        .Where(x => x.EstadoId == stateId)
                        .ToList();

            return cidades;
        }

        public Cidade GetCityByName(string cityName)
        {
            var city = DbContext.Cidades
                .Where(x => x.Nome.ToUpper() == cityName.ToUpper())
                .FirstOrDefault();

            return city;
        }
    }
}
