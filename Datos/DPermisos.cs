using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Empleados.Logica;

namespace Control_Empleados.Datos
{
    public class DPermisos
    {
        public bool InsertarPermisos(LPermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarPermisos", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdModulo", parametros.IdModulo);
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
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
        public void MostrarPermisos(ref DataTable dt, LPermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("MostrarPermisos", Conexion.sqlConexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);

                sqlDataAdapter.Fill(dt);

                Conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public bool EliminarPermisos(LPermisos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarPermisos", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
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
