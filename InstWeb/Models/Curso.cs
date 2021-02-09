using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstWeb.Models
{
    public class Curso
    {
        [Key]
        public Guid ID { get; set; }
                
        [MaxLength(200)]
        public string Denominacion { get; set; }

        public Guid ProfesorID { get; set; }

        public Profesor Profesor { get; set; }

        public List<Inscripcion> Inscripciones { get; set; }
    }
}