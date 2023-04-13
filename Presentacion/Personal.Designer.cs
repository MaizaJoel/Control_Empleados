
namespace Control_Empleados.Presentacion
{
    partial class Personal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewListadoPersonal = new System.Windows.Forms.DataGridView();
            this.EditarP = new System.Windows.Forms.DataGridViewImageColumn();
            this.EliminarP = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblPaginado = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBotonesPaginado = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.pictureBoxAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelRegistros = new System.Windows.Forms.Panel();
            this.panelBtnGuardarPersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCargos = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolverCargos = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSueldoN = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtCargoN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolverPersonal = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldoxHora = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSueldoPorHora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewListadoCargos = new System.Windows.Forms.DataGridView();
            this.EditarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuardarPersonal = new Control_Empleados.UI.UIButton();
            this.btnActualizarPersonal = new Control_Empleados.UI.UIButton();
            this.btnGuardarCargo = new Control_Empleados.UI.UIButton();
            this.btnActualizarCargo = new Control_Empleados.UI.UIButton();
            this.btnInicio = new Control_Empleados.UI.UIButton();
            this.btnFinal = new Control_Empleados.UI.UIButton();
            this.btnAnterior = new Control_Empleados.UI.UIButton();
            this.btnSiguiente = new Control_Empleados.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoPersonal)).BeginInit();
            this.lblPaginado.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelBotonesPaginado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegistros.SuspendLayout();
            this.panelBtnGuardarPersonal.SuspendLayout();
            this.panelCargos.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListadoPersonal
            // 
            this.dataGridViewListadoPersonal.AllowUserToAddRows = false;
            this.dataGridViewListadoPersonal.AllowUserToDeleteRows = false;
            this.dataGridViewListadoPersonal.AllowUserToOrderColumns = true;
            this.dataGridViewListadoPersonal.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridViewListadoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListadoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarP,
            this.EliminarP});
            this.dataGridViewListadoPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListadoPersonal.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewListadoPersonal.Name = "dataGridViewListadoPersonal";
            this.dataGridViewListadoPersonal.ReadOnly = true;
            this.dataGridViewListadoPersonal.RowHeadersWidth = 51;
            this.dataGridViewListadoPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewListadoPersonal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListadoPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListadoPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewListadoPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewListadoPersonal.RowTemplate.Height = 40;
            this.dataGridViewListadoPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListadoPersonal.Size = new System.Drawing.Size(1239, 515);
            this.dataGridViewListadoPersonal.TabIndex = 1;
            this.dataGridViewListadoPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoPersonal_CellContentClick);
            // 
            // EditarP
            // 
            this.EditarP.HeaderText = "";
            this.EditarP.Image = global::Control_Empleados.Properties.Resources.edit;
            this.EditarP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarP.MinimumWidth = 6;
            this.EditarP.Name = "EditarP";
            this.EditarP.ReadOnly = true;
            this.EditarP.Width = 125;
            // 
            // EliminarP
            // 
            this.EliminarP.HeaderText = "";
            this.EliminarP.Image = global::Control_Empleados.Properties.Resources.delete__1_;
            this.EliminarP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EliminarP.MinimumWidth = 6;
            this.EliminarP.Name = "EliminarP";
            this.EliminarP.ReadOnly = true;
            this.EliminarP.Width = 125;
            // 
            // lblPaginado
            // 
            this.lblPaginado.BackColor = System.Drawing.Color.Thistle;
            this.lblPaginado.Controls.Add(this.panel3);
            this.lblPaginado.Controls.Add(this.panelBotonesPaginado);
            this.lblPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPaginado.Location = new System.Drawing.Point(0, 603);
            this.lblPaginado.Name = "lblPaginado";
            this.lblPaginado.Size = new System.Drawing.Size(1239, 68);
            this.lblPaginado.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnInicio);
            this.panel3.Controls.Add(this.btnFinal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(926, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 68);
            this.panel3.TabIndex = 7;
            // 
            // panelBotonesPaginado
            // 
            this.panelBotonesPaginado.BackColor = System.Drawing.Color.Transparent;
            this.panelBotonesPaginado.Controls.Add(this.btnAnterior);
            this.panelBotonesPaginado.Controls.Add(this.label3);
            this.panelBotonesPaginado.Controls.Add(this.lblTotalPaginas);
            this.panelBotonesPaginado.Controls.Add(this.lblPaginaActual);
            this.panelBotonesPaginado.Controls.Add(this.btnSiguiente);
            this.panelBotonesPaginado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotonesPaginado.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesPaginado.Name = "panelBotonesPaginado";
            this.panelBotonesPaginado.Size = new System.Drawing.Size(415, 68);
            this.panelBotonesPaginado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(196, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "de";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(217, 23);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(28, 29);
            this.lblTotalPaginas.TabIndex = 5;
            this.lblTotalPaginas.Text = "0";
            this.lblTotalPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.Location = new System.Drawing.Point(171, 23);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(28, 29);
            this.lblPaginaActual.TabIndex = 3;
            this.lblPaginaActual.Text = "0";
            this.lblPaginaActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.btnMostrarTodos);
            this.panel1.Controls.Add(this.pictureBoxAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.Transparent;
            this.btnMostrarTodos.Location = new System.Drawing.Point(388, 32);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(229, 50);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "MOSTRAR TODOS";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // pictureBoxAgregar
            // 
            this.pictureBoxAgregar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAgregar.Image = global::Control_Empleados.Properties.Resources.add;
            this.pictureBoxAgregar.Location = new System.Drawing.Point(1143, 0);
            this.pictureBoxAgregar.Name = "pictureBoxAgregar";
            this.pictureBoxAgregar.Size = new System.Drawing.Size(96, 88);
            this.pictureBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAgregar.TabIndex = 3;
            this.pictureBoxAgregar.TabStop = false;
            this.pictureBoxAgregar.Click += new System.EventHandler(this.pictureBoxAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Control_Empleados.Properties.Resources.searching;
            this.pictureBox1.Location = new System.Drawing.Point(311, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Location = new System.Drawing.Point(35, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 4);
            this.panel2.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Thistle;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(35, 57);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(261, 15);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // panelRegistros
            // 
            this.panelRegistros.BackColor = System.Drawing.Color.Purple;
            this.panelRegistros.Controls.Add(this.panelBtnGuardarPersonal);
            this.panelRegistros.Controls.Add(this.panelCargos);
            this.panelRegistros.Controls.Add(this.btnVolverPersonal);
            this.panelRegistros.Controls.Add(this.btnAgregarCargo);
            this.panelRegistros.Controls.Add(this.panel9);
            this.panelRegistros.Controls.Add(this.txtSueldoxHora);
            this.panelRegistros.Controls.Add(this.panel8);
            this.panelRegistros.Controls.Add(this.txtCargo);
            this.panelRegistros.Controls.Add(this.panel6);
            this.panelRegistros.Controls.Add(this.txtDireccion);
            this.panelRegistros.Controls.Add(this.panel5);
            this.panelRegistros.Controls.Add(this.txtCedula);
            this.panelRegistros.Controls.Add(this.panel4);
            this.panelRegistros.Controls.Add(this.txtNombresCompletos);
            this.panelRegistros.Controls.Add(this.label9);
            this.panelRegistros.Controls.Add(this.lblSueldoPorHora);
            this.panelRegistros.Controls.Add(this.label8);
            this.panelRegistros.Controls.Add(this.label11);
            this.panelRegistros.Controls.Add(this.label1);
            this.panelRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistros.Location = new System.Drawing.Point(35, 121);
            this.panelRegistros.Name = "panelRegistros";
            this.panelRegistros.Size = new System.Drawing.Size(1141, 403);
            this.panelRegistros.TabIndex = 3;
            this.panelRegistros.Visible = false;
            // 
            // panelBtnGuardarPersonal
            // 
            this.panelBtnGuardarPersonal.Controls.Add(this.btnGuardarPersonal);
            this.panelBtnGuardarPersonal.Controls.Add(this.btnActualizarPersonal);
            this.panelBtnGuardarPersonal.Location = new System.Drawing.Point(215, 255);
            this.panelBtnGuardarPersonal.Name = "panelBtnGuardarPersonal";
            this.panelBtnGuardarPersonal.Size = new System.Drawing.Size(332, 73);
            this.panelBtnGuardarPersonal.TabIndex = 24;
            // 
            // panelCargos
            // 
            this.panelCargos.Controls.Add(this.flowLayoutPanel2);
            this.panelCargos.Controls.Add(this.panel10);
            this.panelCargos.Controls.Add(this.txtSueldoN);
            this.panelCargos.Controls.Add(this.panel11);
            this.panelCargos.Controls.Add(this.txtCargoN);
            this.panelCargos.Controls.Add(this.label5);
            this.panelCargos.Controls.Add(this.label7);
            this.panelCargos.Location = new System.Drawing.Point(710, 119);
            this.panelCargos.Name = "panelCargos";
            this.panelCargos.Size = new System.Drawing.Size(429, 209);
            this.panelCargos.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnGuardarCargo);
            this.flowLayoutPanel2.Controls.Add(this.btnActualizarCargo);
            this.flowLayoutPanel2.Controls.Add(this.btnVolverCargos);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 126);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(409, 73);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // btnVolverCargos
            // 
            this.btnVolverCargos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolverCargos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVolverCargos.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVolverCargos.FlatAppearance.BorderSize = 5;
            this.btnVolverCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverCargos.ForeColor = System.Drawing.Color.White;
            this.btnVolverCargos.Location = new System.Drawing.Point(326, 3);
            this.btnVolverCargos.Name = "btnVolverCargos";
            this.btnVolverCargos.Size = new System.Drawing.Size(62, 61);
            this.btnVolverCargos.TabIndex = 18;
            this.btnVolverCargos.Text = "⬅";
            this.btnVolverCargos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolverCargos.UseVisualStyleBackColor = false;
            this.btnVolverCargos.Click += new System.EventHandler(this.btnVolverCargos_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel10.Location = new System.Drawing.Point(157, 93);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 4);
            this.panel10.TabIndex = 22;
            // 
            // txtSueldoN
            // 
            this.txtSueldoN.BackColor = System.Drawing.Color.Thistle;
            this.txtSueldoN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoN.Location = new System.Drawing.Point(157, 69);
            this.txtSueldoN.Name = "txtSueldoN";
            this.txtSueldoN.Size = new System.Drawing.Size(261, 23);
            this.txtSueldoN.TabIndex = 21;
            this.txtSueldoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoN_KeyPress);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel11.Location = new System.Drawing.Point(157, 55);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(261, 4);
            this.panel11.TabIndex = 20;
            // 
            // txtCargoN
            // 
            this.txtCargoN.AcceptsTab = true;
            this.txtCargoN.BackColor = System.Drawing.Color.Thistle;
            this.txtCargoN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargoN.Location = new System.Drawing.Point(157, 32);
            this.txtCargoN.Name = "txtCargoN";
            this.txtCargoN.Size = new System.Drawing.Size(261, 23);
            this.txtCargoN.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(73, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sueldo x Hora:";
            // 
            // btnVolverPersonal
            // 
            this.btnVolverPersonal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVolverPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVolverPersonal.FlatAppearance.BorderSize = 5;
            this.btnVolverPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverPersonal.ForeColor = System.Drawing.Color.White;
            this.btnVolverPersonal.Location = new System.Drawing.Point(710, 0);
            this.btnVolverPersonal.Name = "btnVolverPersonal";
            this.btnVolverPersonal.Size = new System.Drawing.Size(62, 82);
            this.btnVolverPersonal.TabIndex = 17;
            this.btnVolverPersonal.Text = "⬅";
            this.btnVolverPersonal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolverPersonal.UseVisualStyleBackColor = false;
            this.btnVolverPersonal.Click += new System.EventHandler(this.btnVolverPersonal_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarCargo.Location = new System.Drawing.Point(488, 174);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(178, 37);
            this.btnAgregarCargo.TabIndex = 4;
            this.btnAgregarCargo.Text = "+ Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel9.Location = new System.Drawing.Point(221, 247);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 4);
            this.panel9.TabIndex = 15;
            // 
            // txtSueldoxHora
            // 
            this.txtSueldoxHora.BackColor = System.Drawing.Color.Thistle;
            this.txtSueldoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoxHora.Location = new System.Drawing.Point(221, 224);
            this.txtSueldoxHora.Name = "txtSueldoxHora";
            this.txtSueldoxHora.Size = new System.Drawing.Size(261, 23);
            this.txtSueldoxHora.TabIndex = 14;
            this.txtSueldoxHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoxHora_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel8.Location = new System.Drawing.Point(221, 202);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 4);
            this.panel8.TabIndex = 13;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.Thistle;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Location = new System.Drawing.Point(221, 179);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(261, 23);
            this.txtCargo.TabIndex = 12;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel6.Location = new System.Drawing.Point(221, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 4);
            this.panel6.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Thistle;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Location = new System.Drawing.Point(221, 126);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(261, 23);
            this.txtDireccion.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel5.Location = new System.Drawing.Point(221, 95);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(261, 4);
            this.panel5.TabIndex = 7;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Thistle;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Location = new System.Drawing.Point(221, 72);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(261, 23);
            this.txtCedula.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel4.Location = new System.Drawing.Point(221, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 4);
            this.panel4.TabIndex = 5;
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.BackColor = System.Drawing.Color.Thistle;
            this.txtNombresCompletos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresCompletos.Location = new System.Drawing.Point(221, 22);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.Size = new System.Drawing.Size(445, 23);
            this.txtNombresCompletos.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(137, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cargo:";
            // 
            // lblSueldoPorHora
            // 
            this.lblSueldoPorHora.AutoSize = true;
            this.lblSueldoPorHora.ForeColor = System.Drawing.Color.White;
            this.lblSueldoPorHora.Location = new System.Drawing.Point(67, 222);
            this.lblSueldoPorHora.Name = "lblSueldoPorHora";
            this.lblSueldoPorHora.Size = new System.Drawing.Size(142, 25);
            this.lblSueldoPorHora.TabIndex = 3;
            this.lblSueldoPorHora.Text = "Sueldo x Hora:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(110, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dirección:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(16, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Cédula de Identidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            // 
            // dataGridViewListadoCargos
            // 
            this.dataGridViewListadoCargos.AllowUserToAddRows = false;
            this.dataGridViewListadoCargos.AllowUserToDeleteRows = false;
            this.dataGridViewListadoCargos.AllowUserToOrderColumns = true;
            this.dataGridViewListadoCargos.AllowUserToResizeRows = false;
            this.dataGridViewListadoCargos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(154)))), ((int)(((byte)(243)))));
            this.dataGridViewListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoCargos.ColumnHeadersVisible = false;
            this.dataGridViewListadoCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EditarC});
            this.dataGridViewListadoCargos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewListadoCargos.Location = new System.Drawing.Point(965, 455);
            this.dataGridViewListadoCargos.Name = "dataGridViewListadoCargos";
            this.dataGridViewListadoCargos.RowHeadersWidth = 51;
            this.dataGridViewListadoCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewListadoCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewListadoCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewListadoCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewListadoCargos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewListadoCargos.RowTemplate.Height = 24;
            this.dataGridViewListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListadoCargos.Size = new System.Drawing.Size(172, 105);
            this.dataGridViewListadoCargos.TabIndex = 25;
            this.dataGridViewListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListadoCargos_CellClick);
            // 
            // EditarC
            // 
            this.EditarC.HeaderText = "";
            this.EditarC.Image = global::Control_Empleados.Properties.Resources.edit;
            this.EditarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.EditarC.MinimumWidth = 6;
            this.EditarC.Name = "EditarC";
            this.EditarC.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "EditarCargos";
            this.dataGridViewImageColumn1.Image = global::Control_Empleados.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Control_Empleados.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Control_Empleados.Properties.Resources.edit;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardarPersonal.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardarPersonal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarPersonal.BorderRadius = 20;
            this.btnGuardarPersonal.BorderSize = 0;
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(150, 61);
            this.btnGuardarPersonal.TabIndex = 0;
            this.btnGuardarPersonal.Text = "GUARDAR";
            this.btnGuardarPersonal.TextColor = System.Drawing.Color.White;
            this.btnGuardarPersonal.UseVisualStyleBackColor = false;
            this.btnGuardarPersonal.Click += new System.EventHandler(this.btnGuardarPersonal_Click);
            // 
            // btnActualizarPersonal
            // 
            this.btnActualizarPersonal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarPersonal.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarPersonal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarPersonal.BorderRadius = 20;
            this.btnActualizarPersonal.BorderSize = 0;
            this.btnActualizarPersonal.FlatAppearance.BorderSize = 0;
            this.btnActualizarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPersonal.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPersonal.Location = new System.Drawing.Point(159, 3);
            this.btnActualizarPersonal.Name = "btnActualizarPersonal";
            this.btnActualizarPersonal.Size = new System.Drawing.Size(161, 61);
            this.btnActualizarPersonal.TabIndex = 1;
            this.btnActualizarPersonal.Text = "ACTUALIZAR";
            this.btnActualizarPersonal.TextColor = System.Drawing.Color.White;
            this.btnActualizarPersonal.UseVisualStyleBackColor = false;
            this.btnActualizarPersonal.Click += new System.EventHandler(this.btnActualizarPersonal_Click);
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardarCargo.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardarCargo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarCargo.BorderRadius = 0;
            this.btnGuardarCargo.BorderSize = 0;
            this.btnGuardarCargo.FlatAppearance.BorderSize = 0;
            this.btnGuardarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCargo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCargo.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(150, 61);
            this.btnGuardarCargo.TabIndex = 0;
            this.btnGuardarCargo.Text = "GUARDAR";
            this.btnGuardarCargo.TextColor = System.Drawing.Color.White;
            this.btnGuardarCargo.UseVisualStyleBackColor = false;
            this.btnGuardarCargo.Click += new System.EventHandler(this.btnGuardarCargo_Click);
            // 
            // btnActualizarCargo
            // 
            this.btnActualizarCargo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarCargo.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizarCargo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarCargo.BorderRadius = 0;
            this.btnActualizarCargo.BorderSize = 0;
            this.btnActualizarCargo.FlatAppearance.BorderSize = 0;
            this.btnActualizarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCargo.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCargo.Location = new System.Drawing.Point(159, 3);
            this.btnActualizarCargo.Name = "btnActualizarCargo";
            this.btnActualizarCargo.Size = new System.Drawing.Size(161, 61);
            this.btnActualizarCargo.TabIndex = 1;
            this.btnActualizarCargo.Text = "ACTUALIZAR";
            this.btnActualizarCargo.TextColor = System.Drawing.Color.White;
            this.btnActualizarCargo.UseVisualStyleBackColor = false;
            this.btnActualizarCargo.Click += new System.EventHandler(this.btnActualizarCargo_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicio.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInicio.BorderRadius = 20;
            this.btnInicio.BorderSize = 0;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(3, 14);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(150, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextColor = System.Drawing.Color.White;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFinal.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFinal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinal.BorderRadius = 20;
            this.btnFinal.BorderSize = 0;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(159, 14);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(150, 40);
            this.btnFinal.TabIndex = 0;
            this.btnFinal.Text = "Final";
            this.btnFinal.TextColor = System.Drawing.Color.White;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAnterior.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAnterior.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnterior.BorderRadius = 20;
            this.btnAnterior.BorderSize = 0;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(12, 14);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(150, 40);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextColor = System.Drawing.Color.White;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiguiente.BorderRadius = 20;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(250, 14);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(150, 40);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewListadoCargos);
            this.Controls.Add(this.panelRegistros);
            this.Controls.Add(this.dataGridViewListadoPersonal);
            this.Controls.Add(this.lblPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1239, 671);
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoPersonal)).EndInit();
            this.lblPaginado.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelBotonesPaginado.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegistros.ResumeLayout(false);
            this.panelRegistros.PerformLayout();
            this.panelBtnGuardarPersonal.ResumeLayout(false);
            this.panelCargos.ResumeLayout(false);
            this.panelCargos.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListadoPersonal;
        private System.Windows.Forms.Panel lblPaginado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRegistros;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldoxHora;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSueldoPorHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAgregar;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnVolverPersonal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPaginaActual;
        private UI.UIButton btnAnterior;
        private UI.UIButton btnSiguiente;
        private System.Windows.Forms.Label lblTotalPaginas;
        private System.Windows.Forms.Panel panelCargos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private UI.UIButton btnGuardarCargo;
        private UI.UIButton btnActualizarCargo;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSueldoN;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtCargoN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelBotonesPaginado;
        private System.Windows.Forms.FlowLayoutPanel panelBtnGuardarPersonal;
        private UI.UIButton btnGuardarPersonal;
        private UI.UIButton btnActualizarPersonal;
        private System.Windows.Forms.DataGridView dataGridViewListadoCargos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        //private System.Windows.Forms.DataGridViewImageColumn EditarCargos;
        private System.Windows.Forms.Button btnVolverCargos;
        private System.Windows.Forms.DataGridViewImageColumn EditarC;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn EditarP;
        private System.Windows.Forms.DataGridViewImageColumn EliminarP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private UI.UIButton btnInicio;
        private UI.UIButton btnFinal;
    }
}
