using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models
{
    public class Cliente : Endereco
    {
        public List<Produto> lista;
        public Cliente(string nome, string sobrenome, int idade)
        {
            lista = new List<Produto>();
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public List<Produto> Compra(Produto produto)
        {
            lista.Add(produto);
            
            return lista;
        }
    }
}

