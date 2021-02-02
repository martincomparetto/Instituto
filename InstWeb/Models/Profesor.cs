using System;
using System.Collections.Generic;

public class Profesor
{
    public Guid ID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Domicilio { get; set; }
    public string Telefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int DNI { get; set; }
    public List<Curso> Cursos { get; set; }
}