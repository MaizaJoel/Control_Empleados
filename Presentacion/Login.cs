using Control_Empleados.Datos;
using Control_Empleados.Logica;
using Control_Empleados.Presentacion.AsistenteDeInstalación;
using Control_Empleados.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Control_Empleados.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string Usuario;
        int Idusuario;
        int Contador;
        string Indicador;       

        private void Login_Load(object sender, EventArgs e)
        {
            ValidarConexion();
        }
        private void ValidarConexion()
        {
            VerificarConexion();
            if (Indicador == "Correcto")
            {
                //MostrarUsuarios();
                //if (Contador == 0)
                //{
                //    Dispose();
                //    UsuarioPrincipal frm = new UsuarioPrincipal();
                //    frm.ShowDialog();
                //}
                //else
                //{
                //    CargarUsuarios();
                //}
                CargarUsuarios();
            }
            else
            {
                Dispose();
                EleccionServidor frm = new EleccionServidor();
                frm.ShowDialog();
            }
        }
        private void VerificarConexion()
        {
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.VerificarUsuarios(ref Indicador);
        }
        private void CargarUsuarios()
        {
            try
            {
                PanelUsuarios.Visible = true;
                PanelUsuarios.Dock = DockStyle.Fill;
                PanelUsuarios.BringToFront();
                DataTable dt = new DataTable();
                DUsuarios dUsuarios = new DUsuarios();
                dUsuarios.MostrarUsuarios(ref dt);
                foreach (DataRow dataRow in dt.Rows)
                {
                    Label label = new Label();
                    Panel panel = new Panel();
                    UIPictureBox pictureBox = new UIPictureBox();
                    label.Text = dataRow["Login"].ToString();
                    label.Name = dataRow["IdUsuario"].ToString();
                    label.Size = new Size(175, 22);
                    label.Font = new Font("Lucida Fax", 15);
                    label.BackColor = Color.Transparent;
                    label.ForeColor = Color.White;
                    label.Dock = DockStyle.Bottom;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Cursor = Cursors.Hand;

                    panel.Size = new Size(155, 170);
                    panel.BorderStyle = BorderStyle.None;
                    //panel.BackColor = Color.FromArgb(191, 179, 255);
                    panel.BackColor = Color.Transparent;

                    pictureBox.Size = new Size(175, 148);
                    pictureBox.Dock = DockStyle.Top;
                    pictureBox.BackgroundImage = null;
                    byte[] bi = (Byte[]) dataRow["Icono"];
                    MemoryStream ms = new MemoryStream(bi);
                    pictureBox.Image = Image.FromStream(ms);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Tag = dataRow["Login"].ToString();
                    pictureBox.Cursor = Cursors.Hand;

                    panel.Controls.Add(label);
                    panel.Controls.Add(pictureBox);
                    label.BringToFront();

                    flowLayoutPanelCargarListadoUsuarios.Controls.Add(panel);

                    label.Click += MiEventoLabel;
                    pictureBox.Click += MiEventoPictureBox;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MiEventoPictureBox(object sender, EventArgs e)
        {
            //Capturar imagen perfil usuario
            Usuario = Convert.ToString(((PictureBox)sender).Tag);
            MostrarPanelLogin();
        }

        private void MiEventoLabel(object sender, EventArgs e)
        {
            //Capturar el ususario
            Usuario = ((Label)sender).Text;
            MostrarPanelLogin();
        }

        private void MostrarPanelLogin()
        {
            panelLogin.Visible = true;
            //Centrar el panel
            panelLogin.Location = new Point((Width - panelLogin.Width)/2,(Height - panelLogin.Height)/2);
            
            PanelUsuarios.Visible = false;
        }

        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.MostrarUsuarios(ref dt);
            Contador = dt.Rows.Count;
        }
    }
}
