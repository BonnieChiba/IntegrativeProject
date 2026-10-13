using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class RolSelect : Form
    {
        public RolSelect()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e) // (o el nombre que tenga tu panel azul)
        {
            CrearCuentaInversor formInversor = new CrearCuentaInversor();
            formInversor.Show();
            this.Hide();
        }
        private void panel2_Click(object sender, EventArgs e) // (o el nombre que tenga tu panel naranja)
        {
            CrearCuentaEmprendedor formEmprendedor = new CrearCuentaEmprendedor();
            formEmprendedor.Show();
            this.Hide();
        }
        private void IniciarSesionLabel_Click(object sender, EventArgs e) // (o el nombre que tenga tu control)
        {
            IniciarSesion formLogin = new IniciarSesion();
            formLogin.Show();
            this.Hide(); // O this.Close(); para cerrar la ventana actual
        }
    }
}
