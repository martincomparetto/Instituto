using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class AlumnosController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
    }
}