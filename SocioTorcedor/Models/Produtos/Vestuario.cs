using SocioTorcedor.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public abstract class Vestuario : Produto
    {
        public Vestuario(string nome, double preco)
            :base(nome, preco)
        {
        }

        public string Cor { get; set; }
        public PublicoAlvo PublicoAlvo { get; set; }
        public string Marca { get; set; }
    }
}
