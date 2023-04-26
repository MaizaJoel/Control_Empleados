namespace Control_Empleados.Presentacion.AsistenteDeInstalación
{
    partial class InstalacionBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPictureBox1 = new Control_Empleados.UI.UIPictureBox();
            this.lbl_nombre_login = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiPictureBox1);
            this.panel1.Controls.Add(this.lbl_nombre_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 144);
            this.panel1.TabIndex = 2;
            // 
            // uiPictureBox1
            // 
            this.uiPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.uiPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.uiPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.uiPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.uiPictureBox1.BorderSize = 2;
            this.uiPictureBox1.GradientAngle = 50F;
            this.uiPictureBox1.Image = global::Control_Empleados.Properties.Resources.Logo_white;
            this.uiPictureBox1.Location = new System.Drawing.Point(212, 8);
            this.uiPictureBox1.Name = "uiPictureBox1";
            this.uiPictureBox1.Size = new System.Drawing.Size(127, 127);
            this.uiPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiPictureBox1.TabIndex = 2;
            this.uiPictureBox1.TabStop = false;
            // 
            // lbl_nombre_login
            // 
            this.lbl_nombre_login.Font = new System.Drawing.Font("Vivaldi", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_login.Location = new System.Drawing.Point(3, 5);
            this.lbl_nombre_login.Name = "lbl_nombre_login";
            this.lbl_nombre_login.Size = new System.Drawing.Size(255, 136);
            this.lbl_nombre_login.TabIndex = 1;
            this.lbl_nombre_login.Text = "Freesias \r\nce";
            this.lbl_nombre_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(241, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 611);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(500, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSTALAR SERVIDOR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // InstalacionBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 895);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InstalacionBD";
            this.Text = "InstalacionBD";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UI.UIPictureBox uiPictureBox1;
        private System.Windows.Forms.Label lbl_nombre_login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}