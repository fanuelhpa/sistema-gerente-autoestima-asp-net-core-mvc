using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenteAutoestima.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ICollection<AgendaServico> AgendasServicos { get; private set; } = new List<AgendaServico>();

        public Usuario()
        {
        }
        public Usuario(int id, string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public void AdicionarAgenda(AgendaServico agendaServico)
        {
            AgendasServicos.Add(agendaServico);
        }

    }
}
