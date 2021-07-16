using SocioTorcedor.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Ingresso: Produto
    {
        public Ingresso(string nome, double preco)
            : base(nome, preco)
        {
        }

        public Esporte Esporte { get; set; }
        public string LocalCadeira { get; set; }

    }
}
