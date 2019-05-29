using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenteAutoestima.Models
{
    public class CategoriaServico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Servico> Servicos { get; private set; } = new List<Servico>();

        public CategoriaServico() { }
        public CategoriaServico(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarServico(Servico servico)
        {
            Servicos.Add(servico);
        }
    }
}
