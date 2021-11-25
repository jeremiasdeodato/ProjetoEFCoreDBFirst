using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class Statusordemtrabalho
    {
        public Statusordemtrabalho()
        {
            Ordemdetrabalho = new HashSet<Ordemdetrabalho>();
        }

        public int StatusOrdemTrabalhoId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Ordemdetrabalho> Ordemdetrabalho { get; set; }
    }
}
