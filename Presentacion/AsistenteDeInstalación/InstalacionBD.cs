using Control_Empleados.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Control_Empleados.Presentacion.AsistenteDeInstalación
{
    public partial class InstalacionBD : Form
    {
        public InstalacionBD()
        {
            InitializeComponent();
        }
        private AES aes = new AES();
        string ruta;
        string NombreEquipoActual;
        public static int milisegundo;
        public static int segundos;

        private void InstalacionBD_Load(object sender, EventArgs e)
        {
            CentrarPaneles();
            Reemplazar(); 
            ComprobarSQLEXPRESS();
        }

        private void CentrarPaneles()
        {
            panelInstalador.Location = new Point((Width - panelInstalador.Width) / 2, (Height - panelInstalador.Height) / 2);
            NombreEquipoActual = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
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
                SavetoXML(aes.Encrypt("Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtNombreBaseDeDatos.Text + ";Integrated Security=True", Desencriptacion.appPwdUnique, int.Parse("256")));
                EjecutarScript();
                panelDetallesInstalador.Visible = true;
                panelDetallesInstalador.Dock = DockStyle.Fill;
                lbl1.Text = @"Instancia Encontrada...
                No Cierre esta Ventana, se cerrará Automáticamente cuando este todo Listo";
                panelDetallesInstaladorCompleto.Visible = false;
                timer4.Start();
            }
            catch (Exception)
            {
                btnInstalarServidor.Visible = true;
                panelDetallesInstaladorCompleto.Visible = true;
                panelDetallesInstalador.Visible = false;
                panelDetallesInstalador.Dock = DockStyle.None;
                lblbuscador_de_servidores.Text = "De click a Instalar Servidor, luego de click a SI cuando se le pida, luego presione ACEPTAR y espere por favor ";
            }
        }

        private void EjecutarScript()
        {
            ruta = Path.Combine(Directory.GetCurrentDirectory(), txtNombreScript.Text + ".txt");
            StreamWriter sw;
            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(txtCrear_procedimientos.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {

            }
            try
            {
                Process Pross = new Process();
                Pross.StartInfo.FileName = "sqlcmd";
                Pross.StartInfo.Arguments = " -S " + txtServidor.Text + " -i " + txtNombreScript.Text + ".txt";
                Pross.Start();
            }
            catch (Exception)
            {

            }
        }

        private void SavetoXML(object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            milisegundo += 1;
            mil3.Text = milisegundo.ToString();
            if (milisegundo == 60)
            {
                segundos += 1;
                seg3.Text = segundos.ToString();
                milisegundo = 0;
            }
            if (segundos == 15)
            {
                timer4.Stop();
                try
                {
                    File.Delete(ruta);
                }
                catch (Exception ex)
                {

                }
                Dispose();
            }
        }
    }
}
