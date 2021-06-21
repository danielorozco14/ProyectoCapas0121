using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class PrestamoService
    {
        //Maybe public
        private static PrestamoDAO prestamoDAO = new PrestamoDAO();
        
        public static DataTable listAll()
        {
            return prestamoDAO.listAll();
        }

        public static DataTable listProffesorLoan(int idPersona)
        {
            return prestamoDAO.listProffesorLoans(idPersona);
        }

        public static DataTable find(string idPersona, string idLibro)
        {
            return prestamoDAO.findLoan(idPersona, idLibro);
        }

        public static string addLoan(int idPersona, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            string ifExist = prestamoDAO.ifLoanExist(idLibro, idPersona);

            if (ifExist.Equals(1))
            {
                return "El prestamo ya existe";
            }
            else
            {
                Prestamo prestamo = new Prestamo();

                prestamo.idPersona = idPersona;
                prestamo.idLibro = idLibro;
                prestamo.fechaPrestamo = fechaPrestamo;
                prestamo.fechaDevolucion = fechaDevolucion;

                return prestamoDAO.insertLoan(prestamo);
            }
        }

        public static string updateLoan(int idPersona, int idLibro, DateTime fechaPrestamo, DateTime fechaDevolucion, bool estado)
        {
            if(prestamoDAO.ifLoanExist(idLibro, idPersona).Equals(1))
            {
                Prestamo prestamo = new Prestamo();
                prestamo.idPersona = idPersona;
                prestamo.idLibro = idLibro;
                prestamo.fechaPrestamo = fechaPrestamo;
                prestamo.fechaDevolucion = fechaDevolucion;
                prestamo.estado = estado;

                return prestamoDAO.updateLoan(prestamo);
            }
            else
            {
                return "Este Prestamo no existe en la BD";
            }
        }

        public static string deleteLoan(int idLibro, int idPersona)
        {
            return prestamoDAO.deleteLoan(idLibro, idPersona);
        }

        public static string deactivateLoan(int IdLibro, int IdPersona)
        {
            return prestamoDAO.deactivateLoan(IdLibro, IdPersona);
        }


    }
}
