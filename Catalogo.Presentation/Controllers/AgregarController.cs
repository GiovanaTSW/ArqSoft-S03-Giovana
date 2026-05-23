using Microsoft.AspNetCore.Mvc;

namespace CatalogoApp.Presentation.Controllers
{
    public class AgregarController : Controller
    {
        // GET /Agregar/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST /Agregar/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Por favor completa todos los campos.";
                return View();
            }

            return RedirectToAction("Index", "Catalogo");
        }

        // GET /Agregar/Registro
        public IActionResult Registro()
        {
            return View();
        }

        // POST /Agregar/Registro
        [HttpPost]
        public IActionResult Registro(string nombre, string email, string password)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Por favor completa todos los campos.";
                return View();
            }

            return RedirectToAction("Login");
        }
    }
}