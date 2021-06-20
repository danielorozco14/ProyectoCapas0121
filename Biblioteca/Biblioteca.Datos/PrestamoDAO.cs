using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Biblioteca.Entidades;


namespace Biblioteca.Datos
{
    class PrestamoDAO
    {
        public DataTable listAll()
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("list_loans", sqlConnection);

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

        public DataTable listProffesorLoans(int idProfesor)
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                
                SqlCommand sqlCommand = new SqlCommand("list_proffesor_loans", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.Int).Value = idProfesor;

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

        public DataTable findLoan(string idPersona, string idLibro)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("find_loan", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm1", SqlDbType.VarChar).Value = idPersona;
                sqlCommand.Parameters.Add("@paramm2", SqlDbType.VarChar).Value = idLibro;

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

        public string ifLoanExist(int idBook, int idPersona)
        {

            string result = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();

                SqlCommand sqlCommand = new SqlCommand("if_loan_exist", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm1", SqlDbType.VarChar).Value = idPersona;
                sqlCommand.Parameters.Add("@paramm2", SqlDbType.VarChar).Value = idBook;

                SqlParameter ifExist = new SqlParameter();

                ifExist.ParameterName = "@exists";
                ifExist.SqlDbType = SqlDbType.Int;
                ifExist.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(ifExist);

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
                result = Convert.ToString(ifExist.Value);
                
               
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

        public string insertLoan(Prestamo prestamo)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("add_loan", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idPersona", SqlDbType.Int).Value = prestamo.idPersona;
                sqlCommand.Parameters.Add("@idLibro", SqlDbType.Int).Value = prestamo.idLibro;
                sqlCommand.Parameters.Add("@fechaPrestamo", SqlDbType.DateTime).Value = prestamo.fechaPrestamo;
                sqlCommand.Parameters.Add("@fechaDevolucion", SqlDbType.DateTime).Value = prestamo.fechaDevolucion;


                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Prestamo Realizado" : "No se pudo realizar el prestamo";

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

        public string updateLoan(Prestamo prestamo)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("update_book", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idPersona", SqlDbType.Int).Value = prestamo.idPersona;
                sqlCommand.Parameters.Add("@idLibro", SqlDbType.Int).Value = prestamo.idLibro;
                sqlCommand.Parameters.Add("@fechaPrestamo", SqlDbType.DateTime).Value = prestamo.fechaPrestamo;
                sqlCommand.Parameters.Add("@fechaDevolucion", SqlDbType.DateTime).Value = prestamo.fechaDevolucion;
                
                //Probably error
                sqlCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = prestamo.estado;

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Prestamo de libro realizado" : "No se pudo actualizar el prestamo del libro";

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

        public string deleteLoan(int idBook, int idPersona)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("delete_loan", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;


                sqlCommand.Parameters.Add("@idlibro", SqlDbType.Int).Value = idBook;
                sqlCommand.Parameters.Add("@idpersona", SqlDbType.Int).Value = idPersona;


                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Prestamo de libro eliminado" : "No se pudo eliminar el prestamo del libro";

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

        public string deactivateLoan(int idBook, int idPersona)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand Comando = new SqlCommand("deactivate_loan", sqlConnection);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = idBook;
                Comando.Parameters.Add("@IdPersona", SqlDbType.Int).Value = idPersona;
                sqlConnection.Open();
                result = Comando.ExecuteNonQuery() == 1 ? "Prestamo desactivado correctamente" : "No se pudo desactivar el prestamo";

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
    }
}
