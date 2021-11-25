using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class Requisicao
    {
        public Requisicao()
        {
            Ordemdetrabalho = new HashSet<Ordemdetrabalho>();
        }

        public long RequisicaoId { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataUltimaAtualizacao { get; set; }
        public DateTime? DataFechamento { get; set; }
        public int? StatusId { get; set; }

        public virtual Statusrequisicao Status { get; set; }
        public virtual ICollection<Ordemdetrabalho> Ordemdetrabalho { get; set; }
    }
}
