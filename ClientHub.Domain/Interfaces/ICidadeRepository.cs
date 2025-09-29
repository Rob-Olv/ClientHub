using System.Collections.Generic;

namespace ClientHub.Domain
{
    public interface ICidadeRepository
    {
        IEnumerable<Cidade> GetAll();

        IEnumerable<Cidade> GetAllForState(int stateId);
        Cidade GetCityByName(string cityName);
    }
}
