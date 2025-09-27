using System.Collections.Generic;

namespace ClientHub.Domain
{
    public class Estado : BaseDomain
    {
        public string Nome { get; set; }
        public string Uf { get; set; }

        public virtual List<Cidade> Cidades { get; set; }
    }
}
