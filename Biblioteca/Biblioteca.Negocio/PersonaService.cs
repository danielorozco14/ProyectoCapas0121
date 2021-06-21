using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    class PersonaService
    {
        private static PersonaDAO personaDAO = new PersonaDAO();

        public static DataTable listAll()
        {
            return personaDAO.listAll();
        }

        public static DataTable find(string paramm)
        {
            return personaDAO.findPerson(paramm);
        }

        public static string insert(string nombre, string apellido, string telefono, int edad)
        {
            if(personaDAO.ifExist(nombre, apellido).Equals(1))
            {
                return "Esta Persona ya existe en la BD";
            }
            else
            {
                Persona persona = new Persona();
                persona.nombre = nombre;
                persona.apellido = apellido;
                persona.telefono = telefono;
                persona.edad = edad;
                
                return personaDAO.addPerson(persona);
            }
        }

        public static string update(int id, string nombre, string apellido, string telefono, int edad)
        {

            if (personaDAO.ifExist(nombre, apellido).Equals(1))
            {
                Persona persona = new Persona();
                persona.nombre = nombre;
                persona.apellido = apellido;
                persona.telefono = telefono;
                persona.edad = edad;

                return personaDAO.updatePerson(persona);
            }
            else
            {
                return "Esta Persona no ha sido encontrada y no se pudo actualizar";
            }
        }

        public static string delete(int idPersona)
        {
            return personaDAO.deletePerson(idPersona);
        }

        public DataTable login(string email, string passw)
        {
            return personaDAO.login(email, passw);
        }


    }
}
