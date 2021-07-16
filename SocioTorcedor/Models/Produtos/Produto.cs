using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public abstract class Produto
    {
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public double Desconto { get; set; }
        public double Descricao { get; set; }
    }
}
