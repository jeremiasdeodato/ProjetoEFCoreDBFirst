using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class Statusrequisicao
    {
        public Statusrequisicao()
        {
            Requisicao = new HashSet<Requisicao>();
        }

        public int StatusId { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Requisicao> Requisicao { get; set; }
    }
}
