using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Persona
    {
        //If fails, check DB definition on table Persona
        public int idPersona { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string telefono { get; set; }
        public int idRol { get; set; }

        public bool estado { get; set; }

        public Persona() {}

    }
}
