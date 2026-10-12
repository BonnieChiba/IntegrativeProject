namespace PITCHER
{
    partial class Perfil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnEditarPerfil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            panelCard = new Panel();
            btnVolver = new Button();
            picProfile = new PictureBox();
            lblNombre = new Label();
            lblUsuario = new Label();
            lblDescripcion = new Label();
            btnEditarPerfil = new Button();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(btnVolver);
            panelCard.Controls.Add(picProfile);
            panelCard.Controls.Add(lblNombre);
            panelCard.Controls.Add(lblUsuario);
            panelCard.Controls.Add(lblDescripcion);
            panelCard.Controls.Add(btnEditarPerfil);
            panelCard.Location = new Point(40, 38);
            panelCard.Margin = new Padding(3, 4, 3, 4);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(400, 650);
            panelCard.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.FromArgb(0, 102, 204);
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.ImageAlign = ContentAlignment.MiddleRight;
            btnVolver.Location = new Point(15, 19);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(32, 38);
            btnVolver.TabIndex = 5;
            btnVolver.UseVisualStyleBackColor = false;
            // 
            // picProfile
            // 
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.Location = new Point(114, 44);
            picProfile.Margin = new Padding(3, 4, 3, 4);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(178, 188);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(0, 102, 204);
            lblNombre.Location = new Point(10, 256);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(380, 56);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "DANIEL AYALA";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(10, 312);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(380, 31);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "@danielflow";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Arial", 11F);
            lblDescripcion.ForeColor = Color.FromArgb(60, 60, 60);
            lblDescripcion.Location = new Point(30, 362);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(340, 150);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Hola chicos, soy un musico apasionado por las inversiones en emprendimientos innovadores y creativos. Si tienes una buena idea mandame dm.";
            lblDescripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.BackColor = Color.FromArgb(34, 170, 255);
            btnEditarPerfil.FlatAppearance.BorderSize = 0;
            btnEditarPerfil.FlatStyle = FlatStyle.Flat;
            btnEditarPerfil.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditarPerfil.ForeColor = Color.White;
            btnEditarPerfil.Location = new Point(75, 544);
            btnEditarPerfil.Margin = new Padding(3, 4, 3, 4);
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.Size = new Size(250, 56);
            btnEditarPerfil.TabIndex = 4;
            btnEditarPerfil.Text = "Editar Perfil";
            btnEditarPerfil.UseVisualStyleBackColor = false;
            // 
            // Perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(482, 729);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista de Perfil";
            panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
