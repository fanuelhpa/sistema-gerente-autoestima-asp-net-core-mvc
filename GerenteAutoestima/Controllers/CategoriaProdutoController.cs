using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenteAutoestima.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenteAutoestima.Controllers
{
    public class CategoriaProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<CategoriaProduto> categoriasProdutos = new List<CategoriaProduto>();
            categoriasProdutos.Add(new CategoriaProduto {Id=1, Nome = "Shampoo"});
            categoriasProdutos.Add(new CategoriaProduto { Id = 2, Nome = "Escova" });

            return View(categoriasProdutos);
        }
    }
}