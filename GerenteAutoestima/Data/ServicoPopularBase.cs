using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models;

namespace GerenteAutoestima.Data
{
    public class ServicoPopularBase
    {
        private GerenteAutoestimaContext _context;

        public ServicoPopularBase(GerenteAutoestimaContext context)
        {
            _context = context;
        }

        public void Popular()
        {
            if (_context.CategoriaProduto.Any() || _context.Produto.Any())
            {
                return; //O banco de dados já foi populado
            }

            //Categorias de produtos
            CategoriaProduto catProd1 = new CategoriaProduto(1, "Shampoo");
            CategoriaProduto catProd2 = new CategoriaProduto(2, "Condicionador");
            CategoriaProduto catProd3 = new CategoriaProduto(3, "Alisante");
            CategoriaProduto catProd4 = new CategoriaProduto(4, "Pente");

            //Produtos
            Produto prod1 = new Produto(1, "Seda Ceramidas", 10.00, 5, catProd1);
            Produto prod2 = new Produto(2, "Palmolive", 9.00, 8, catProd1);
            Produto prod3 = new Produto(3, "Seda Ceramidas", 8.00, 6, catProd2);
            Produto prod4 = new Produto(4, "Salon Line", 15.00, 9, catProd3);
            Produto prod5 = new Produto(5, "Hair Life", 12.00, 4, catProd4);

            //adiciona os objetos criados nas tabelas
            _context.CategoriaProduto.AddRange(catProd1, catProd2, catProd3, catProd4);
            _context.Produto.AddRange(prod1, prod2, prod3, prod4, prod5);

            //efetiva as alterações
            _context.SaveChanges();

        }
    }
}
