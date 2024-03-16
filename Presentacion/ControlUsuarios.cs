using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Empleados.UI;
using Control_Empleados.Logica;
using Control_Empleados.Datos;
using System.IO;

namespace Control_Empleados.Presentacion
{
    public partial class ControlUsuarios : UserControl
    {
        public ControlUsuarios()
        {
            InitializeComponent();
        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        int IdUsuario;
        string Login;
        string Estado;

        #region Alert Box Bonito
        void AlertBox()
        {
            Form_Binding_Information form = new Form_Binding_Information();
            form.ShowDialog();
        }
        private void BotonInformación_Click(object sender, EventArgs e)
        {
            AlertBox();
        }
        #endregion
        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
        private void MostrarPaneles()
        {
            panelRegistro.Visible = true;
            lblElegirIcono.Visible = true;
            panelIconos.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnGuardarUsuario.Visible = true;
            btnActualizarUsuario.Visible = false;
        }
        private void MostrarModulos()
        {
            DModulos modulos = new DModulos();
            DataTable dt = new DataTable();
            modulos.MostrarModulos(ref dt);
            dataGridViewListadoModulos.DataSource = dt;
            dataGridViewListadoModulos.Columns[1].Visible = false;
        }
        private void pictureBoxAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            MostrarPaneles();
            MostrarModulos();
        }
        #region CRUD USUARIO
        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            DUsuarios dUsuarios = new DUsuarios();
            dUsuarios.MostrarUsuarios(ref dt);
            dataGridViewListadoUsuarios.DataSource = dt;
            DiseñarDgvUsuarios();
        }
        private void DiseñarDgvUsuarios()
        {
            Dimensiones.DiseñoDataGridView(ref dataGridViewListadoUsuarios);
            Dimensiones.DiseñoEliminadosDataGridView(ref dataGridViewListadoUsuarios);
            dataGridViewListadoUsuarios.Columns[2].Visible = false;
            dataGridViewListadoUsuarios.Columns[5].Visible = false;
            dataGridViewListadoUsuarios.Columns[6].Visible = false;
        }
        private void ObtenerIdUsuario()
        {
            DUsuarios usuarios = new DUsuarios();
            usuarios.ObtenerIdUsuario(ref IdUsuario, txtUsuario.Text);
        }
        private void InsertarUsuarios()
        {
            LUsuarios parametros = new LUsuarios();
            DUsuarios funcion = new DUsuarios();
            parametros.NombreApellido = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            pictureBoxIcono.Image.Save(ms, pictureBoxIcono.Image.RawFormat);
            //Procesar bytes para enviarlos a la BD
            parametros.Icono = ms.GetBuffer();
            //El Estado por defecto en Activo
            if (funcion.InsertarUsuarios(parametros) == true)
            {
                ObtenerIdUsuario();
                InsertarPermisos();
            }
        }
        private void EditarUsuarios()
        {
            LUsuarios parametros = new LUsuarios();
            DUsuarios funcion = new DUsuarios();
            parametros.IdUsuario = IdUsuario;
            parametros.NombreApellido = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            pictureBoxAgregarIcono.Image.Save(ms, pictureBoxAgregarIcono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.EditarUsuarios(parametros) == true)
            {
                EliminarPermisos();
                InsertarPermisos();
            }
        }
        private void EliminarUsuarios()
        {
            LUsuarios parametros = new LUsuarios();
            DUsuarios funcion = new DUsuarios();
            parametros.IdUsuario = IdUsuario;
            parametros.Login = Login;
            if (funcion.EliminarUsuarios(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
        private void ObtenerEstadoUsuarios()
        {
            Estado = dataGridViewListadoUsuarios.SelectedCells[7].Value.ToString();
        }
        private void dataGridViewListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewListadoUsuarios.Columns["EditarP"].Index)
            {
                ObtenerEstadoUsuarios();
                if (Estado == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Eliminó. ¿Desea Volver a Habilitarlo?", "Restauración de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        RestaurarUsuario();
                    }
                }
                else
                {
                    ObtenerDatos();
                }

            }
            if (e.ColumnIndex == dataGridViewListadoUsuarios.Columns["EliminarP"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    CapturarIdUsuario();
                    EliminarUsuarios();
                }

            }
        }
        private void RestaurarUsuario()
        {
            CapturarIdUsuario();
            LUsuarios parametros = new LUsuarios();
            DUsuarios funcion = new DUsuarios();
            parametros.IdUsuario = IdUsuario;
            if (funcion.RestaurarUsuarios(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
        private void ObtenerDatos()
        {
            CapturarIdUsuario();
            txtNombre.Text = dataGridViewListadoUsuarios.SelectedCells[3].Value.ToString();
            txtUsuario.Text = dataGridViewListadoUsuarios.SelectedCells[4].Value.ToString();
            if (txtUsuario.Text == "admin")
            {
                txtUsuario.Enabled = false;
                dataGridViewListadoModulos.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                dataGridViewListadoModulos.Enabled = true;
            }
            txtContraseña.Text = dataGridViewListadoUsuarios.SelectedCells[5].Value.ToString();

            pictureBoxIcono.BackgroundImage = null;
            byte[] b = (byte[])(dataGridViewListadoUsuarios.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            pictureBoxIcono.Image = Image.FromStream(ms);
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            lblElegirIcono.Visible = false;
            btnActualizarUsuario.Visible = true;
            btnGuardarUsuario.Visible = false;
            MostrarModulos();
            MostrarPermisos();
        }
        private void CapturarIdUsuario()
        {
            IdUsuario = Convert.ToInt32(dataGridViewListadoUsuarios.SelectedCells[2].Value);
            Login = dataGridViewListadoUsuarios.SelectedCells[4].Value.ToString();
        }
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblElegirIcono.Visible == false)
                        {
                            InsertarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Nombre");
            }
        }
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblElegirIcono.Visible == false)
                        {
                            EditarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un icono");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el usuario");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre");
            }
        }
        #endregion

        #region CRUD PERMISOS
        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in dataGridViewListadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    LPermisos lPermisos = new LPermisos();
                    DPermisos dPermisos = new DPermisos();
                    lPermisos.IdModulo = IdModulo;
                    lPermisos.IdUsuario = IdUsuario;
                    dPermisos.InsertarPermisos(lPermisos);
                }
            }
            MostrarUsuarios();
            panelRegistro.Visible = false;
        }
        private void EliminarPermisos()
        {
            LPermisos parametros = new LPermisos();
            DPermisos funcion = new DPermisos();
            parametros.IdUsuario = IdUsuario;
            funcion.EliminarPermisos(parametros);
        }
        private void MostrarPermisos()
        {
            DataTable dt = new DataTable();
            DPermisos funcion = new DPermisos();
            LPermisos parametros = new LPermisos();
            parametros.IdUsuario = IdUsuario;
            funcion.MostrarPermisos(ref dt, parametros);
            foreach (DataRow rowPermisos in dt.Rows)
            {
                int idmoduloPermisos = Convert.ToInt32(rowPermisos["IdModulo"]);
                foreach (DataGridViewRow rowModulos in dataGridViewListadoModulos.Rows)
                {
                    int Idmodulo = Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == Idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
            }
        }
        #endregion

        #region BOTONES PICTUREBOX ICONOS
        private void pictureBox01_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox01.Image;
            OcultarPanelIconos();
        }
        private void pictureBox02_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox02.Image;
            OcultarPanelIconos();
        }
        private void pictureBox03_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox03.Image;
            OcultarPanelIconos();
        }
        private void pictureBox04_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox04.Image;
            OcultarPanelIconos();
        }
        private void pictureBox05_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox05.Image;
            OcultarPanelIconos();
        }
        private void pictureBox06_Click(object sender, EventArgs e)
        {
            pictureBoxIcono.Image = pictureBox06.Image;
            OcultarPanelIconos();
        }
        #endregion 
        private void lblElegirIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIconos();
        }
        private void MostrarPanelIconos()
        {
            panelIconos.Visible = true;
            panelIconos.Dock = DockStyle.Fill;
            panelIconos.BringToFront();
        }
        private void OcultarPanelIconos()
        {
            panelIconos.Visible = false;
            lblElegirIcono.Visible = false;
            pictureBoxIcono.Visible = true;
        }
        private void pictureBoxAgregarIcono_Click(object sender, EventArgs e)
        {
            openFileDialogIcono.InitialDirectory = "";
            openFileDialogIcono.Filter = "Imagenes|*.jpg;*.png";
            openFileDialogIcono.FilterIndex = 2;
            openFileDialogIcono.Title = "Cargador de Imagenes";
            if (openFileDialogIcono.ShowDialog()==DialogResult.OK)
            {
                pictureBoxIcono.BackgroundImage = null;
                pictureBoxIcono.Image = new Bitmap(openFileDialogIcono.FileName);
                OcultarPanelIconos();
            }            
        }
        private void pictureBoxIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIconos();
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dimensiones.SoloNumeros(txtContraseña, e);
        }
        private void btnVolverUsuario_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
        }
        private void btnVolverIconos_Click(object sender, EventArgs e)
        {
            OcultarPanelIconos();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }
        private void BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            DUsuarios funcion = new DUsuarios();
            funcion.BuscarUsuarios(ref dt, txtBuscar.Text);
            dataGridViewListadoUsuarios.DataSource = dt;
            DiseñarDgvUsuarios();
        }
    }
}
