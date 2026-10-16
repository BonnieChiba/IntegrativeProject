using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PITCHER
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void Panelito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LineaSuperiorIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarmeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RolSelect formRolSelect = new RolSelect();
            formRolSelect.Show();
            this.Hide();
        }

        private void IniciarSesiónBoton_Click(object sender, EventArgs e)
        {
            EmprendimientosGuest PantallaPrincipalEmprendimientoGuest = new EmprendimientosGuest();
            PantallaPrincipalEmprendimientoGuest.Show();
                this.Hide();
        }
    }
}
