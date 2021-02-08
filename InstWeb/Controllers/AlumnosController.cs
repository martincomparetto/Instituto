using System;
using System.Collections.Generic;
using System.Linq;
using InstWeb.Data;
using InstWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstWeb.Controllers
{
    public class AlumnosController : Controller
    {
        private InstitutoContext _context;
        
        public AlumnosController(InstitutoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Alumno> alumnos = _context.Alumnos;
            return View(alumnos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar([Bind("Nombre,Apellido,Email,Domicilio,Telefono,FechaNacimiento,DNI,Legajo")] Alumno alumno)
        {
            alumno.ID = Guid.NewGuid();
            
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();

            return View("Details", alumno);
        }

        public IActionResult Edit(Guid id)
        {
            Alumno alumnoEditar = _context.Alumnos.Find(id);
            return View(alumnoEditar);
        }

        [HttpPost]
        public IActionResult Edit([Bind("ID,Nombre,Apellido,Email,Domicilio,Telefono,FechaNacimiento,DNI,Legajo")] Alumno alumno)
        {
            _context.Alumnos.Update(alumno);
            _context.SaveChanges();

            return View(alumno);
        }
    }
}