using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GerenteAutoestima.Models
{
    public class GerenteAutoestimaContext : DbContext
    {
        public GerenteAutoestimaContext(DbContextOptions<GerenteAutoestimaContext> options)
            : base(options)
        {
        }

        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<AgendaServico> AgendaServico { get; set; }
        public DbSet<Funcionario> Funcionario {get; set;}
        public DbSet<CategoriaServico> CategoriaServico { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

    }
}
