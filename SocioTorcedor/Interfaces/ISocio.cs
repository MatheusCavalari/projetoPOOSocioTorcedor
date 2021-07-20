using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Interfaces
{
    interface ISocio
    {
        Produto DescontoCompra(Produto produto);
    }
}
