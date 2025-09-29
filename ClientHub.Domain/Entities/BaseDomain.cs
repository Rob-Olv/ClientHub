using System;

namespace ClientHub.Domain
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }

        protected BaseDomain()
        {
            CriadoEm = DateTime.UtcNow;
        }
    }
}
