using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class CrearCuentaEmprendedor : Form
    {
        public CrearCuentaEmprendedor()
        {
            InitializeComponent();
        }

        private void CrearCuentaText_Click(object sender, EventArgs e)
        {

        }

        private void EmprendedorText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarmeBoton_Click(object sender, EventArgs e)
        {
            IniciarSesion PantallaPrincipal = new IniciarSesion();
            PantallaPrincipal.Show();
            this.Hide();
        }
    }
}
