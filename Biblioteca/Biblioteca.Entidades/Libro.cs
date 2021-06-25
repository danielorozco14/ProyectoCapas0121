using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string isbm { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public DateTime anioEdicion { get; set; }
        public string numeroEdicion { get; set; }
        public string pais { get; set; }
        public string idioma { get; set; }
        public string materia { get; set; }
        public int numeroPaginas { get; set; }
        public string ubicacionEstante { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

    }
}
