using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class AlumnosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Nombre,Apellido,Email,Domicilio,Telefono,FechaNacimiento,DNI,Legajo")] Alumno alumno)
        {
            alumno.ID = Guid.NewGuid();

            return View("Details", alumno);
        }

        public IActionResult Edit(Guid id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(IFormCollection data)
        {
            Alumno nuevoAlumno = new Alumno();
            // nuevoAlumno.Nombre = nombre;
            // nuevoAlumno.Apellido = apellido;
            // nuevoAlumno.Email = email;

            return View(nuevoAlumno);
        }
    }
}