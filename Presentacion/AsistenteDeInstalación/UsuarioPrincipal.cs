using Control_Empleados.Datos;
using Control_Empleados.Logica;
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

namespace Control_Empleados.Presentacion.AsistenteDeInstalación
{
    public partial class UsuarioPrincipal : Form
    {
        public UsuarioPrincipal()
        {
            InitializeComponent();
            this.ActiveControl = txtNombre;
        }

        int IdUsuario;

        void AlertBox()
        {
            Form_Binding_Information form = new Form_Binding_Information();
            form.ShowDialog();
        }

        private void BotonInformación_Click(object sender, EventArgs e)
        {
            AlertBox();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Falta ingresar el Nombre", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Falta ingresar la Contraseña", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                InsertarUsuarioDefecto();
            }
        }

        private void InsertarUsuarioDefecto()
        {
            LUsuarios parametros = new LUsuarios();
            DUsuarios dUsuarios = new DUsuarios();
            parametros.NombreApellido = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            this.ActiveControl = txtNombre;
            if (dUsuarios.InsertarUsuarios(parametros) == true)
            {
                InsertarCopiasBD();
                InsertarModulos();
                ObtenerIdUsuario();
                InsertarPermisos();
            }
        }
        private void InsertarCopiasBD()
        {
            DCopiasDeSeguridad dCopiasDeSeguridad  = new DCopiasDeSeguridad();
            dCopiasDeSeguridad.InsertarCopiasDeSeguridad();
        }
        private void ObtenerIdUsuario()
        {
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.ObtenerIdUsuario(ref IdUsuario, txtUsuario.Text);
        }
        private void InsertarPermisos()
        {
            DataTable dt = new DataTable();
            DModulos dModulos = new DModulos();
            dModulos.MostrarModulos(ref dt);
            foreach (DataRow row in dt.Rows)
            {
                int IdModulo = Convert.ToInt32(row["IdModulo"]);
                LPermisos lpermisos = new LPermisos();
                DPermisos dpermisos = new DPermisos();
                lpermisos.IdModulo = IdModulo;
                lpermisos.IdUsuario = IdUsuario;
                dpermisos.InsertarPermisos(lpermisos);
            }
            MessageBox.Show("!LISTO! RECUERDA que para Iniciar Sesión tu usuario es: " + txtUsuario.Text + " y tu contraseña es: " + txtContraseña.Text, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }
        private void InsertarModulos()
        {
            LModulo parametros = new LModulo();
            DModulos dModulos = new DModulos();
            var Modulos = new List<string> { "Usuarios", "Asistencias", "Personal", "Respaldos" };
            foreach (var Modulo in Modulos)
            {
                parametros.Modulo = Modulo;
                dModulos.InsertarModulos(parametros);
            }
        }

    }
}
