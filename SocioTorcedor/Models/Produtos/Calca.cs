using SocioTorcedor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class Calca : Vestuario, IProduto
    {
        public Calca(string nome, double preco)
            : base(nome, preco)
        {
        }

        public string Material { get; set; }
        public int Tamanho { get; set; }

        public void RegistrarSaida(Produto calca)
        {
            if(calca.Quantidade > 0)
            {
                calca.Quantidade--;
            }
            else
            {
                throw new ArgumentNullException("O produto está indisponível");
            }
        }
    }
}
