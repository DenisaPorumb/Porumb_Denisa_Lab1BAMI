using Microsoft.AspNetCore.Mvc;
using Porumb_Denisa_Lab1.Models;
using System.Diagnostics;

namespace Porumb_Denisa_Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "buna";
        }
        public string metoda()
        {
            return "salut";
        }

        public string Exercitiu( string nume, int varsta)
        {
            return "numele este" + nume + "si varsta este" + varsta;
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
