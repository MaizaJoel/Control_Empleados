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
    public class DAsistencia
    {
        public void BuscarAsistenciaId(ref DataTable dt, int idPersonal)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BuscarAsistenciaId", Conexion.sqlConexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IdPersonal", idPersonal);
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

        public bool InsertarAsistencia(LAsistencia parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarAsistencia", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@FechaEntrada", parametros.FechaEntrada);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.FechaSalida);
                cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
                cmd.Parameters.AddWithValue("@Horas", parametros.Horas);
                cmd.Parameters.AddWithValue("@Adelanto", parametros.Adelanto);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        
        public bool ConfirmarSalida(LAsistencia parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("ConfirmarSalida", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@FechaSalida", parametros.FechaSalida);
                cmd.Parameters.AddWithValue("@Horas", parametros.Horas);
                cmd.Parameters.AddWithValue("@Adelanto", parametros.Adelanto);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
