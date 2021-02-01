using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class ProfesoresController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
    }
}