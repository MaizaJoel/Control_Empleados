using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Control_Empleados.Logica;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Control_Empleados.Datos
{
    public class DCopiasDeSeguridad
    {
        public bool InsertarCopiasDeSeguridad()
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarCopiasDeSeguridad", Conexion.sqlConexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void MostrarRuta(ref string ruta)
        {
            try
            {
                Conexion.abrir();
                SqlCommand sqlCommand = new SqlCommand("Select Ruta from CopiasDeSeguridad", Conexion.sqlConexion);
                ruta = Convert.ToString(sqlCommand.ExecuteScalar());
                Conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public bool EditarCopiasDeSeguridad(LCopiasDeSeguridad parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EditarCopiasBd", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ruta", parametros.Ruta);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
