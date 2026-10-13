using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void lblSobreTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEmprendimientos_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            EmprendimientosGuest volver = new EmprendimientosGuest();
            volver.Show();
            this.Close();
        }

        private void pnlNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

