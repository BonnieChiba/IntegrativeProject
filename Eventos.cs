using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {

        }

        private void Corazon_Click(object sender, EventArgs e)
        {
            var pic = (PictureBox)sender;

            if (pic.Tag?.ToString() == "lleno")
            {
                pic.Image = Properties.Resources.heart;
                pic.Tag = "cora vacio";
            }
            else
            {
                pic.Image = Properties.Resources.heart_filled;
                pic.Tag = "cora lleno";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void piclogo_Click(object sender, EventArgs e)
        {

        }

        private void pnlnav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
