using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class Noticias : Form
    {
        public Noticias()
        {
            InitializeComponent();
        }

        private void Noticias_Load(object sender, EventArgs e)
        {

        }

        private void lblTxtN2_Click(object sender, EventArgs e)
        {

        }

        private void btnEmprendimientos_Click(object sender, EventArgs e)
        {
            EmprendimientosGuest PantallaPrincipalEmprendimientosGuest = new EmprendimientosGuest();
            PantallaPrincipalEmprendimientosGuest.Show();
            this.Hide();
        }
    }
}
