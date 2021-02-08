using System;
using System.ComponentModel.DataAnnotations;

namespace InstWeb.Models
{
    public class Inscripcion
    {
        [Key]
        public Guid ID { get; set; }
        
        public Curso Curso { get; set; }
        
        public Alumno Alumno { get; set; }
    }
}