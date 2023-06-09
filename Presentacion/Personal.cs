using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Empleados.Logica;
using Control_Empleados.Datos;

namespace Control_Empleados.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
            dataGridViewListadoCargos.Visible = false;            
        }       
        int idCargo = 0;
        int desde = 1;
        int hasta = 10;
        int contador;
        int idPersonal;
        private int itemsTotales = 10;
        string estado;
        int totalPaginas;

        private void pictureBoxAgregar_Click(object sender, EventArgs e)
        {
            LocalizarDtvCargos();
            panelCargos.Visible = false;
            lblPaginado.Visible = false;            
            panelRegistros.Visible = true;
            panelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnActualizarPersonal.Visible = false;
            //txtSueldoxHora.Enabled = false;
            Limpiar();
        }
        private void LocalizarDtvCargos()
        {
            dataGridViewListadoCargos.Location = new Point(165, 240);
            dataGridViewListadoCargos.Size = new Size(200, 150);
            dataGridViewListadoCargos.Visible = true;
            lblSueldoPorHora.Visible = false;            
            panelBtnGuardarPersonal.Visible = false;
        }
        private void Limpiar()
        {
            txtNombresCompletos.Clear();
            txtCedula.Clear();
            txtCargo.Clear();
            txtDireccion.Clear();
            txtSueldoxHora.Clear();
            BuscarCargos();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombresCompletos.Text))
            {
                if (!string.IsNullOrEmpty(txtCedula.Text))
                {
                    if (!string.IsNullOrEmpty(txtDireccion.Text))
                    {
                        if (idCargo > 0)
                        {
                            if (!string.IsNullOrEmpty(txtSueldoxHora.Text))
                            {
                                InsertarPersonal();
                            }
                        }
                    }
                }
            }
        }
        
        private void InsertarPersonal()
        {
            LPersonal parametros = new LPersonal();
            DPersonal funcion = new DPersonal();
            parametros.Nombres = txtNombresCompletos.Text;
            parametros.Cedula = txtCedula.Text;
            parametros.Direccion = txtDireccion.Text;
            parametros.IdCargo = idCargo;
            
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoxHora.Text);            
            if (funcion.InsertarPersonal(parametros) == true)
            {
                ReiniciarPaginado();
                MostrarPersonal();
                panelRegistros.Visible = false;
            }
        }
        private void MostrarPersonal()
        {
            DataTable dt = new DataTable();
            DPersonal funcion = new DPersonal();
            funcion.MostrarPersonal(ref dt, desde, hasta);
            dataGridViewListadoPersonal.DataSource = dt;
            DiseñarDgvPersonal();
            dataGridViewListadoPersonal.Columns["SueldoPorHora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void DiseñarDgvPersonal()
        {
            Dimensiones.DiseñoDataGridView(ref dataGridViewListadoPersonal);
            Dimensiones.DiseñoEliminadosDataGridView(ref dataGridViewListadoPersonal);
            lblPaginado.Visible = true;
            dataGridViewListadoPersonal.Columns[2].Visible = false;
            dataGridViewListadoPersonal.Columns[7].Visible = false;     
        }
        private void InsertarCargos()
        {
            if (!string.IsNullOrEmpty(txtCargoN.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldoN.Text))
                {
                    LCargos parametros = new LCargos();
                    DCargos funcion = new DCargos();
                    parametros.Cargo = txtCargoN.Text;
                    parametros.SueldoPorHora = Convert.ToDouble(txtSueldoN.Text);
                    if (funcion.InsertarCargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargos();
                        panelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            DCargos funcion = new DCargos();
            funcion.BuscarCargo(ref dt, txtCargo.Text);
            dataGridViewListadoCargos.DataSource = dt;
            Dimensiones.DiseñoDataGridView(ref dataGridViewListadoCargos);
            dataGridViewListadoCargos.Columns[1].Visible = false;
            dataGridViewListadoCargos.Columns[3].Visible = false;
            dataGridViewListadoCargos.Visible = true;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargos();
            LocalizarDtvCargos();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            dataGridViewListadoCargos.Visible = false;
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
            btnGuardarCargo.Visible = true;
            btnActualizarCargo.Visible = false;
            txtCargoN.Clear();
            txtSueldoN.Clear();
        }

        private void btnGuardarCargo_Click(object sender, EventArgs e)
        {
            InsertarCargos();
        }

        private void txtSueldoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dimensiones.Decimales(txtSueldoN, e);
        }

        private void txtSueldoxHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dimensiones.Decimales(txtSueldoxHora, e);
        }

        private void dataGridViewListadoCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.ColumnIndex == dataGridViewListadoCargos.Columns["EditarC"].Index)
            {
                ObtenerCargosEditar();
            }
            if (e.ColumnIndex == dataGridViewListadoCargos.Columns["Cargo"].Index)
            {
                ObtenerDatosCargos();
            }
        }
        private void ObtenerDatosCargos()
        {
            idCargo = Convert.ToInt32(dataGridViewListadoCargos.SelectedCells[1].Value);
            txtCargo.Text = dataGridViewListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoxHora.Text = dataGridViewListadoCargos.SelectedCells[3].Value.ToString();
            dataGridViewListadoCargos.Visible = false;
            panelBtnGuardarPersonal.Visible = true;
            lblSueldoPorHora.Visible = true;
        }
        private void ObtenerCargosEditar()
        {
            idCargo = Convert.ToInt32(dataGridViewListadoCargos.SelectedCells[1].Value);
            txtCargoN.Text = dataGridViewListadoCargos.SelectedCells[2].Value.ToString();
            txtSueldoN.Text = dataGridViewListadoCargos.SelectedCells[3].Value.ToString();
            btnGuardarCargo.Visible = false;
            btnActualizarCargo.Visible = true;
            txtCargoN.Focus();
            txtCargoN.SelectAll();
            panelCargos.Visible = true;
            panelCargos.Dock = DockStyle.Fill;
            panelCargos.BringToFront();
        }

        private void btnVolverCargos_Click(object sender, EventArgs e)
        {
            panelCargos.Visible = false;
        }

        private void btnVolverPersonal_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = false;
            dataGridViewListadoCargos.Visible = false;
            lblPaginado.Visible = true;
        }

        private void btnActualizarCargo_Click(object sender, EventArgs e)
        {
            EditarCargos();
        }

        private void EditarCargos()
        {
            LCargos parametros = new LCargos();
            DCargos funcion = new DCargos();
            parametros.IdCargo = idCargo;
            parametros.Cargo = txtCargoN.Text;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoN.Text);            
            if (funcion.EditarCargo(parametros) == true)
            {
                txtCargo.Clear();
                BuscarCargos();
                panelCargos.Visible = false;
            }
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();            
        }

        private void ReiniciarPaginado()
        {
            desde = 1;
            hasta = 10;
            Contar();

            if (contador > hasta)
            {

                btnSiguiente.Visible = true;
                btnAnterior.Visible = false;
                btnFinal.Visible = true;
                btnInicio.Visible = true;
            }
            else
            {

                btnSiguiente.Visible = false;
                btnAnterior.Visible = false;
                btnFinal.Visible = false;
                btnInicio.Visible = false;
            }
            Paginado();
        }

        private void dataGridViewListadoPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            if (e.ColumnIndex == dataGridViewListadoPersonal.Columns["EliminarP"].Index)
            {
                DialogResult result = MessageBox.Show("Desea Eliminar? \n Pulse OK", "Cambio de Estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    ObtenerPersonalEliminar();
                }                
            }
            if (e.ColumnIndex == dataGridViewListadoPersonal.Columns["EditarP"].Index)
            {
                ObtenerPersonalEditar();
            }            
        }

        private void ObtenerPersonalEliminar()
        {
            idPersonal = Convert.ToInt32(dataGridViewListadoPersonal.SelectedCells[2].Value);
            LPersonal parametros = new LPersonal();
            DPersonal dPersonal = new DPersonal();
            parametros.IdPersonal = idPersonal;
            if (dPersonal.EliminarPersonal(parametros)==true)                
            {
                MostrarPersonal();
            }
        }

        private void ObtenerPersonalEditar()
        {
            idPersonal = Convert.ToInt32(dataGridViewListadoPersonal.SelectedCells[2].Value);
            estado = dataGridViewListadoPersonal.SelectedCells[8].Value.ToString();
            if (estado == "ELIMINADO")
            {
                RestaurarPersonal();
            }
            else
            {
                txtNombresCompletos.Text = dataGridViewListadoPersonal.SelectedCells[3].Value.ToString();
                txtCedula.Text = dataGridViewListadoPersonal.SelectedCells[4].Value.ToString();
                txtSueldoxHora.Text = dataGridViewListadoPersonal.SelectedCells[5].Value.ToString();
                txtCargo.Text = dataGridViewListadoPersonal.SelectedCells[6].Value.ToString();
                idCargo = Convert.ToInt32(dataGridViewListadoPersonal.SelectedCells[7].Value);
                txtDireccion.Text = dataGridViewListadoPersonal.SelectedCells[10].Value.ToString();

                lblPaginado.Visible = false;
                panelRegistros.Visible = true;
                panelRegistros.Dock = DockStyle.Fill;
                dataGridViewListadoCargos.Visible = false;
                lblSueldoPorHora.Visible = true;
                panelBtnGuardarPersonal.Visible = true;
                btnGuardarPersonal.Visible = false;
                btnActualizarPersonal.Visible = true;
                panelCargos.Visible = false;
            }
        }

        private void RestaurarPersonal()
        {
            DialogResult result = MessageBox.Show("Desea Activar? \n Pulse OK", "Restaurar Estado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActivarPersonal();
            }
        }

        private void ActivarPersonal()
        {
            LPersonal parametros = new LPersonal();
            DPersonal dPersonal = new DPersonal();
            parametros.IdPersonal = idPersonal;
            if (dPersonal.RestaurarPersonal(parametros)==true)
            {
                MostrarPersonal();
            }
        }

        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            EditarPersonal();
        }

        private void EditarPersonal()
        {
            LPersonal parametros = new LPersonal();
            DPersonal dPersonal = new DPersonal();
            parametros.IdPersonal = idPersonal;
            parametros.Nombres = txtNombresCompletos.Text;
            parametros.Cedula = txtCedula.Text;
            parametros.Direccion = txtDireccion.Text;
            parametros.IdCargo = idCargo;
            parametros.SueldoPorHora = Convert.ToDouble(txtSueldoxHora.Text);
            if (dPersonal.EditarPersonal(parametros)==true)
            {
                MostrarPersonal();
                panelRegistros.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DiseñarDgvPersonal();
            timer1.Stop();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            desde += 10;
            hasta += 10;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            Paginado();
        }

        private void Contar()
        {
            DPersonal dPersonal = new DPersonal();
            dPersonal.PaginadoPersonal(ref contador);
        }

        private void Paginado()
        {
            try
            {
                lblPaginaActual.Text = (hasta / itemsTotales).ToString();
                lblTotalPaginas.Text = Math.Ceiling(Convert.ToSingle(contador) / itemsTotales).ToString();
                totalPaginas = Convert.ToInt32(lblTotalPaginas.Text);
            }
            catch (Exception)
            {

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            desde -= 10;
            hasta -= 10;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            if (desde == 1)
            {
                ReiniciarPaginado();
            }
            Paginado();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            hasta = totalPaginas * itemsTotales;
            desde = hasta - 9;
            MostrarPersonal();
            Contar();
            if (contador > hasta)
            {
                btnSiguiente.Visible = true;
                btnAnterior.Visible = true;
            }
            else
            {
                btnSiguiente.Visible = false;
                btnAnterior.Visible = true;
            }
            Paginado();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonal();
        }

        private void BuscarPersonal()
        {
            DataTable dt = new DataTable();
            DPersonal dPersonal = new DPersonal();
            dPersonal.BuscarPersonal(ref dt, desde, hasta, txtBuscar.Text);
            dataGridViewListadoPersonal.DataSource = dt;
            DiseñarDgvPersonal();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ReiniciarPaginado();
            MostrarPersonal();
        }
    }

}
