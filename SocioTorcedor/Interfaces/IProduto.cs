using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Interfaces
{
    interface IProduto
    {
        //bool Disponível { get; set; }
        void RegistrarSaida(Produto produto);
    }
}
