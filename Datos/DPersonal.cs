using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Control_Empleados.Logica;
using System.Windows.Forms; 

namespace Control_Empleados.Datos
{
    public class DPersonal
    {
        public bool InsertarPersonal(LPersonal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarPersonal", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Cedula", parametros.Cedula);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdCargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
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
        public bool EditarPersonal(LPersonal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Cedula", parametros.Cedula);
                cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
                cmd.Parameters.AddWithValue("@IdCargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
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
        public bool EliminarPersonal(LPersonal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);                
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

        //Para trabajar con comboBox DataGridView o DataTable
        public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPersonal", Conexion.sqlConexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);
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
        public void BuscarPersonal(ref DataTable dt, int desde, int hasta, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BuscarPersonal", Conexion.sqlConexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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
        public bool RestaurarPersonal(LPersonal parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("RestaurarPersonal", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdPersonal", parametros.IdPersonal);
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

        public void PaginadoPersonal(ref int contador)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand(@"select COUNT(IdPersonal)
                                                    from Personal", 
                                                    Conexion.sqlConexion);
                contador = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                contador = 0;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public void BuscarPersonalCedula(ref DataTable dt, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BuscarPersonalCedula", Conexion.sqlConexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;                
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
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
