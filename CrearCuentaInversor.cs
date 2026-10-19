using MySqlConnector;
using System.Data;

namespace PITCHER
{
    public partial class CrearCuentaInversor : Form
    {
        private DBConn dbconn;                                          //Conectar
        private MySqlDataAdapter investorsDA = new MySqlDataAdapter();  //Extraer
        private DataTable investortable = new DataTable();              //Almacenar
        private BindingSource investorDataBind = new BindingSource();   //Vincular
        private int maxID = 0;

        public CrearCuentaInversor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evita que el diseñador de Visual Studio intente conectarse a MySQL
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            {
                return;
            }

            this.LoadDBCommands();
            this.LoadData();
            this.BindControls();
            this.clearTextBoxes();
        }

        private void LoadDBCommands()
        {
            investorsDA.SelectCommand = new MySqlCommand("SELECT idInvestor, name, lastName, `user`, city, email, rfc, termsInvestor FROM integrative.investor ORDER BY idInvestor");

            investorsDA.InsertCommand = new MySqlCommand("INSERT INTO integrative.investor (name, lastName, `user`, city, email, rfc, termsInvestor, `password`) VALUES (@name, @lastName, @user, @city, @email, @rfc, @termsInvestor, @password)");
        }

        private void LoadData()
        {
            dbconn = new DBConn();
            investorsDA.SelectCommand.Connection = dbconn.dbConnection;
            try
            {
                investorsDA.Fill(investortable);
                object computeResult = investortable.Compute("MAX(idInvestor)", "");
                if (computeResult != DBNull.Value)
                {
                    maxID = Convert.ToInt32(computeResult);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindControls()
        {
            investorDataBind.DataSource = investortable;

            //.Add("ControlProperty", BindSource, "DataField", enableFormatting, UpdateMode, NullValue, CustomFormatString)
            this.NombreTextbox.DataBindings.Add("Text", investorDataBind, "name", false, DataSourceUpdateMode.OnPropertyChanged, "");
            this.ApellidoTextbox.DataBindings.Add("Text", investorDataBind, "lastName", false, DataSourceUpdateMode.OnPropertyChanged, "");
            this.UsuarioTexto.DataBindings.Add("Text", investorDataBind, "user", false, DataSourceUpdateMode.OnPropertyChanged, "");
            this.CiudadInversorTextBox.DataBindings.Add("Text", investorDataBind, "city", false, DataSourceUpdateMode.OnPropertyChanged, "");
            this.EmailTextbox.DataBindings.Add("Text", investorDataBind, "email", false, DataSourceUpdateMode.OnPropertyChanged, "");

            // Texto gris de ejemplo (no modifica la propiedad Text)
            this.NombreTextbox.PlaceholderText = "Nombre";
            this.ApellidoTextbox.PlaceholderText = "Apellido";
            this.UsuarioTexto.PlaceholderText = "Usuario";
            this.CiudadInversorTextBox.PlaceholderText = "Ciudad";
            this.EmailTextbox.PlaceholderText = "Email";
            this.ContraseñaTextBox.PlaceholderText = "Contraseña";
            this.ConfirmarContraseñaTextbox.PlaceholderText = "Confirmar contraseña";
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            this.ConfirmarContraseñaTextbox.UseSystemPasswordChar = true;
        }

        // ==================== BOTÓN REGISTRARSE ====================
        private void RegistrarseBoton_Click(object sender, EventArgs e)
        {
            if (this.Validar_campos() == false)
            {
                return;
            }

            try
            {
                using (DBConn dbTemp = new DBConn())
                {
                    investorsDA.InsertCommand.Connection = dbTemp.dbConnection;
                    investorsDA.InsertCommand.Connection.Open();
                    investorsDA.InsertCommand.Parameters.Clear();
                    investorsDA.InsertCommand.Parameters.AddRange(new[] {
                        new MySqlParameter("@name", NombreTextbox.Text.Trim()),
                        new MySqlParameter("@lastName", ApellidoTextbox.Text.Trim()),
                        new MySqlParameter("@user", UsuarioTexto.Text.Trim()),
                        new MySqlParameter("@city", CiudadInversorTextBox.Text.Trim()),
                        new MySqlParameter("@email", EmailTextbox.Text.Trim()),
                        new MySqlParameter("@rfc", RFCInversorTextbox.Text.Trim().ToUpper()),
                        new MySqlParameter("@termsInvestor", TerminosCheckbox.Checked),
                        new MySqlParameter("@password", ContraseñaTextBox.Text)
                        // Recomendado: BCrypt.Net.BCrypt.HashPassword(ContraseñaTextBox.Text)
                    });

                    investorsDA.InsertCommand.ExecuteNonQuery();

                    investortable.Clear();
                    investorsDA.Fill(investortable);
                    maxID = Convert.ToInt32(investortable.Compute("MAX(idInvestor)", ""));

                    this.clearTextBoxes();
                    MessageBox.Show("Registro insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Solo se avanza si el INSERT salió bien
                CrearCuentaEmprendedor PantallaPrincipal = new CrearCuentaEmprendedor();
                PantallaPrincipal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al insertar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== VALIDACIÓN ====================
        private bool Validar_campos()
        {
            if (string.IsNullOrWhiteSpace(NombreTextbox.Text))
            {
                MessageBox.Show("El campo de nombre está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.NombreTextbox.Select();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(ApellidoTextbox.Text))
            {
                MessageBox.Show("El campo de apellido está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ApellidoTextbox.Select();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(UsuarioTexto.Text))
            {
                MessageBox.Show("El campo de usuario está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.UsuarioTexto.Select();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(CiudadInversorTextBox.Text))
            {
                MessageBox.Show("El campo de ciudad está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.CiudadInversorTextBox.Select();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(EmailTextbox.Text) || !EmailTextbox.Text.Contains("@"))
            {
                MessageBox.Show("Ingresa un email válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.EmailTextbox.Select();
                return false;
            }
            else if (!RFCInversorTextbox.MaskCompleted)
            {
                MessageBox.Show("El RFC está incompleto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.RFCInversorTextbox.Select();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MessageBox.Show("El campo de contraseña está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ContraseñaTextBox.Select();
                return false;
            }
            else if (ContraseñaTextBox.Text != ConfirmarContraseñaTextbox.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ConfirmarContraseñaTextbox.Select();
                return false;
            }
            else if (!TerminosCheckbox.Checked)
            {
                MessageBox.Show("Debes aceptar los términos y condiciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.TerminosCheckbox.Select();
                return false;
            }
            else
            {
                return true;
            }
        }

        // ==================== LIMPIAR CAMPOS ====================
        private void clearTextBoxes()
        {
            this.NombreTextbox.Text = "";
            this.ApellidoTextbox.Text = "";
            this.UsuarioTexto.Text = "";
            this.CiudadInversorTextBox.Text = "";
            this.EmailTextbox.Text = "";
            this.RFCInversorTextbox.Clear();
            this.ContraseñaTextBox.Text = "";
            this.ConfirmarContraseñaTextbox.Text = "";
            this.TerminosCheckbox.Checked = false;
        }

        // ==================== EVENTOS VACÍOS ORIGINALES ====================
        private void LineaSuperiorPicturebox_Click(object sender, EventArgs e)
        {
        }

        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CuadroBlancoTexto_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TerminosCheckbox_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}