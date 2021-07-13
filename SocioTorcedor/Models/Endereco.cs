using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models
{
    public class Endereco
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

    }
}
