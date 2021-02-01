using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "Metodo Index()";
        }

        public IActionResult Mensaje(int id)
        {
            ViewData["Titulo"] = "Mostramos: ";
            ViewBag.Mensaje = "Mensaje a mostrar";
            ViewBag.Repeticion = id;
            return View();
        }

        public string MostrarId(int id)
        {
            return "El ID es " + id.ToString();
        }

        public IActionResult Saludar(string nombre, string apellido)
        {
            string saludo = $"Hola {nombre} {apellido} ";
            return View("Hola", saludo);
        }
    }
}