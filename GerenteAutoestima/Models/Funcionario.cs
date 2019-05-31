using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models.Enums;

namespace GerenteAutoestima.Models

{
    public class Funcionario
    {
        public int Id { get; set; }
        public TipoFuncionario TipoFuncionario { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<AgendaServico> AgendasServicos { get; private set; } = new List<AgendaServico>();

        public Funcionario()
        {
        }

        public Funcionario(int id, TipoFuncionario tipoFuncionario, Usuario usuario)
        {
            Id = id;
            TipoFuncionario = tipoFuncionario;
            Usuario = usuario;
        }

        public void AdiconarAgenda(AgendaServico agendaServico)
        {
            AgendasServicos.Add(agendaServico);
        }

    }
}
