using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenteAutoestima.Models
{
    public class CategoriaProduto
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> produtos { get; private set; } = new List<Produto>();

        public CategoriaProduto() { }
        public CategoriaProduto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            produtos.Remove(produto);
        }

    }
}
