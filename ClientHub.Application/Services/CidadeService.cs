using ClientHub.Domain;
using System.Collections.Generic;

namespace ClientHub.Application
{
    public class CidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public IEnumerable<Cidade> GetAllCities()
        {
            return _cidadeRepository.GetAll();
        }

        public IEnumerable<Cidade> GetAllCitiesForState(int state)
        {
            return _cidadeRepository.GetAllForState(state);
        }

        public Cidade GetCityForName(string name)
        {
            var cidade = _cidadeRepository.GetCityByName(name);

            return cidade;
        }
    }
}
