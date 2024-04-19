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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            this.ActiveControl = txtCedula;
        }
        string cedula;
        int idPersonal;
        int contador;
        DateTime fechaEntrada;

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");            
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            BuscarPersonalCedula();
            if (cedula == txtCedula.Text)
            {
                BuscarAsistenciaId();
                if (contador == 0)
                {
                    InsertarAsistencia();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Agregar Adelanto?", "Adelantos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        panelIngreso.Visible = false;
                        panelAdelanto.Visible = true;
                        //panelAdelanto.Location = new Point(panelIngreso.Location.X, panelIngreso.Location.Y);
                        panelAdelanto.Size = new Size(panelIngreso.Width, panelAdelanto.Height);
                        panelAdelanto.BringToFront();
                        txtAdelanto.Clear();
                        txtAdelanto.Focus();
                    }
                    else
                    {
                        txtAdelanto.Text = "0";
                        ConfirmarSalida();
                    }
                }
            }
        }
        private void ConfirmarSalida()
        {
            if (string.IsNullOrEmpty(txtAdelanto.Text))
            {
                txtAdelanto.Text = "0";
            }
            LAsistencia parametros = new LAsistencia();
            DAsistencia dAsistencia = new DAsistencia();
            parametros.IdPersonal = idPersonal;            
            parametros.FechaSalida = DateTime.Now;
            parametros.Estado = "SALIDA";
            parametros.Horas = (Dimensiones.DateDiff(Dimensiones.DateInterval.Hour, fechaEntrada, DateTime.Now) + Dimensiones.DateDiff(Dimensiones.DateInterval.Minute, fechaEntrada, DateTime.Now));
            parametros.Adelanto = Convert.ToDouble(txtAdelanto.Text);
            if (dAsistencia.ConfirmarSalida(parametros) == true)
            {
                txtAviso.Text = "SALIDA REGISTRADA";
                txtCedula.Clear();
                txtCedula.Focus();
                panelAdelanto.Visible = false;
            }
        }
        private void InsertarAsistencia()
        {            
            LAsistencia parametros = new LAsistencia();
            DAsistencia dAsistencia = new DAsistencia();
            parametros.IdPersonal = idPersonal;
            parametros.FechaEntrada = DateTime.Now;
            parametros.FechaSalida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Adelanto = 0;
            if (dAsistencia.InsertarAsistencia(parametros)==true)
            {
                txtAviso.Text = "ENTRADA REGISTRADA";
                txtCedula.Clear();
                txtCedula.Focus();
            }            
        }
        private void BuscarAsistenciaId()   
        {
            DataTable dt = new DataTable();
            DAsistencia dAsistencia = new DAsistencia();
            dAsistencia.BuscarAsistenciaId(ref dt, idPersonal); 
            contador = dt.Rows.Count;
            if (contador > 0)
            {
                fechaEntrada = Convert.ToDateTime(dt.Rows[0]["FechaEntrada"]);
            }
        }
        private void BuscarPersonalCedula()
        {
            DataTable dt = new DataTable();
            DPersonal dPersonal = new DPersonal();
            dPersonal.BuscarPersonalCedula(ref dt, txtCedula.Text);
            if (dt.Rows.Count > 0)
            {
                cedula = dt.Rows[0]["Cedula"].ToString();
                idPersonal = Convert.ToInt32(dt.Rows[0]["IdPersonal"]);
                txtNombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            panelIngreso.Visible = true;
            ConfirmarSalida();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dimensiones.SoloNumeros(txtCedula, e);
        }

        private void txtAdelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Dimensiones.SoloNumeros(txtAdelanto, e);
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
