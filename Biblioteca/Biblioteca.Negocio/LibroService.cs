using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class LibroService
    {
        public static LibroDAO libroDAO = new LibroDAO();

        public static DataTable allBooks()
        {
            return libroDAO.listAll();
        }

        public static DataTable availableBooks()
        {
            return libroDAO.listAvailables();
        }

        public static DataTable findBook(string param)
        {
            return libroDAO.findBook(param);
        }

        public static DataTable findByTitle(string title)
        {
            return libroDAO.findBookByTitle(title);
        }

        public static DataTable findByAuthor(string autor)
        {
            return libroDAO.findBookByAuthor(autor);
        }

        public static string addBook(int idBook, string title, string autor, 
                            string isbm, string editorial, string anioEdicion, 
                            string numeroEdicion, string pais, string idioma,
                            string materia, int numeroPaginas, string ubicacionEstante, string descripcion)
        {
            string exists = libroDAO.ifBookExists(idBook);
            //Possible error with 1, should be "1" instead
            if (exists.Equals(1))
            {
                return "El libro ya existe en la BD";
            }
            else
            {
                Libro book = new Libro();
                book.idLibro = idBook;
                book.titulo = title;
                book.autor = autor;
                book.isbm = isbm;
                book.editorial = editorial;
                book.anioEdicion = anioEdicion;
                book.pais = pais;
                book.idioma = idioma;
                book.materia = materia;
                book.numeroPaginas = numeroPaginas;
                book.ubicacionEstante = ubicacionEstante;

                return libroDAO.addBook(book);
            }

        }

        public static string updateBook(int idBook, string title, string autor,
                          string isbm, string editorial, string anioEdicion,
                          string numeroEdicion, string pais, string idioma,
                          string materia, int numeroPaginas, string ubicacionEstante, string descripcion)
        {
            string exists = libroDAO.ifBookExists(idBook);
            //Possible error with 1, should be "1" instead
            if (exists.Equals(1))
            {
                return "El libro ya existe en la BD";
            }
            else
            {
                Libro book = new Libro();
                book.idLibro = idBook;
                book.titulo = title;
                book.autor = autor;
                book.isbm = isbm;
                book.editorial = editorial;
                book.anioEdicion = anioEdicion;
                book.pais = pais;
                book.idioma = idioma;
                book.materia = materia;
                book.numeroPaginas = numeroPaginas;
                book.ubicacionEstante = ubicacionEstante;

                return libroDAO.updateBook(book);
            }

        }


        public static string deleteBook(int idBook)
        {
            return libroDAO.deleteBook(idBook);
        }

        public static string activateBook(int idBook)
        {
            return libroDAO.activateBook(idBook);
        }

        public static string deactivateBook(int idBook)
        {
            return libroDAO.deactivateBook(idBook);
        }

    }
}
