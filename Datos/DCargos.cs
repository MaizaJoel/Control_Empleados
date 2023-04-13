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
    public class DCargos
    {
        public bool InsertarCargo(LCargos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarCargo", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
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
        public bool EditarCargo(LCargos parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EditarCargo", Conexion.sqlConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCargo", parametros.IdCargo);
                cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
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
        public void BuscarCargo(ref DataTable dt, string buscador)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("BuscarCargo", Conexion.sqlConexion);
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
