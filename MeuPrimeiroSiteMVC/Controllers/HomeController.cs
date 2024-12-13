using MeuPrimeiroSiteMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuPrimeiroSiteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // ação
        {
            return View(); // se nada for definido, retorna a view de mesmo nome da ação, da subpasta com mesmo nome do CONTROLLER dentro da pasta VIEW.
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
