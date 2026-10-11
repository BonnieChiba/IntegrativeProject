namespace PITCHER
{
    public partial class CrearCuentaInversor : Form
    {
        public CrearCuentaInversor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LineaSuperiorPicturebox_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {
            CrearCuentaEmprendedor PantallaPrincipal = new CrearCuentaEmprendedor();
            PantallaPrincipal.Show();
            this.Hide();
        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
