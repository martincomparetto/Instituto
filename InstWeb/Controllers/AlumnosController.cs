using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class AlumnosController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string nombre, string apellido, string email, string estadoCivil, int rangoEdad)
        {
            Alumno nuevoAlumno = new Alumno();
            nuevoAlumno.Nombre = nombre;
            nuevoAlumno.Apellido = apellido;
            nuevoAlumno.Email = email;
            nuevoAlumno.EstadoCivil = estadoCivil;
            nuevoAlumno.RangoEdad = rangoEdad;

            return View(nuevoAlumno);
        }
    }
}