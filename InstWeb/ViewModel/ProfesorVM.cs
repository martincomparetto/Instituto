using System;
using System.Collections.Generic;

namespace InstWeb.ViewModel
{
    public class ProfesorPaginated
    {
        public int CantidadRegistros { get; set; }
        public List<ProfesorVM> Profesores { get; set; }

    }

    public class ProfesorVM
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public string ApellidoNombre { get; set; }
    }
}