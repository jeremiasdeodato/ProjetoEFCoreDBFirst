using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjetoEFCoreDBFirst
{
    public partial class Ordemdetrabalho
    {
        public long RequisicaoId { get; set; }
        public long OrdemTrabalhoId { get; set; }
        public string Descricao { get; set; }
        public int? StatusOrdemTrabalhoId { get; set; }
        public long? AnalistaSuporteId { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public virtual Analistasuporte AnalistaSuporte { get; set; }
        public virtual Requisicao Requisicao { get; set; }
        public virtual Statusordemtrabalho StatusOrdemTrabalho { get; set; }
    }
}
