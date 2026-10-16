namespace PITCHER
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            panel1 = new Panel();
            Panelito = new Panel();
            RegistrarmeLink = new LinkLabel();
            label1 = new Label();
            OlvidasteContraseñaLink = new LinkLabel();
            IniciarSesiónBoton = new Button();
            ContraseñaIniciarSesionTextbox = new TextBox();
            UsuarioIniciarSesionTextbox = new MaskedTextBox();
            IniciarSesionTextbox = new Label();
            LineaSuperiorIniciarSesion = new PictureBox();
            LineaInferiorIniciarSesion = new PictureBox();
            panel1.SuspendLayout();
            Panelito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LineaSuperiorIniciarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LineaInferiorIniciarSesion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(Panelito);
            panel1.Controls.Add(LineaSuperiorIniciarSesion);
            panel1.Controls.Add(LineaInferiorIniciarSesion);
            panel1.Location = new Point(29, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 875);
            panel1.TabIndex = 0;
            // 
            // Panelito
            // 
            Panelito.BackColor = Color.White;
            Panelito.Controls.Add(RegistrarmeLink);
            Panelito.Controls.Add(label1);
            Panelito.Controls.Add(OlvidasteContraseñaLink);
            Panelito.Controls.Add(IniciarSesiónBoton);
            Panelito.Controls.Add(ContraseñaIniciarSesionTextbox);
            Panelito.Controls.Add(UsuarioIniciarSesionTextbox);
            Panelito.Controls.Add(IniciarSesionTextbox);
            Panelito.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Panelito.Location = new Point(327, 68);
            Panelito.Margin = new Padding(3, 4, 3, 4);
            Panelito.Name = "Panelito";
            Panelito.Size = new Size(483, 744);
            Panelito.TabIndex = 0;
            Panelito.Paint += Panelito_Paint;
            // 
            // RegistrarmeLink
            // 
            RegistrarmeLink.AutoSize = true;
            RegistrarmeLink.Location = new Point(201, 535);
            RegistrarmeLink.Name = "RegistrarmeLink";
            RegistrarmeLink.Size = new Size(83, 20);
            RegistrarmeLink.TabIndex = 6;
            RegistrarmeLink.TabStop = true;
            RegistrarmeLink.Text = "Registrarme";
            RegistrarmeLink.LinkClicked += RegistrarmeLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 515);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 5;
            label1.Text = "¿Aún no tienes cuenta?";
            // 
            // OlvidasteContraseñaLink
            // 
            OlvidasteContraseñaLink.AutoSize = true;
            OlvidasteContraseñaLink.Location = new Point(93, 340);
            OlvidasteContraseñaLink.Name = "OlvidasteContraseñaLink";
            OlvidasteContraseñaLink.Size = new Size(166, 20);
            OlvidasteContraseñaLink.TabIndex = 4;
            OlvidasteContraseñaLink.TabStop = true;
            OlvidasteContraseñaLink.Text = "¿Olvidaste tu contraseña?";
            // 
            // IniciarSesiónBoton
            // 
            IniciarSesiónBoton.BackColor = Color.Blue;
            IniciarSesiónBoton.FlatStyle = FlatStyle.Flat;
            IniciarSesiónBoton.ForeColor = Color.White;
            IniciarSesiónBoton.Location = new Point(109, 459);
            IniciarSesiónBoton.Margin = new Padding(3, 4, 3, 4);
            IniciarSesiónBoton.Name = "IniciarSesiónBoton";
            IniciarSesiónBoton.Size = new Size(256, 37);
            IniciarSesiónBoton.TabIndex = 3;
            IniciarSesiónBoton.Text = "Iniciar Sesión";
            IniciarSesiónBoton.UseVisualStyleBackColor = false;
            IniciarSesiónBoton.Click += IniciarSesiónBoton_Click;
            // 
            // ContraseñaIniciarSesionTextbox
            // 
            ContraseñaIniciarSesionTextbox.Location = new Point(93, 293);
            ContraseñaIniciarSesionTextbox.Margin = new Padding(3, 4, 3, 4);
            ContraseñaIniciarSesionTextbox.Name = "ContraseñaIniciarSesionTextbox";
            ContraseñaIniciarSesionTextbox.Size = new Size(294, 27);
            ContraseñaIniciarSesionTextbox.TabIndex = 2;
            ContraseñaIniciarSesionTextbox.Text = "Contraseña";
            // 
            // UsuarioIniciarSesionTextbox
            // 
            UsuarioIniciarSesionTextbox.Location = new Point(93, 228);
            UsuarioIniciarSesionTextbox.Margin = new Padding(3, 4, 3, 4);
            UsuarioIniciarSesionTextbox.Name = "UsuarioIniciarSesionTextbox";
            UsuarioIniciarSesionTextbox.Size = new Size(294, 27);
            UsuarioIniciarSesionTextbox.TabIndex = 1;
            UsuarioIniciarSesionTextbox.Text = "Usuario";
            // 
            // IniciarSesionTextbox
            // 
            IniciarSesionTextbox.AutoSize = true;
            IniciarSesionTextbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarSesionTextbox.Location = new Point(139, 145);
            IniciarSesionTextbox.Name = "IniciarSesionTextbox";
            IniciarSesionTextbox.Size = new Size(211, 46);
            IniciarSesionTextbox.TabIndex = 0;
            IniciarSesionTextbox.Text = "Iniciar sesión";
            // 
            // LineaSuperiorIniciarSesion
            // 
            LineaSuperiorIniciarSesion.Image = (Image)resources.GetObject("LineaSuperiorIniciarSesion.Image");
            LineaSuperiorIniciarSesion.Location = new Point(0, 0);
            LineaSuperiorIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            LineaSuperiorIniciarSesion.Name = "LineaSuperiorIniciarSesion";
            LineaSuperiorIniciarSesion.Size = new Size(1280, 344);
            LineaSuperiorIniciarSesion.SizeMode = PictureBoxSizeMode.AutoSize;
            LineaSuperiorIniciarSesion.TabIndex = 1;
            LineaSuperiorIniciarSesion.TabStop = false;
            LineaSuperiorIniciarSesion.Click += LineaSuperiorIniciarSesion_Click;
            // 
            // LineaInferiorIniciarSesion
            // 
            LineaInferiorIniciarSesion.Image = (Image)resources.GetObject("LineaInferiorIniciarSesion.Image");
            LineaInferiorIniciarSesion.Location = new Point(0, 443);
            LineaInferiorIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            LineaInferiorIniciarSesion.Name = "LineaInferiorIniciarSesion";
            LineaInferiorIniciarSesion.Size = new Size(1280, 321);
            LineaInferiorIniciarSesion.SizeMode = PictureBoxSizeMode.AutoSize;
            LineaInferiorIniciarSesion.TabIndex = 2;
            LineaInferiorIniciarSesion.TabStop = false;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 999);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IniciarSesion";
            Text = "IniciarSesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Panelito.ResumeLayout(false);
            Panelito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LineaSuperiorIniciarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)LineaInferiorIniciarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel Panelito;
        private Label IniciarSesionTextbox;
        private MaskedTextBox UsuarioIniciarSesionTextbox;
        private Button IniciarSesiónBoton;
        private TextBox ContraseñaIniciarSesionTextbox;
        private LinkLabel OlvidasteContraseñaLink;
        private LinkLabel RegistrarmeLink;
        private Label label1;
        private PictureBox LineaSuperiorIniciarSesion;
        private PictureBox LineaInferiorIniciarSesion;
    }
}