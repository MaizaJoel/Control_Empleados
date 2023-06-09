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
		public void ObtenerIdUsuario(ref int IdUsuario, string Login)
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
        #region No explicado en el tutorial haciendo al ojo
        public bool EliminarUsuarios(LUsuarios parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarUsuarios", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@Login", parametros.Login);

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
        public bool EditarUsuarios(LUsuarios parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EditarUsuarios", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombres", parametros.NombreApellido);
                cmd.Parameters.AddWithValue("@Login", parametros.Login);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Icono", parametros.Icono);

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
        public void VerificarUsuarios(ref string Indicador)
        {
            try
            {
                int Iduser;
                Conexion.abrir();
                SqlCommand sqlCommand = new SqlCommand("Select IdUsuario From Usuarios", Conexion.sqlConexion);
                Iduser = Convert.ToInt32(sqlCommand.ExecuteScalar());
                Conexion.cerrar();
                Indicador = "Correcto";
            }
            catch (Exception)
            {
                Indicador = "Incorrecto";
            }
        }
        public void ValidarUsuario(LUsuarios parametros, ref int id)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("ValidarUsuario", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Login", parametros.Login);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                //Si no usuario 0
                id = 0;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void BuscarUsuarios(ref DataTable dt, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BuscarUsuarios", Conexion.sqlConexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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
        public bool RestaurarUsuarios(LUsuarios parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("RestaurarUsuarios", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
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
        #endregion
    }
}
