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
    public class DUsuarios
    {
		public bool InsertarUsuarios(LUsuarios parametros)
		{
			try
			{
				Conexion.abrir();
				SqlCommand cmd = new SqlCommand("InsertarUsuario", Conexion.sqlConexion);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombres", parametros.NombreApellido);
				cmd.Parameters.AddWithValue("@Login", parametros.Login);
				cmd.Parameters.AddWithValue("@Password", parametros.Password);
				cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
				cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
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
		public void MostrarUsuarios(ref DataTable dt)
		{
			try
			{
				Conexion.abrir();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Usuarios", Conexion.sqlConexion);
				sqlDataAdapter.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				Conexion.cerrar();
			}
		}
		public void ObtenerUsuario(ref int IdUsuario, string Login)
        {
            try
            {
				Conexion.abrir();
				SqlCommand cmd = new SqlCommand("ObtenerIdUsuario", Conexion.sqlConexion);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Login", Login);
				//Escalar lo que hace es obtener un solo dato un valor
				IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
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
