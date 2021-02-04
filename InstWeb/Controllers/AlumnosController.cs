using System;
using System.Collections.Generic;
using InstWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class AlumnosController : Controller
    {
        private AlumnosData alumnosData;
        public AlumnosController(AlumnosData alumnosData)
        {
            this.alumnosData = alumnosData;
        }

        public IActionResult Index()
        {
            return View(alumnosData.Data);
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
            Alumno editAlumno = alumnosData.Data.Find(c => c.ID == id);
            return View(editAlumno);
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