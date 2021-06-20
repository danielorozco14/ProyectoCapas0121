using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        public int idPersona { get; set; }
        public int idLibro { get; set; }
        public DateTime fechaPrestamo { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public bool estado { get; set; }


    }
}
