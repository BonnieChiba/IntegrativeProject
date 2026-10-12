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
            panel1.Location = new Point(25, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 656);
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
            Panelito.Location = new Point(286, 51);
            Panelito.Name = "Panelito";
            Panelito.Size = new Size(423, 558);
            Panelito.TabIndex = 0;
            Panelito.Paint += Panelito_Paint;
            // 
            // RegistrarmeLink
            // 
            RegistrarmeLink.AutoSize = true;
            RegistrarmeLink.Location = new Point(176, 401);
            RegistrarmeLink.Name = "RegistrarmeLink";
            RegistrarmeLink.Size = new Size(68, 15);
            RegistrarmeLink.TabIndex = 6;
            RegistrarmeLink.TabStop = true;
            RegistrarmeLink.Text = "Registrarme";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 386);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 5;
            label1.Text = "¿Aún no tienes cuenta?";
            // 
            // OlvidasteContraseñaLink
            // 
            OlvidasteContraseñaLink.AutoSize = true;
            OlvidasteContraseñaLink.Location = new Point(81, 255);
            OlvidasteContraseñaLink.Name = "OlvidasteContraseñaLink";
            OlvidasteContraseñaLink.Size = new Size(134, 15);
            OlvidasteContraseñaLink.TabIndex = 4;
            OlvidasteContraseñaLink.TabStop = true;
            OlvidasteContraseñaLink.Text = "¿Olvidaste tu contraseña?";
            // 
            // IniciarSesiónBoton
            // 
            IniciarSesiónBoton.BackColor = Color.Blue;
            IniciarSesiónBoton.FlatStyle = FlatStyle.Flat;
            IniciarSesiónBoton.ForeColor = Color.White;
            IniciarSesiónBoton.Location = new Point(95, 344);
            IniciarSesiónBoton.Name = "IniciarSesiónBoton";
            IniciarSesiónBoton.Size = new Size(224, 28);
            IniciarSesiónBoton.TabIndex = 3;
            IniciarSesiónBoton.Text = "Iniciar Sesión";
            IniciarSesiónBoton.UseVisualStyleBackColor = false;
            IniciarSesiónBoton.Click += IniciarSesiónBoton_Click;
            // 
            // ContraseñaIniciarSesionTextbox
            // 
            ContraseñaIniciarSesionTextbox.Location = new Point(81, 220);
            ContraseñaIniciarSesionTextbox.Name = "ContraseñaIniciarSesionTextbox";
            ContraseñaIniciarSesionTextbox.Size = new Size(258, 23);
            ContraseñaIniciarSesionTextbox.TabIndex = 2;
            ContraseñaIniciarSesionTextbox.Text = "Contraseña";
            // 
            // UsuarioIniciarSesionTextbox
            // 
            UsuarioIniciarSesionTextbox.Location = new Point(81, 171);
            UsuarioIniciarSesionTextbox.Name = "UsuarioIniciarSesionTextbox";
            UsuarioIniciarSesionTextbox.Size = new Size(258, 23);
            UsuarioIniciarSesionTextbox.TabIndex = 1;
            UsuarioIniciarSesionTextbox.Text = "Usuario";
            // 
            // IniciarSesionTextbox
            // 
            IniciarSesionTextbox.AutoSize = true;
            IniciarSesionTextbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IniciarSesionTextbox.Location = new Point(122, 109);
            IniciarSesionTextbox.Name = "IniciarSesionTextbox";
            IniciarSesionTextbox.Size = new Size(169, 37);
            IniciarSesionTextbox.TabIndex = 0;
            IniciarSesionTextbox.Text = "Iniciar sesión";
            // 
            // LineaSuperiorIniciarSesion
            // 
            LineaSuperiorIniciarSesion.Image = (Image)resources.GetObject("LineaSuperiorIniciarSesion.Image");
            LineaSuperiorIniciarSesion.Location = new Point(0, 0);
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
            LineaInferiorIniciarSesion.Location = new Point(0, 332);
            LineaInferiorIniciarSesion.Name = "LineaInferiorIniciarSesion";
            LineaInferiorIniciarSesion.Size = new Size(1280, 321);
            LineaInferiorIniciarSesion.SizeMode = PictureBoxSizeMode.AutoSize;
            LineaInferiorIniciarSesion.TabIndex = 2;
            LineaInferiorIniciarSesion.TabStop = false;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(panel1);
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