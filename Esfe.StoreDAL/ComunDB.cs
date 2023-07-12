using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Esfe.StoreDAL
{
    public class ComunDB
    {
        //---Se coloca el link de conexion en una constante
        const string StrConexion = @"";

        //----Establecemos la conexion con SQL
        private static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(StrConexion);
            connection.Open();
            return connection;
        }
        public static SqlCommand ObtenerComando()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ObtenerConexion();
            return command;
        }
        public static int EjecutarComando(SqlCommand pComando)
        {
            int resultado = pComando.ExecuteNonQuery();
            pComando.Connection.Close();
            return resultado;
        }
        public static SqlDataReader EjecutarComandoReader(SqlCommand pComando)
        {
            SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
