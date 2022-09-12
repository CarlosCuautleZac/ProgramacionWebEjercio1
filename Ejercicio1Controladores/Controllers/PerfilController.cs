using Ejercicio1Controladores.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1Controladores.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Datos(PerfilViewModel datos)
        {
            if (string.IsNullOrWhiteSpace(datos.Nombre))
                return RedirectToAction("Index");

            return View(datos);
        }
    }
}
