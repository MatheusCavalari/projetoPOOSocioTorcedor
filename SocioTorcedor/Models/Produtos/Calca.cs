using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Calca : Vestuario
    {
        public Calca(string nome, double preco)
            : base(nome, preco)
        {
        }

        public string Material { get; set; }
        public int Tamanho { get; set; }

    }
}
