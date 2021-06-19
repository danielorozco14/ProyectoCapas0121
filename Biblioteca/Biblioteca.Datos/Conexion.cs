using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Datos
{
    public class Conexion
    {

        private string dbName;
        private string dbServerAddress;
        private string dbUser;
        private string dbPassword;
        private bool authenticationMode;

        private static Conexion connection = null;

        private Conexion()
        {
            this.dbName = "ProyectoCapas";
            this.dbServerAddress = "127.0.0.1";
            //If true, uses Windows Authentication for Sql Server
            this.authenticationMode = true;
        }

        public SqlConnection createConnection()
        {
            SqlConnection connectionString = new SqlConnection();
            try
            {
                connectionString.ConnectionString = "Server=" + this.dbServerAddress +
                        "; Database=" + this.dbName + ";";
                if (this.authenticationMode)
                {
                    connectionString.ConnectionString = connectionString.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    connectionString.ConnectionString = connectionString.ConnectionString +
                            "User Id=" + this.dbUser + "; Password=" + this.dbPassword;
                }
            }
            catch (Exception e)
            {
                connectionString = null;
                throw e;
            }
            return connectionString;
        }


        public static Conexion getInstance()
        {
            if (connection == null)
                connection = new Conexion();
            return connection;
        }

    }

}

