
namespace Control_Empleados.UI
{
    partial class Form_Binding_Information
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
            this.components = new System.ComponentModel.Container();
            this.uiPictureBox1 = new Control_Empleados.UI.UIPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPictureBox1
            // 
            this.uiPictureBox1.BackgroundImage = global::Control_Empleados.Properties.Resources.i;
            this.uiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uiPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.uiPictureBox1.BorderColor = System.Drawing.Color.Transparent;
            this.uiPictureBox1.BorderColor2 = System.Drawing.Color.Transparent;
            this.uiPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.uiPictureBox1.BorderSize = 2;
            this.uiPictureBox1.Enabled = false;
            this.uiPictureBox1.GradientAngle = 50F;
            this.uiPictureBox1.Location = new System.Drawing.Point(2, -1);
            this.uiPictureBox1.Name = "uiPictureBox1";
            this.uiPictureBox1.Size = new System.Drawing.Size(97, 97);
            this.uiPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiPictureBox1.TabIndex = 0;
            this.uiPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solo se aceptan valores númericos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 5);
            this.panel1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Binding_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 88);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Binding_Information";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Binding_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UIPictureBox uiPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}