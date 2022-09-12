using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1Controladores.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pagina2()
        {
            return View();
        }

        public string Saludame(string nombre)
        {
            return "Hola " + nombre;
        }

        public int Suma(int x, int y)
        {
            return x + y;
        }
    }
}
