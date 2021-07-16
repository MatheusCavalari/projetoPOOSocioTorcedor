using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Models.Produtos
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Camiseta("Camiseta Oficial do Mauá FC", 40));
            produtos.Add(new Camiseta("Camiseta Oficial do Zaíra FC", 50));

            return View(produtos);
        }
    }
}
