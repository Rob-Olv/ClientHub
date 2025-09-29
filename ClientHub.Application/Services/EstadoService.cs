using ClientHub.Domain;
using System.Collections.Generic;

namespace ClientHub.Application
{
    public class EstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public IEnumerable<Estado> GetAllStates()
        {
            return _estadoRepository.GetAll();
        }
    }
}
