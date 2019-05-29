using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models.Enums;

namespace GerenteAutoestima.Models
{
    public class AgendaServico
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public StatusAgenda StatusAgenda { get; set; }
        public Servico Servico { get; set; }
        public Usuario Usuario { get; set; }

        public AgendaServico()
        {
        }

        public AgendaServico(int id, DateTime dataHora, StatusAgenda statusAgenda, Servico servico, Usuario usuario)
        {
            Id = id;
            DataHora = dataHora;
            StatusAgenda = statusAgenda;
            Servico = servico;
            Usuario = usuario;
        }
    }

}
