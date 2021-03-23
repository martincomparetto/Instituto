using InstWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstWeb.Data
{
    public class InstitutoContext : IdentityDbContext
    {
        public InstitutoContext(DbContextOptions<InstitutoContext> options) : base(options)
        {
            
        }

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Curso> Cursos { get; set; }
        
        public DbSet<Inscripcion> Inscripciones { get; set; }
        
        
    }
}
