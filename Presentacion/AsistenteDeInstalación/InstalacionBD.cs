using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Empleados.Presentacion.AsistenteDeInstalación
{
    public partial class InstalacionBD : Form
    {
        public InstalacionBD()
        {
            InitializeComponent();
        }

        string NombreEquipo;

        private void InstalacionBD_Load(object sender, EventArgs e)
        {
            CentrarPaneles();
            Reemplazar();
        }

        private void CentrarPaneles()
        {
            panelInstalador.Location = new Point((Width - panelInstalador.Width) / 2, (Height - panelInstalador.Height) / 2);
            NombreEquipo = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Cursor = Cursors.WaitCursor;
            panelDetallesInstalador.Visible = false;
            panelDetallesInstalador.Dock = DockStyle.None;
        }

        private void Reemplazar()
        {
            //El nombre de nuestra base
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text.Replace("ControlPersonal", txtNombreBaseDeDatos.Text);
            //Cambiar los datos del script
            txtEliminarBase.Text = txtEliminarBase.Text.Replace("BASEADACURSO", txtNombreBaseDeDatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("ada369", txtUsuario.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("BASEADA", txtNombreBaseDeDatos.Text);
            txtCrearUsuarioDb.Text = txtCrearUsuarioDb.Text.Replace("softwarereal", txtContraseña.Text);
            //Unir con salto de línea, para tener un solo script
            txtCrear_procedimientos.Text = txtCrear_procedimientos.Text + Environment.NewLine + txtCrearUsuarioDb.Text;

        }
        private void ComprobarSQLEXPRESS()
        {
            //@ para reconozca como caracter
            txtServidor.Text = @".\" + txtNombreInstancia.Text;
            EjecutarScriptEliminarBase();
            EjecutarScriptCrearBase();
        }

        private void EjecutarScriptEliminarBase()
        {
            string str;
            SqlConnection myConn = new SqlConnection("Data source=" + txtServidor.Text + ";Initial Catalog=master;Integrated Security=True");
            str = txtEliminarBase.Text;
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {


            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void EjecutarScriptCrearBase()
        {
            SqlConnection cnn = new SqlConnection("Server=" + txtServidor.Text + "; " + "database=master; Integrated Security=True");
            string s = "CREATE DATABASE " + txtNombreBaseDeDatos.Text;
            SqlCommand cmd = new SqlCommand(s, cnn);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                SavetoXML(aes.Encrypt("Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtNombreBaseDeDatos.Text + ";Integrated Security=True", Desencryptacion.appPwdUnique, int.Parse("256")));
                EjecutarScript();
                Panel4.Visible = true;
                Panel4.Dock = DockStyle.Fill;
                Label1.Text = @"Instancia Encontrada...
                No Cierre esta Ventana, se cerrara Automaticamente cuando este todo Listo";
                Panel6.Visible = false;
                timer4.Start();

            }
            catch (Exception)
            {
                btnInstalarServidor.Visible = true;
                Panel6.Visible = true;
                Panel4.Visible = false;
                Panel4.Dock = DockStyle.None;
                lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor ";
            }

        }
    }
}
