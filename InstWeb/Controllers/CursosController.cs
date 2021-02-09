using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstWeb.Data;
using InstWeb.Models;

namespace InstWeb.Controllers
{
    public class CursosController : Controller
    {
        private readonly InstitutoContext _context;

        public CursosController(InstitutoContext context)
        {
            _context = context;
        }

        // GET: Cursos
        public async Task<IActionResult> Index()
        {
            var institutoContext = await _context.Cursos.Include(c => c.Profesor).ToListAsync();
            
            institutoContext = institutoContext.OrderBy(o => o.Denominacion).ToList();
            
            return View(institutoContext);
        }

        // GET: Cursos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Profesor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // GET: Cursos/Create
        public IActionResult Create()
        {
            ViewData["ProfesorID"] = new SelectList(_context.Profesores, "ID", "ApellidoNombre");
            return View();
        }

        // POST: Cursos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Denominacion,ProfesorID")] Curso curso)
        {
            if (ModelState.IsValid)
            {
                curso.ID = Guid.NewGuid();
                _context.Add(curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfesorID"] = new SelectList(_context.Profesores, "ID", "ApellidoNombre", curso.ProfesorID);
            return View(curso);
        }

        // GET: Cursos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }
            ViewData["ProfesorID"] = new SelectList(_context.Profesores, "ID", "ApellidoNombre", curso.ProfesorID);
            return View(curso);
        }

        // POST: Cursos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Denominacion,ProfesorID")] Curso curso)
        {
            if (id != curso.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CursoExists(curso.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfesorID"] = new SelectList(_context.Profesores, "ID", "ApellidoNombre", curso.ProfesorID);
            return View(curso);
        }

        // GET: Cursos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var curso = await _context.Cursos
                .Include(c => c.Profesor)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (curso == null)
            {
                return NotFound();
            }

            return View(curso);
        }

        // POST: Cursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CursoExists(Guid id)
        {
            return _context.Cursos.Any(e => e.ID == id);
        }
    }
}
