using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenteAutoestima.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }

        public Telefone()
        {
        }

        public Telefone(int id, string numero)
        {
            Id = id;
            Numero = numero;
        }
    }
}
