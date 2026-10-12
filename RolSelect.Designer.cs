namespace PITCHER
{
    partial class RolSelect
    {
        // Contenedor requerido por Visual Studio para el manejo de componentes
        private System.ComponentModel.IContainer components = null;

        // Método encargado de limpiar los recursos de memoria al cerrar la pantalla
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Método principal donde se inicializan y configuran todos los elementos de selección de rol
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolSelect));
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnInversor = new Button();
            btnEmprendedor = new Button();
            lblCuenta = new Label();
            btnIniciarSesion = new Button();
            pictureBoxInve = new PictureBox();
            pictureBoxEmpre = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmpre).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Blue;
            lblTitulo.Location = new Point(16, 46);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(747, 69);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicia Aquí";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblSubtitulo.Location = new Point(16, 131);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(747, 46);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "¿Cuál es tu enfoque?";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInversor
            // 
            btnInversor.BackColor = Color.FromArgb(135, 206, 250);
            btnInversor.FlatStyle = FlatStyle.Flat;
            btnInversor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInversor.ForeColor = Color.White;
            btnInversor.Location = new Point(67, 231);
            btnInversor.Margin = new Padding(4, 5, 4, 5);
            btnInversor.Name = "btnInversor";
            btnInversor.Padding = new Padding(0, 0, 0, 31);
            btnInversor.Size = new Size(293, 338);
            btnInversor.TabIndex = 2;
            btnInversor.Text = "Inversor";
            btnInversor.TextAlign = ContentAlignment.BottomCenter;
            btnInversor.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInversor.UseVisualStyleBackColor = false;
            // 
            // btnEmprendedor
            // 
            btnEmprendedor.BackColor = Color.FromArgb(242, 108, 63);
            btnEmprendedor.FlatStyle = FlatStyle.Flat;
            btnEmprendedor.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmprendedor.ForeColor = Color.White;
            btnEmprendedor.Location = new Point(413, 231);
            btnEmprendedor.Margin = new Padding(4, 5, 4, 5);
            btnEmprendedor.Name = "btnEmprendedor";
            btnEmprendedor.Padding = new Padding(0, 0, 0, 31);
            btnEmprendedor.Size = new Size(293, 338);
            btnEmprendedor.TabIndex = 3;
            btnEmprendedor.Text = "Emprendedor";
            btnEmprendedor.TextAlign = ContentAlignment.BottomCenter;
            btnEmprendedor.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEmprendedor.UseVisualStyleBackColor = false;
            // 
            // lblCuenta
            // 
            lblCuenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.ForeColor = Color.FromArgb(80, 80, 80);
            lblCuenta.Location = new Point(16, 608);
            lblCuenta.Margin = new Padding(4, 0, 4, 0);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(747, 31);
            lblCuenta.TabIndex = 4;
            lblCuenta.Text = "¿Ya tienes una cuenta?";
            lblCuenta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.DodgerBlue;
            btnIniciarSesion.Location = new Point(16, 638);
            btnIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(747, 46);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // pictureBoxInve
            // 
            pictureBoxInve.BackColor = Color.LightSkyBlue;
            pictureBoxInve.Image = (Image)resources.GetObject("pictureBoxInve.Image");
            pictureBoxInve.Location = new Point(113, 272);
            pictureBoxInve.Name = "pictureBoxInve";
            pictureBoxInve.Size = new Size(200, 200);
            pictureBoxInve.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxInve.TabIndex = 6;
            pictureBoxInve.TabStop = false;
            pictureBoxInve.Click += pictureBox1_Click;
            // 
            // pictureBoxEmpre
            // 
            pictureBoxEmpre.BackColor = Color.FromArgb(242, 108, 63);
            pictureBoxEmpre.Image = (Image)resources.GetObject("pictureBoxEmpre.Image");
            pictureBoxEmpre.Location = new Point(457, 272);
            pictureBoxEmpre.Name = "pictureBoxEmpre";
            pictureBoxEmpre.Size = new Size(200, 200);
            pictureBoxEmpre.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEmpre.TabIndex = 7;
            pictureBoxEmpre.TabStop = false;
            // 
            // button1
            // 
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(67, 70);
            button1.Name = "button1";
            button1.Size = new Size(122, 41);
            button1.TabIndex = 8;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RolSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(779, 725);
            Controls.Add(button1);
            Controls.Add(pictureBoxEmpre);
            Controls.Add(pictureBoxInve);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblCuenta);
            Controls.Add(btnEmprendedor);
            Controls.Add(btnInversor);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "RolSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de Enfoque";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInve).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmpre).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnInversor;
        private System.Windows.Forms.Button btnEmprendedor;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
        private PictureBox pictureBoxInve;
        private PictureBox pictureBoxEmpre;
        private Button button1;
    }
}
