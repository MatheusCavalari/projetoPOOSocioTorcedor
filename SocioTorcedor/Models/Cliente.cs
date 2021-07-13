using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models
{
    public class Cliente : Endereco
    {
        public Cliente(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}

