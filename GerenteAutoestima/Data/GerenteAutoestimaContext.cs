using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GerenteAutoestima.Models
{
    public class GerenteAutoestimaContext : DbContext
    {
        public GerenteAutoestimaContext (DbContextOptions<GerenteAutoestimaContext> options)
            : base(options)
        {
        }

        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
