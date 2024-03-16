using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Control_Empleados.Logica;

namespace Control_Empleados.Datos
{
    public class DModulos
    {
        public bool InsertarModulos(LModulo parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarModulos", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Modulo", parametros.Modulo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
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
