using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models.Enums;

namespace GerenteAutoestima.Models

{
    public class Funcionario
    {
        public TipoFuncionario TipoFuncionario { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<AgendaServico> AgendasServicos { get; private set; } = new List<AgendaServico>();

        public Funcionario()
        {
        }

        public Funcionario(TipoFuncionario tipoFuncionario, Usuario usuario)
        {
            TipoFuncionario = tipoFuncionario;
            Usuario = usuario;
        }

        public void AdiconarAgenda(AgendaServico agendaServico)
        {
            AgendasServicos.Add(agendaServico);
        }

    }
}
