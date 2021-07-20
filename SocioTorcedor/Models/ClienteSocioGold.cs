using SocioTorcedor.Interfaces;
using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models
{
    public class ClienteSocioGold : Cliente, ISocio
    {
        public ClienteSocioGold(string nome, string sobrenome, int idade)
            : base(nome, sobrenome, idade)        
        {
            lista = new List<Produto>();
        }

        public Produto DescontoCompra(Produto produto)
        {
            produto.Preco *= 0.8;
            return produto;
        }
    }
}
