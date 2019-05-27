using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenteAutoestima.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeDisponivel { get; private set; }
        public CategoriaProduto CategoriaProduto { get; set; }

        public Produto() { }
        public Produto(int id, string nome, double preco, int quantidadeDisponivel, CategoriaProduto categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            QuantidadeDisponivel = quantidadeDisponivel;
            CategoriaProduto = categoria;
        }

        public void AdicionarQuantidade(int quantidade)
        {
            QuantidadeDisponivel += quantidade;
        }
        public void RemoverQuantidade(int quantidade)
        {
            QuantidadeDisponivel -= quantidade;
        }
    }
}
