using System.Collections.Generic;

namespace ClientHub.Domain
{
    public interface IEstadoRepository
    {
        IEnumerable<Estado> GetAll();
    }
}
