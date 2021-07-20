using SocioTorcedor.Interfaces;
using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models
{
    public class ClienteSocioSilver : Cliente, ISocio
    {
        public ClienteSocioSilver(string nome, string sobrenome, int idade)
            : base(nome, sobrenome, idade)        
        {
            lista = new List<Produto>();
        }

        public Produto DescontoCompra(Produto produto)
        {
            produto.Preco *= 0.9;
            return produto;
        }
    }
}
