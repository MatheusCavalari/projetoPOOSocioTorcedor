using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Camiseta : Vestuario
    {
        public Camiseta(string nome, double preco)
            : base(nome, preco)
        {
        }

        public string Modelo { get; set; }
        public string Tecido { get; set; }
        public string Tamanho { get; set; }
    }
}
