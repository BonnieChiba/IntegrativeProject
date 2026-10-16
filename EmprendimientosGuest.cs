using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class EmprendimientosGuest : Form
    {
        public EmprendimientosGuest()
        {
            InitializeComponent();
        }

        private void EventosText_Click(object sender, EventArgs e)
        {

        }

        private void EmprendimientosText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Nombre1Text_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AbrirProducto(object sender, EventArgs e)
        {
            Producto PantallaPrincipalProducto = new Producto();
            PantallaPrincipalProducto.Show();
            this.Hide();
        }
        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion PantallaPrincipalIniciarSesion = new IniciarSesion();
            PantallaPrincipalIniciarSesion.Show();
            this.Hide();
        }
        private void Empre3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BuscarTexboxClick(object sender, EventArgs e)
        {
            BuscarTextbox.Clear();
        }

        private void BuscarTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoticiasText_Click(object sender, EventArgs e)
        {
            Noticias PantallaPrincipalNoticias = new Noticias();
            PantallaPrincipalNoticias.Show();
            this.Hide();
        }
    }
}
