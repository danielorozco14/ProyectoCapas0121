using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    class Prestamo
    {
        int idPersona { get; set; }
        int idLibro { get; set; }
        DateTime fechaPrestamo { get; set; }
        DateTime fechaDevolucion { get; set; }
        bool estado { get; set; }


    }
}
