using Microsoft.AspNetCore.Mvc;
using TAREA_semana3.Models;
using System.Collections.Generic;

namespace TAREA_semana3.Controllers
{
    public class ProductosMascotasController : Controller
    {
        private static List<ProductoMascota> productos = new List<ProductoMascota>();

        public IActionResult Index()
        {
            return View(productos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductoMascota producto)
        {
            if (ModelState.IsValid)
            {
                producto.Id = productos.Count + 1;
                productos.Add(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }
    }
}
