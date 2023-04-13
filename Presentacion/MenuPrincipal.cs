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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;            
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
            //panelContenido.Controls.Clear();
            //Registro registro = new Registro();
            //registro.Dock = DockStyle.Fill;
            //panelContenido.Controls.Add(registro);
        }
    }
}
