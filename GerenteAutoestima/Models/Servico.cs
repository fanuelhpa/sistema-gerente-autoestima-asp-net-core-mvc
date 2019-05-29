using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models.Enums;

namespace GerenteAutoestima.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public DateTime TempoExecucao { get; set; }
        public string Descricao { get; set; }
        public TipoServico TipoServico { get; set; }
        public CategoriaServico CategoriaServico { get; set; }
        public ICollection<AgendaServico> AgendasServicos { get; private set; } = new List<AgendaServico>();

        public Servico()
        {
        }

        public Servico(int id, string nome, double preco, DateTime tempoExecucao, string descricao, TipoServico tipoServico, CategoriaServico categoriaServico)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            TempoExecucao = tempoExecucao;
            Descricao = descricao;
            TipoServico = tipoServico;
            CategoriaServico = categoriaServico;
        }

        public void AdicionarAgenda(AgendaServico agendaServico)
        {
            AgendasServicos.Add(agendaServico);
        }

    }
}
