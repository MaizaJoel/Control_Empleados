using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Empleados.Datos;
using Control_Empleados.Logica;

namespace Control_Empleados.Presentacion
{
    public partial class CopiasDeSeguridad : UserControl
    {
        public CopiasDeSeguridad()
        {
            InitializeComponent();
        }

        string ruta;
        string txtSoftware = "FreesiasCE";
        string baseDeDatos = "ControlEmpleados";
        private Thread Hilo;
        private bool acaba = false;

        private void CopiasDeSeguridad_Load(object sender, EventArgs e)
        {
            MostrarRuta();
        }

        private void MostrarRuta()
        {
            DCopiasDeSeguridad dCopiasDeSeguridad = new DCopiasDeSeguridad();
            dCopiasDeSeguridad.MostrarRuta(ref ruta);
            txtRuta.Text = ruta;
        }

        private void btnCopiaDeSeguridad_Click(object sender, EventArgs e)
        {
            GenerarCopia();
        }

        private void GenerarCopia()
        {
            if (!string.IsNullOrEmpty(txtRuta.Text))
            {
                Hilo = new Thread(new ThreadStart(Ejecucion));
                Hilo.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Selecciona una ruta donde guardar las *Copias de Seguridad*", "Seleccione ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuta.Focus();
            }
        }

        private void Ejecucion()
        {
            string miCarpeta = "Copias_de_Seguridad_de_" + txtSoftware;
            if (System.IO.Directory.Exists(txtRuta.Text + miCarpeta))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            string rutaCompleta = txtRuta.Text + miCarpeta;
            string SubCarpeta = rutaCompleta + @"\Respaldo_al_" + DateTime.Now.Day + "_" + (DateTime.Now.Month) + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
            try
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(rutaCompleta, SubCarpeta));
            }
            catch (Exception)
            {

            }
            try
            {
                string v_nombre_respaldo = baseDeDatos + ".bak";
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + baseDeDatos + " TO DISK = '" + SubCarpeta + @"\" + v_nombre_respaldo + "'", Conexion.sqlConexion);
                cmd.ExecuteNonQuery();
                acaba = true;

            }
            catch (Exception ex)
            {
                acaba = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBoxAgregarRuta_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }

        private void ObtenerRuta()
        {
            if (folderBrowserDialogRuta.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialogRuta.SelectedPath;
            }
        }

        private void EditarRespaldos()
        {
            LCopiasDeSeguridad parametros = new LCopiasDeSeguridad();
            DCopiasDeSeguridad dCopiasDeSeguridad = new DCopiasDeSeguridad();
            parametros.Ruta = txtRuta.Text;
            if (dCopiasDeSeguridad.EditarCopiasDeSeguridad(parametros) == true)
            {
                MessageBox.Show("Copia de Base de Datos generada", "Generación de Copia de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (acaba == true)
            {
                timer1.Stop();
                EditarRespaldos();
            }
        }
    }
}
