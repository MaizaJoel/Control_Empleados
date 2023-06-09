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

        }
    }
}
