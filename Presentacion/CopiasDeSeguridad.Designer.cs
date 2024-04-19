
namespace Control_Empleados.Presentacion
{
    partial class CopiasDeSeguridad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopiaDeSeguridad = new Control_Empleados.UI.UIButton();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBoxAgregarRuta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogRuta = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxAgregarRuta);
            this.panel1.Controls.Add(this.btnCopiaDeSeguridad);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(346, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 384);
            this.panel1.TabIndex = 0;
            // 
            // btnCopiaDeSeguridad
            // 
            this.btnCopiaDeSeguridad.BackColor = System.Drawing.Color.Navy;
            this.btnCopiaDeSeguridad.BackgroundColor = System.Drawing.Color.Navy;
            this.btnCopiaDeSeguridad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCopiaDeSeguridad.BorderRadius = 20;
            this.btnCopiaDeSeguridad.BorderSize = 0;
            this.btnCopiaDeSeguridad.FlatAppearance.BorderSize = 0;
            this.btnCopiaDeSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiaDeSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiaDeSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnCopiaDeSeguridad.Location = new System.Drawing.Point(93, 287);
            this.btnCopiaDeSeguridad.Name = "btnCopiaDeSeguridad";
            this.btnCopiaDeSeguridad.Size = new System.Drawing.Size(324, 79);
            this.btnCopiaDeSeguridad.TabIndex = 2;
            this.btnCopiaDeSeguridad.Text = "Generar Copia de Seguridad";
            this.btnCopiaDeSeguridad.TextColor = System.Drawing.Color.White;
            this.btnCopiaDeSeguridad.UseVisualStyleBackColor = false;
            this.btnCopiaDeSeguridad.Click += new System.EventHandler(this.btnCopiaDeSeguridad_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRuta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(0, 79);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(497, 32);
            this.txtRuta.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(497, 79);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RUTA PARA COPIAS DE SEGURIDAD";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxAgregarRuta
            // 
            this.pictureBoxAgregarRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxAgregarRuta.Image = global::Control_Empleados.Properties.Resources.add;
            this.pictureBoxAgregarRuta.Location = new System.Drawing.Point(0, 111);
            this.pictureBoxAgregarRuta.Name = "pictureBoxAgregarRuta";
            this.pictureBoxAgregarRuta.Size = new System.Drawing.Size(497, 41);
            this.pictureBoxAgregarRuta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAgregarRuta.TabIndex = 4;
            this.pictureBoxAgregarRuta.TabStop = false;
            this.pictureBoxAgregarRuta.Click += new System.EventHandler(this.pictureBoxAgregarRuta_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 120);
            this.label1.TabIndex = 5;
            this.label1.Text = "Al guardar copias de seguridad la información será posible de restaurar hasta un " +
    "punto anterior existente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CopiasDeSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Name = "CopiasDeSeguridad";
            this.Size = new System.Drawing.Size(1381, 627);
            this.Load += new System.EventHandler(this.CopiasDeSeguridad_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregarRuta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UI.UIButton btnCopiaDeSeguridad;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAgregarRuta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRuta;
        private System.Windows.Forms.Timer timer1;
    }
}
