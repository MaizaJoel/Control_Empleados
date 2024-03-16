using Control_Empleados.Datos;
using Control_Empleados.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Empleados.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public int IdUsuario;
        public string LoginV;

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
            ValidarPermisos();
        }

        private void ValidarPermisos()
        {
            DataTable dt = new DataTable();
            DPermisos dPermisos = new DPermisos();
            LPermisos lPermisos = new LPermisos();
            lPermisos.IdUsuario = IdUsuario;
            dPermisos.MostrarPermisos(ref dt, lPermisos);

            btnConsultas.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;
            btnRespaldos.Enabled = false;
            btnRestaurar.Enabled = false;

            foreach (DataRow rowPermisos in dt.Rows)
            {
                string Modulo = Convert.ToString(rowPermisos["Modulo"]);
                switch (Modulo)
                {
                    case "Asistencias":
                        btnConsultas.Enabled = true;
                        break;
                    case "Usuarios":
                        btnUsuarios.Enabled = true;
                        btnRegistro.Enabled = true;
                        break;
                    case "Personal":
                        btnPersonal.Enabled = true;
                        break;
                    case "Respaldos":
                        btnRespaldos.Enabled = true;
                        btnRestaurar.Enabled = true;
                        break;
                }
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            Personal personalControl = new Personal();
            personalControl.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(personalControl);

            //panelContenido.Controls.Clear();
            //MostrarPersonal personalControl = new MostrarPersonal();
            //personalControl.Dock = DockStyle.Fill;
            //panelContenido.Controls.Add(personalControl);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Personal pruebasControl = new Personal();            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
            ControlUsuarios controlUsuarios = new ControlUsuarios();
            controlUsuarios.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(controlUsuarios);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Dispose();
            Registro frm = new Registro();
            frm.ShowDialog();
        }
    }
}
