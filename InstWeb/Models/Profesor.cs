using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstWeb.Models
{
    public class Profesor
    {
        [Key]
        public Guid ID { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(200)]
        public string Domicilio { get; set; }
        [MaxLength(50)]
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DNI { get; set; }

        [NotMapped]
        public string ApellidoNombre 
        { 
            get
            {
                return Apellido + ", " + Nombre;
            }
        }
    }
}