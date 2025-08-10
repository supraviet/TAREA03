using Microsoft.AspNetCore.Mvc;
using TAREA_semana3.Models;

namespace TAREA_semana3.Controllers
{
    public class MascotasController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmacion", mascota);
            }

            return View(mascota);
        }

        [HttpGet]
        public IActionResult Confirmacion(Mascota mascota)
        {
            return View(mascota);
        }
    }
}
