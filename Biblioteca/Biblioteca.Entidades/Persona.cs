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
        int idPersona { get; set; }
        string email { get; set; }
        string password { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        int edad { get; set; }
        string telefono { get; set; }
        int idRol { get; set; }

        public Persona() {}

    }
}
