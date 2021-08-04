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
            produtos.Add(new Camiseta("Camiseta Social esportiva", 80));
            produtos.Add(new Camiseta("Camiseta Regata - NBA", 70));

            return View(produtos);
        }

        public IActionResult Chuteiras()
        {
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Chuteira("Chuteira Nike", 200));
            produtos.Add(new Chuteira("Chuteira Adidas", 250));
            produtos.Add(new Chuteira("Chuteira Puma", 300));
            produtos.Add(new Chuteira("Chuteira Kappa", 150));

            return View(produtos);
        }
    }
}
