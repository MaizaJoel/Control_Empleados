using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Empleados.UI
{
    public partial class Form_Binding_Information : Form
    {
        public Form_Binding_Information()
        {
            InitializeComponent();
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color ColorAlertBox
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = label1.ForeColor = label2.ForeColor = value; }
        }

        public Image IconeAlertBox
        {
            get { return uiPictureBox1.Image; }
            set { uiPictureBox1 = value; }
        }

        public string TitleAlertBox
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string TextAlertBox
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

        private void PositionAlertBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }

        private void Form_Binding_Information_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            for (int i = 0; i < 487; i++)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width = panel1.Width + 2;
            if (panel1.Width == 487)
            {
                this.Close();
            }
        }
    }
}
