using SocioTorcedor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Camiseta : Vestuario, IProduto
    {
        public Camiseta(string nome, double preco)
            : base(nome, preco)
        {
        }

        public string Modelo { get; set; }
        public string Tecido { get; set; }
        public string Tamanho { get; set; }

        public void RegistrarSaida(Produto camiseta)
        {
            if (camiseta.Quantidade > 0)
            {
                camiseta.Quantidade--;
            }
            else
            {
                throw new ArgumentNullException("O produto está indisponível");
            }
        }
    }
}
