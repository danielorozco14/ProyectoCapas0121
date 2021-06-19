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
    class LibroDAO
    {
        public DataTable listAll()
        {
            SqlDataReader Result;
            DataTable table = new DataTable();

            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("libro_listar", sqlConnection);
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

        public string insertLibro(Libro libro)
        {
            string response = "";
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection = Conexion.getInstance().createConnection();
                SqlCommand sqlCommand = new SqlCommand("libro_insertar", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                
                sqlCommand.Parameters.Add("@isbm", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@titulo", SqlDbType.VarChar).Value = libro.isbm;

                sqlCommand.Parameters.Add("@autor", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@editorial", SqlDbType.VarChar).Value = libro.isbm;

                sqlCommand.Parameters.Add("@anioEdicion", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@numeroEdicion", SqlDbType.VarChar).Value = libro.isbm;

                sqlCommand.Parameters.Add("@pais", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@idioma", SqlDbType.VarChar).Value = libro.isbm;

                sqlCommand.Parameters.Add("@materia", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@numeroPaginas", SqlDbType.VarChar).Value = libro.isbm;

                sqlCommand.Parameters.Add("@ubicacionEstante", SqlDbType.VarChar).Value = libro.isbm;
                sqlCommand.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = libro.isbm;

            }

        }
    }
}
