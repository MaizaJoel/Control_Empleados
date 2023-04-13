using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Control_Empleados.Datos
{
    public class DModulos
    {
        public void MostrarModulos(ref DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Modulos", Conexion.sqlConexion);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace); 
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
