using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocioTorcedor.Models;
using SocioTorcedor.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ingressos()
        {
            List<Ingresso> produtos = new List<Ingresso>();

            produtos.Add(new Ingresso("Futebol", 40));
            produtos.Add(new Ingresso("Basquete", 50));
            produtos.Add(new Ingresso("Futebol", 40));
            produtos.Add(new Ingresso("Basquete", 50));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
