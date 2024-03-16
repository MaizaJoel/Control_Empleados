using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Empleados.Presentacion.AsistenteDeInstalación
{
    public partial class EleccionServidor : Form
    {
        public EleccionServidor()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {

            //Destruir Formulario
            Dispose();
            InstalacionBD instalacionBD = new InstalacionBD();
            instalacionBD.ShowDialog();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            //Destruir Formulario
            Dispose();
            ConexionRemota conexionRemota = new ConexionRemota();
            conexionRemota.ShowDialog();
        }
    }
}
