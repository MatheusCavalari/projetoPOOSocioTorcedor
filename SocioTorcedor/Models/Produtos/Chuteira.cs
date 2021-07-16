using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Chuteira : Produto
    {
        public Chuteira(string nome, double preco)
            : base(nome, preco)
        {
        }

        public string Cor { get; set; }
        public int Tamanho { get; set; }

    }
}
