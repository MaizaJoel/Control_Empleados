
namespace Control_Empleados.Presentacion
{
    partial class Asistencia
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
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblNúmeroSemana = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.DateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.MediumPurple;
            this.Panel5.Controls.Add(this.Label5);
            this.Panel5.Controls.Add(this.Label6);
            this.Panel5.Controls.Add(this.lblNúmeroSemana);
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Controls.Add(this.DateTimePickerDesde);
            this.Panel5.Controls.Add(this.DateTimePickerHasta);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Margin = new System.Windows.Forms.Padding(4);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(1316, 100);
            this.Panel5.TabIndex = 612;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(7, 37);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 29);
            this.Label5.TabIndex = 600;
            this.Label5.Text = "Del";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(226, 36);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 29);
            this.Label6.TabIndex = 600;
            this.Label6.Text = "al";
            // 
            // lblNúmeroSemana
            // 
            this.lblNúmeroSemana.AutoSize = true;
            this.lblNúmeroSemana.BackColor = System.Drawing.Color.Transparent;
            this.lblNúmeroSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblNúmeroSemana.ForeColor = System.Drawing.Color.White;
            this.lblNúmeroSemana.Location = new System.Drawing.Point(601, 36);
            this.lblNúmeroSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNúmeroSemana.Name = "lblNúmeroSemana";
            this.lblNúmeroSemana.Size = new System.Drawing.Size(28, 29);
            this.lblNúmeroSemana.TabIndex = 600;
            this.lblNúmeroSemana.Text = "#";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(426, 36);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(159, 29);
            this.Label7.TabIndex = 600;
            this.Label7.Text = "Semana Nº:";
            // 
            // DateTimePickerDesde
            // 
            this.DateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDesde.Location = new System.Drawing.Point(67, 36);
            this.DateTimePickerDesde.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerDesde.Name = "DateTimePickerDesde";
            this.DateTimePickerDesde.Size = new System.Drawing.Size(144, 30);
            this.DateTimePickerDesde.TabIndex = 602;
            this.DateTimePickerDesde.Value = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            // 
            // DateTimePickerHasta
            // 
            this.DateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerHasta.Location = new System.Drawing.Point(273, 36);
            this.DateTimePickerHasta.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerHasta.Name = "DateTimePickerHasta";
            this.DateTimePickerHasta.Size = new System.Drawing.Size(144, 30);
            this.DateTimePickerHasta.TabIndex = 602;
            this.DateTimePickerHasta.Value = new System.DateTime(2024, 4, 7, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibilityKeyMap = null;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1316, 661);
            this.reportViewer1.TabIndex = 613;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Panel5);
            this.Name = "Asistencia";
            this.Size = new System.Drawing.Size(1316, 761);
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel5;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblNúmeroSemana;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker DateTimePickerDesde;
        internal System.Windows.Forms.DateTimePicker DateTimePickerHasta;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
    }
}
