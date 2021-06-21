using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class PersonaDAO
    {

        public DataTable listAll()
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("all_persons", sqlConnection);

                sqlConnection.Open();

                result = sqlCommand.ExecuteReader();
                table.Load(result);

                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public DataTable findPerson(string paramm)
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("find_person", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.VarChar).Value = paramm;

                sqlConnection.Open();

                result = sqlCommand.ExecuteReader();
                table.Load(result);

                return table;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public string ifExist(string nombre, string apellido)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand Comando = new SqlCommand("if_person_exists", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("@paramm", SqlDbType.VarChar).Value = nombre;
                Comando.Parameters.Add("@paramm1", SqlDbType.VarChar).Value = apellido;
                
                SqlParameter ifExists = new SqlParameter();
                ifExists.ParameterName = "@exist";
                ifExists.SqlDbType = SqlDbType.Int;
                ifExists.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ifExists);

                sqlConnection.Open();
                Comando.ExecuteNonQuery();
                
                result = Convert.ToString(ifExists.Value);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return result;
        }

        public String addPerson(Persona persona)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("add_person", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = persona.nombre;
                sqlCommand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = persona.apellido;
                sqlCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = persona.telefono;
                sqlCommand.Parameters.Add("@edad", SqlDbType.Int).Value = persona.edad;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = persona.email;
                sqlCommand.Parameters.Add("@clave", SqlDbType.VarChar).Value = persona.password;

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Persona Agregada" : "No se pudo ingresar la persona";

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return result;
        }

        public string updatePerson(Persona persona)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("update_person", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idcpersona", SqlDbType.VarChar).Value = persona.idPersona;
                sqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = persona.nombre;
                sqlCommand.Parameters.Add("@apellido", SqlDbType.VarChar).Value = persona.apellido;
                sqlCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = persona.telefono;
                sqlCommand.Parameters.Add("@edad", SqlDbType.Int).Value = persona.edad;
                
                sqlConnection.Open();
                
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Persona Actualizada" : "No se pudo actualizar la persona";

            }
            catch (Exception e )
            {
                result = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return result;
        }

        public string deletePerson(int idPersona)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("delete_person", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idpersona", SqlDbType.Int).Value = idPersona;
                
                sqlConnection.Open();
                
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Persona Eliminada" : "No se pudo eliminar la persona";

            }
            catch (Exception e)
            {
                result = e.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            return result;
        }

        public DataTable login(string Email, string Clave)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                
                SqlCommand sqlCommand = new SqlCommand("login_person", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = Email;
                sqlCommand.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave;
                
                sqlConnection.Open();
                
                result = sqlCommand.ExecuteReader();
                
                table.Load(result);
                
                return table;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) 
                    sqlConnection.Close();
            }
        }

    }
}
