using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1Controladores.Controllers
{
    public class TablasController : Controller
    {
        public IActionResult Index(int id)
        {
            return View(id);
        }
    }
}
