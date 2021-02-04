using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstWeb.Data
{
    public class AlumnosData
    {
        public List<Alumno> Data = new List<Alumno>();

        public AlumnosData()
        {
            Data.Add(new Alumno() { ID = Guid.Parse("e4bf0aba-649e-4874-bd72-f5824fc03924"), Nombre = "Juan", Apellido = "Roca", DNI = 11111111, Domicilio = "Los Angeles 1522", Email = "juan.roca@gmail.com", Telefono = "123456", FechaNacimiento = new DateTime(1981, 10, 23), Legajo = "0001" });
            Data.Add(new Alumno() { ID = Guid.Parse("78364d70-4444-4739-9946-0a8475a49a40"), Nombre = "Emma", Apellido = "Goya", DNI = 55555555, Domicilio = "Los Ombues 530", Email = "emma.goya@gmail.com", Telefono = "123456", FechaNacimiento = new DateTime(1999, 6, 30), Legajo = "0002" });
            Data.Add(new Alumno() { ID = Guid.Parse("f6457e81-1c18-4374-a3ee-36a262d6f269"), Nombre = "Shara", Apellido = "Connor", DNI = 33333333, Domicilio = "Superi 5630", Email = "shara.connor@gmail.com", Telefono = "123456", FechaNacimiento = new DateTime(2005, 1, 15), Legajo = "0003" });
            Data.Add(new Alumno() { ID = Guid.Parse("24dd0462-58ee-4717-b416-b610165929c2"), Nombre = "Liz", Apellido = "Corr", DNI = 88888888, Domicilio = "Pedreda 468", Email = "liz.corr@gmail.com", Telefono = "123456", FechaNacimiento = new DateTime(1998, 3, 30), Legajo = "0004" });
        }
    }
}
