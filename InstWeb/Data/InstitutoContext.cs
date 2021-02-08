using InstWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace InstWeb.Data
{
    public class InstitutoContext : DbContext
    {
        public InstitutoContext(DbContextOptions<InstitutoContext> options) : base(options)
        {
            
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //             => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Instituto;Integrated Security=SSPI");

        public DbSet<Alumno> Alumnos { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Curso> Cursos { get; set; }
        
        public DbSet<Inscripcion> Inscripciones { get; set; }
        
        
    }
}
