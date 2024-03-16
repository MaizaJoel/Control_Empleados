using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Control_Empleados.Datos
{
    public class Conexion
    {
        public static string conexion = Convert.ToString(Logica.Desencriptacion.checkServer());
        public static SqlConnection sqlConexion = new SqlConnection(conexion);

        public static void abrir()
        {
            if(sqlConexion.State == ConnectionState.Closed)
            {
                sqlConexion.Open();
            }
        }

        public static void cerrar()
        {
            if (sqlConexion.State == ConnectionState.Open)
            {
                sqlConexion.Close();
            }
        }
    }
}
