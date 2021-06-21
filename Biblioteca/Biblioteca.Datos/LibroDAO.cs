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
    public class LibroDAO
    {
        public DataTable listAll()
        {
            SqlDataReader Result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("all_books", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                Result = sqlCommand.ExecuteReader();
                table.Load(Result);

                return table;
            
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }

        }

        public DataTable listAvailables()
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("get_book_state_asTrue", sqlConnection);

                sqlConnection.Open();

                result = sqlCommand.ExecuteReader();

                table.Load(result);

                return table;
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public DataTable findBook(string param)
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("find_book", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.VarChar).Value = param;

                sqlConnection.Open();

                result = sqlCommand.ExecuteReader();
                table.Load(result);

                return table;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
        }

        public DataTable findBookByTitle(string title)
        {
            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("find_book_by_title", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.VarChar).Value = title;

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

        public DataTable findBookByAuthor(string author)
        {

            SqlDataReader result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("find_book_by_author", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.VarChar).Value = author;

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

        public string ifBookExists(int idBook)
        {

            string result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("book_existence", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@paramm", SqlDbType.Int).Value = idBook;

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
        
        public string addBook(Libro book)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("add_book", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                sqlCommand.Parameters.Add("@isbm", SqlDbType.VarChar).Value = book.isbm;
                sqlCommand.Parameters.Add("@titulo", SqlDbType.VarChar).Value = book.titulo;

                sqlCommand.Parameters.Add("@autor", SqlDbType.VarChar).Value = book.autor;
                sqlCommand.Parameters.Add("@editorial", SqlDbType.VarChar).Value = book.editorial;

                sqlCommand.Parameters.Add("@anioEdicion", SqlDbType.Date).Value = book.anioEdicion;
                sqlCommand.Parameters.Add("@numeroEdicion", SqlDbType.VarChar).Value = book.numeroEdicion;

                sqlCommand.Parameters.Add("@pais", SqlDbType.VarChar).Value = book.pais;
                sqlCommand.Parameters.Add("@idioma", SqlDbType.VarChar).Value = book.idioma;

                sqlCommand.Parameters.Add("@materia", SqlDbType.VarChar).Value = book.materia;
                sqlCommand.Parameters.Add("@numeroPaginas", SqlDbType.Int).Value = book.numeroPaginas;

                sqlCommand.Parameters.Add("@ubicacionEstante", SqlDbType.VarChar).Value = book.ubicacionEstante;
                sqlCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = book.descripcion;

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Libro agregado" : "No se pudo agregar el libro";


            }catch(Exception e)
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

        public string updateBook(Libro book)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("update_book", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                //Comando.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@IdLibro", SqlDbType.Int).Value = book.idLibro;
                sqlCommand.Parameters.Add("@isbm", SqlDbType.VarChar).Value =book.isbm;
                sqlCommand.Parameters.Add("@titulo", SqlDbType.VarChar).Value =book.titulo;
                sqlCommand.Parameters.Add("@autor", SqlDbType.VarChar).Value =book.autor;
                sqlCommand.Parameters.Add("@editorial", SqlDbType.VarChar).Value =book.editorial;
                sqlCommand.Parameters.Add("@anioEdicion", SqlDbType.VarChar).Value =book.anioEdicion;
                sqlCommand.Parameters.Add("@numeroEdicion", SqlDbType.VarChar).Value = book.numeroEdicion;
                sqlCommand.Parameters.Add("@pais", SqlDbType.VarChar).Value =book.pais;
                sqlCommand.Parameters.Add("@idioma", SqlDbType.VarChar).Value =book.idioma;
                sqlCommand.Parameters.Add("@materia", SqlDbType.VarChar).Value = book.materia;
                sqlCommand.Parameters.Add("@numeroPaginas", SqlDbType.VarChar).Value =book.numeroPaginas;
                sqlCommand.Parameters.Add("@UbicacionEstante", SqlDbType.VarChar).Value = book.ubicacionEstante;
                sqlCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value =book.descripcion;
                
                //Possible error
                sqlCommand.Parameters.Add("@estado", SqlDbType.Bit).Value = book.estado;

                sqlConnection.Open();
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Libro Actualizado" : "No se pudo actualizar el registro";

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

        public string deleteBook(int idBook)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("delete_book", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@idlibro", SqlDbType.Int).Value = idBook;
                
                sqlConnection.Open();
                
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Libro Eliminado" : "No se pudo eliminar el registro";

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

        public string activateBook(int idBook)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("activate_book", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdLibro", SqlDbType.Int).Value = idBook;
                
                sqlConnection.Open();
                
                result = sqlCommand.ExecuteNonQuery() == 1 ? "Libro Activado" : "No se pudo activar el libro";

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

        public string deactivateBook(int idBook)
        {
            string result = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("deactivate_book", sqlConnection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdLibro", SqlDbType.Int).Value = idBook;

                sqlConnection.Open();

                result = sqlCommand.ExecuteNonQuery() == 1 ? "Libro Desactivado" : "No se pudo desactivar el libro";

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
