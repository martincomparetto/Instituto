using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstWeb.Models
{
    public class Alumno
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Domicilio { get; set; }

        [MaxLength(10)]
        public string Telefono { get; set; }

        [Display(Name = "Fecha Nac.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FechaNacimiento { get; set; }

        public int? DNI { get; set; }

        [Required(ErrorMessage = "Debe ingresar el legajo")]
        [MaxLength(50)]
        public string Legajo { get; set; }

        [MaxLength(200)]
        public string Localidad { get; set; }
    }
}