using Microsoft.AspNetCore.Mvc;

namespace Porumb_Denisa_Lab1.Controllers
{
    public class exercitiul3 : Controller
    {
        public IActionResult Index()
        {
     
            return View();
        }
        
        [Route("hello")]
        public string Hello() => "Salut!";

       
        [HttpGet("hello/{name}")]
        public string HelloByName(string name) => $"Salut, {name}!";

        
        [HttpGet("calc/{a:int}/{b:int}")]
        public string Calculate(int a, int b) => $"Suma este: {a + b}";
    }
}
