using Microsoft.AspNetCore.Mvc;

namespace MeuPrimeiroSiteMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
