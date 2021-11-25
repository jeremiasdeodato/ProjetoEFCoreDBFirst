using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class Analistasuporte
    {
        public Analistasuporte()
        {
            Ordemdetrabalho = new HashSet<Ordemdetrabalho>();
        }

        public long AnalistaSuporteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Ramal { get; set; }
        public ulong? AnalistaAtivo { get; set; }

        public virtual ICollection<Ordemdetrabalho> Ordemdetrabalho { get; set; }
    }
}
