using System.Collections.Generic;

namespace ClientHub.Domain
{
    public class Cidade : BaseDomain
    {
        public string Nome { get; set; }
        public int EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
    }
}
