using Microsoft.AspNetCore.Mvc;
using SocioTorcedor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocioTorcedor.Controllers
{
    public class ClienteController : Controller
    {
        
        public IActionResult Index()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(new Cliente("João", "Silva", 25));
            clientes[0].Estado = "SP";
            clientes.Add(new Cliente("Fernanda", "Gomes", 21));
            clientes[1].Estado = "RJ";

            return View(clientes);
        }
    }
}

