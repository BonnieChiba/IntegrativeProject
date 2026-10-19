namespace PITCHER
{
    partial class CrearCuentaInversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCuentaInversor));
            CuadroBlancoTexto = new Panel();
            RFCInversorTextbox = new MaskedTextBox();
            RegistrarseBoton = new Button();
            TerminosLink = new LinkLabel();
            TerminosCheckbox = new CheckBox();
            NombreTextbox = new TextBox();
            ApellidoTextbox = new TextBox();
            EmailTextbox = new TextBox();
            ConfirmarContraseñaTextbox = new TextBox();
            ContraseñaTextBox = new TextBox();
            UsuarioTexto = new TextBox();
            InversorTexto = new Label();
            CrearCuentaLabel = new Label();
            InvierteText = new Label();
            ChihuahuaText = new Label();
            BackgroundInversor = new Panel();
            RegresarInversor = new Button();
            LineaSuperiorPicturebox = new PictureBox();
            pictureBox1 = new PictureBox();
            CiudadInversorTextBox = new TextBox();
            CuadroBlancoTexto.SuspendLayout();
            BackgroundInversor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LineaSuperiorPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CuadroBlancoTexto
            // 
            CuadroBlancoTexto.BackColor = Color.White;
            CuadroBlancoTexto.Controls.Add(CiudadInversorTextBox);
            CuadroBlancoTexto.Controls.Add(RFCInversorTextbox);
            CuadroBlancoTexto.Controls.Add(RegistrarseBoton);
            CuadroBlancoTexto.Controls.Add(TerminosLink);
            CuadroBlancoTexto.Controls.Add(TerminosCheckbox);
            CuadroBlancoTexto.Controls.Add(NombreTextbox);
            CuadroBlancoTexto.Controls.Add(ApellidoTextbox);
            CuadroBlancoTexto.Controls.Add(EmailTextbox);
            CuadroBlancoTexto.Controls.Add(ConfirmarContraseñaTextbox);
            CuadroBlancoTexto.Controls.Add(ContraseñaTextBox);
            CuadroBlancoTexto.Controls.Add(UsuarioTexto);
            CuadroBlancoTexto.Controls.Add(InversorTexto);
            CuadroBlancoTexto.Controls.Add(CrearCuentaLabel);
            CuadroBlancoTexto.Location = new Point(285, 51);
            CuadroBlancoTexto.Name = "CuadroBlancoTexto";
            CuadroBlancoTexto.Size = new Size(423, 572);
            CuadroBlancoTexto.TabIndex = 0;
            CuadroBlancoTexto.Paint += CuadroBlancoTexto_Paint;
            // 
            // RFCInversorTextbox
            // 
            RFCInversorTextbox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RFCInversorTextbox.Location = new Point(74, 273);
            RFCInversorTextbox.Name = "RFCInversorTextbox";
            RFCInversorTextbox.Size = new Size(276, 23);
            RFCInversorTextbox.TabIndex = 11;
            RFCInversorTextbox.Text = "RFC";
            // 
            // RegistrarseBoton
            // 
            RegistrarseBoton.BackColor = Color.Blue;
            RegistrarseBoton.FlatStyle = FlatStyle.Flat;
            RegistrarseBoton.ForeColor = Color.White;
            RegistrarseBoton.Location = new Point(100, 508);
            RegistrarseBoton.Name = "RegistrarseBoton";
            RegistrarseBoton.Size = new Size(224, 28);
            RegistrarseBoton.TabIndex = 10;
            RegistrarseBoton.Text = "Registrarme";
            RegistrarseBoton.UseVisualStyleBackColor = false;
            RegistrarseBoton.Click += RegistrarseBoton_Click;
            // 
            // TerminosLink
            // 
            TerminosLink.AutoSize = true;
            TerminosLink.Location = new Point(145, 480);
            TerminosLink.Name = "TerminosLink";
            TerminosLink.Size = new Size(149, 15);
            TerminosLink.TabIndex = 9;
            TerminosLink.TabStop = true;
            TerminosLink.Text = "Ver terminos y condiciones";
            // 
            // TerminosCheckbox
            // 
            TerminosCheckbox.AutoSize = true;
            TerminosCheckbox.Location = new Point(123, 458);
            TerminosCheckbox.Name = "TerminosCheckbox";
            TerminosCheckbox.Size = new Size(190, 19);
            TerminosCheckbox.TabIndex = 8;
            TerminosCheckbox.Text = "Acepto terminos y condiciones";
            TerminosCheckbox.UseVisualStyleBackColor = true;
            TerminosCheckbox.CheckedChanged += TerminosCheckbox_CheckedChanged;
            // 
            // NombreTextbox
            // 
            NombreTextbox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NombreTextbox.Location = new Point(74, 98);
            NombreTextbox.Name = "NombreTextbox";
            NombreTextbox.Size = new Size(276, 23);
            NombreTextbox.TabIndex = 7;
            NombreTextbox.Text = "Nombre";
            // 
            // ApellidoTextbox
            // 
            ApellidoTextbox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApellidoTextbox.Location = new Point(74, 141);
            ApellidoTextbox.Name = "ApellidoTextbox";
            ApellidoTextbox.Size = new Size(276, 23);
            ApellidoTextbox.TabIndex = 6;
            ApellidoTextbox.Text = "Apellido";
            // 
            // EmailTextbox
            // 
            EmailTextbox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTextbox.Location = new Point(74, 226);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(276, 23);
            EmailTextbox.TabIndex = 5;
            EmailTextbox.Text = "Email";
            // 
            // ConfirmarContraseñaTextbox
            // 
            ConfirmarContraseñaTextbox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmarContraseñaTextbox.Location = new Point(74, 415);
            ConfirmarContraseñaTextbox.Name = "ConfirmarContraseñaTextbox";
            ConfirmarContraseñaTextbox.Size = new Size(276, 23);
            ConfirmarContraseñaTextbox.TabIndex = 4;
            ConfirmarContraseñaTextbox.Text = "Confirmar contraseña";
            // 
            // ContraseñaTextBox
            // 
            ContraseñaTextBox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContraseñaTextBox.Location = new Point(74, 369);
            ContraseñaTextBox.Name = "ContraseñaTextBox";
            ContraseñaTextBox.Size = new Size(276, 23);
            ContraseñaTextBox.TabIndex = 3;
            ContraseñaTextBox.Text = "Contraseña";
            ContraseñaTextBox.TextChanged += ContraseñaTextBox_TextChanged;
            // 
            // UsuarioTexto
            // 
            UsuarioTexto.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsuarioTexto.Location = new Point(74, 184);
            UsuarioTexto.Name = "UsuarioTexto";
            UsuarioTexto.Size = new Size(276, 23);
            UsuarioTexto.TabIndex = 2;
            UsuarioTexto.Text = "Usuario";
            // 
            // InversorTexto
            // 
            InversorTexto.AutoSize = true;
            InversorTexto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InversorTexto.ForeColor = Color.FromArgb(0, 192, 192);
            InversorTexto.Location = new Point(180, 62);
            InversorTexto.Name = "InversorTexto";
            InversorTexto.Size = new Size(61, 20);
            InversorTexto.TabIndex = 1;
            InversorTexto.Text = "Inversor";
            // 
            // CrearCuentaLabel
            // 
            CrearCuentaLabel.AutoSize = true;
            CrearCuentaLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CrearCuentaLabel.Location = new Point(123, 25);
            CrearCuentaLabel.Name = "CrearCuentaLabel";
            CrearCuentaLabel.Size = new Size(171, 37);
            CrearCuentaLabel.TabIndex = 0;
            CrearCuentaLabel.Text = "Crear Cuenta";
            // 
            // InvierteText
            // 
            InvierteText.AutoSize = true;
            InvierteText.BackColor = Color.Transparent;
            InvierteText.Font = new Font("Corbel", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvierteText.ForeColor = Color.White;
            InvierteText.Location = new Point(807, 204);
            InvierteText.Name = "InvierteText";
            InvierteText.Size = new Size(232, 177);
            InvierteText.TabIndex = 1;
            InvierteText.Text = "Invierte\r\nComparte\r\nExpande";
            // 
            // ChihuahuaText
            // 
            ChihuahuaText.AutoSize = true;
            ChihuahuaText.Font = new Font("Ink Free", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChihuahuaText.ForeColor = Color.White;
            ChihuahuaText.Location = new Point(807, 381);
            ChihuahuaText.Name = "ChihuahuaText";
            ChihuahuaText.Size = new Size(208, 29);
            ChihuahuaText.TabIndex = 2;
            ChihuahuaText.Text = "Chihuahua, México";
            // 
            // BackgroundInversor
            // 
            BackgroundInversor.BackColor = Color.Blue;
            BackgroundInversor.Controls.Add(RegresarInversor);
            BackgroundInversor.Controls.Add(ChihuahuaText);
            BackgroundInversor.Controls.Add(InvierteText);
            BackgroundInversor.Controls.Add(CuadroBlancoTexto);
            BackgroundInversor.Controls.Add(LineaSuperiorPicturebox);
            BackgroundInversor.Controls.Add(pictureBox1);
            BackgroundInversor.Location = new Point(25, 28);
            BackgroundInversor.Name = "BackgroundInversor";
            BackgroundInversor.Size = new Size(1300, 656);
            BackgroundInversor.TabIndex = 0;
            // 
            // RegresarInversor
            // 
            RegresarInversor.Image = (Image)resources.GetObject("RegresarInversor.Image");
            RegresarInversor.Location = new Point(72, 30);
            RegresarInversor.Name = "RegresarInversor";
            RegresarInversor.Size = new Size(61, 67);
            RegresarInversor.TabIndex = 4;
            RegresarInversor.UseVisualStyleBackColor = true;
            // 
            // LineaSuperiorPicturebox
            // 
            LineaSuperiorPicturebox.Image = (Image)resources.GetObject("LineaSuperiorPicturebox.Image");
            LineaSuperiorPicturebox.Location = new Point(20, -50);
            LineaSuperiorPicturebox.Name = "LineaSuperiorPicturebox";
            LineaSuperiorPicturebox.Size = new Size(1280, 254);
            LineaSuperiorPicturebox.SizeMode = PictureBoxSizeMode.AutoSize;
            LineaSuperiorPicturebox.TabIndex = 1;
            LineaSuperiorPicturebox.TabStop = false;
            LineaSuperiorPicturebox.Click += LineaSuperiorPicturebox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 246);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CiudadInversorTextBox
            // 
            CiudadInversorTextBox.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CiudadInversorTextBox.Location = new Point(74, 320);
            CiudadInversorTextBox.Name = "CiudadInversorTextBox";
            CiudadInversorTextBox.Size = new Size(276, 23);
            CiudadInversorTextBox.TabIndex = 12;
            CiudadInversorTextBox.Text = "Ciudad";
            // 
            // CrearCuentaInversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(BackgroundInversor);
            Name = "CrearCuentaInversor";
            Text = "Form1";
            Load += Form1_Load;
            CuadroBlancoTexto.ResumeLayout(false);
            CuadroBlancoTexto.PerformLayout();
            BackgroundInversor.ResumeLayout(false);
            BackgroundInversor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LineaSuperiorPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CuadroBlancoTexto;
        private PictureBox LineaSuperiorPicturebox;
        private Button RegistrarseBoton;
        private LinkLabel TerminosLink;
        private CheckBox TerminosCheckbox;
        private TextBox NombreTextbox;
        private TextBox ApellidoTextbox;
        private TextBox EmailTextbox;
        private TextBox ConfirmarContraseñaTextbox;
        private TextBox ContraseñaTextBox;
        private TextBox UsuarioTexto;
        private Label InversorTexto;
        private Label CrearCuentaLabel;
        private Label InvierteText;
        private Label ChihuahuaText;
        private Panel BackgroundInversor;
        private PictureBox pictureBox1;
        private MaskedTextBox RFCInversorTextbox;
        private Button RegresarInversor;
        private TextBox CiudadInversorTextBox;
    }
}
