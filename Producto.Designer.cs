namespace PITCHER
{
    partial class Producto
    {

        // Controles del encabezado del producto
        private System.Windows.Forms.PictureBox picProductIcon;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnLike;

        // Sección izquierda: Reproductor de Video con controles de navegación
        private System.Windows.Forms.Panel pnlVideoContainer;
        private System.Windows.Forms.Button btnPrevVideo;
        private System.Windows.Forms.Button btnNextVideo;

        // Sección derecha: Tarjeta del Fundador y sección de Información
        private System.Windows.Forms.Panel pnlFundador;
        private System.Windows.Forms.Label lblFundadorTitulo;
        private System.Windows.Forms.Label lblFundadorNombre;
        private System.Windows.Forms.Button btnContactar;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.PictureBox picFundador;
        private System.Windows.Forms.Label lblSobreTitulo;
        private System.Windows.Forms.TextBox txtSobreDescripcion;

        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            picProductIcon = new PictureBox();
            lblProductName = new Label();
            lblCategoria = new Label();
            btnLike = new Button();
            pnlVideoContainer = new Panel();
            pictureBox2 = new PictureBox();
            btnPrevVideo = new Button();
            btnNextVideo = new Button();
            pnlFundador = new Panel();
            lblFundadorTitulo = new Label();
            lblFundadorNombre = new Label();
            btnContactar = new Button();
            btnPerfil = new Button();
            picFundador = new PictureBox();
            lblSobreTitulo = new Label();
            txtSobreDescripcion = new TextBox();
            picProducto1 = new PictureBox();
            picProducto2 = new PictureBox();
            picProducto3 = new PictureBox();
            pnlGallery = new Panel();
            pictureBoxPerfilEmpre = new PictureBox();
            picUsuario = new PictureBox();
            btnVolver = new Button();
            picLogo = new PictureBox();
            pnlNavbar = new Panel();
            btnEmprendimientos = new Button();
            btnEventos = new Button();
            btnNoticiasMenu = new Button();
            btnMensajes = new Button();
            ((System.ComponentModel.ISupportInitialize)picProductIcon).BeginInit();
            pnlVideoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlFundador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFundador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducto1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducto2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducto3).BeginInit();
            pnlGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfilEmpre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // picProductIcon
            // 
            picProductIcon.BackColor = Color.FromArgb(240, 240, 240);
            picProductIcon.Location = new Point(53, 146);
            picProductIcon.Margin = new Padding(4, 5, 4, 5);
            picProductIcon.Name = "picProductIcon";
            picProductIcon.Size = new Size(0, 0);
            picProductIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picProductIcon.TabIndex = 1;
            picProductIcon.TabStop = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblProductName.ForeColor = Color.Blue;
            lblProductName.Location = new Point(255, 154);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(345, 72);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Scrub daddy";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(255, 230, 225);
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(255, 100, 80);
            lblCategoria.Location = new Point(260, 242);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Padding = new Padding(11, 6, 11, 6);
            lblCategoria.Size = new Size(152, 32);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Hogar y Limpieza";
            // 
            // btnLike
            // 
            btnLike.FlatAppearance.BorderSize = 0;
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Font = new Font("Segoe UI", 16F);
            btnLike.ForeColor = Color.Gray;
            btnLike.Location = new Point(420, 231);
            btnLike.Margin = new Padding(4, 5, 4, 5);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(37, 43);
            btnLike.TabIndex = 4;
            btnLike.Text = "♡";
            btnLike.UseVisualStyleBackColor = true;
            // 
            // pnlVideoContainer
            // 
            pnlVideoContainer.BackColor = Color.FromArgb(45, 35, 115);
            pnlVideoContainer.Controls.Add(pictureBox2);
            pnlVideoContainer.Location = new Point(53, 392);
            pnlVideoContainer.Margin = new Padding(4, 5, 4, 5);
            pnlVideoContainer.Name = "pnlVideoContainer";
            pnlVideoContainer.Size = new Size(613, 477);
            pnlVideoContainer.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(261, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnPrevVideo
            // 
            btnPrevVideo.FlatAppearance.BorderSize = 0;
            btnPrevVideo.FlatStyle = FlatStyle.Flat;
            btnPrevVideo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPrevVideo.Location = new Point(7, 600);
            btnPrevVideo.Margin = new Padding(4, 5, 4, 5);
            btnPrevVideo.Name = "btnPrevVideo";
            btnPrevVideo.Size = new Size(40, 62);
            btnPrevVideo.TabIndex = 7;
            btnPrevVideo.Text = "◀";
            btnPrevVideo.UseVisualStyleBackColor = true;
            // 
            // btnNextVideo
            // 
            btnNextVideo.FlatAppearance.BorderSize = 0;
            btnNextVideo.FlatStyle = FlatStyle.Flat;
            btnNextVideo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNextVideo.Location = new Point(673, 600);
            btnNextVideo.Margin = new Padding(4, 5, 4, 5);
            btnNextVideo.Name = "btnNextVideo";
            btnNextVideo.Size = new Size(40, 62);
            btnNextVideo.TabIndex = 8;
            btnNextVideo.Text = "▶";
            btnNextVideo.UseVisualStyleBackColor = true;
            // 
            // pnlFundador
            // 
            pnlFundador.Controls.Add(lblFundadorTitulo);
            pnlFundador.Controls.Add(lblFundadorNombre);
            pnlFundador.Controls.Add(btnContactar);
            pnlFundador.Controls.Add(btnPerfil);
            pnlFundador.Controls.Add(picFundador);
            pnlFundador.Location = new Point(727, 377);
            pnlFundador.Margin = new Padding(4, 5, 4, 5);
            pnlFundador.Name = "pnlFundador";
            pnlFundador.Size = new Size(500, 177);
            pnlFundador.TabIndex = 9;
            // 
            // lblFundadorTitulo
            // 
            lblFundadorTitulo.AutoSize = true;
            lblFundadorTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFundadorTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblFundadorTitulo.Location = new Point(7, 8);
            lblFundadorTitulo.Margin = new Padding(4, 0, 4, 0);
            lblFundadorTitulo.Name = "lblFundadorTitulo";
            lblFundadorTitulo.Size = new Size(169, 37);
            lblFundadorTitulo.TabIndex = 0;
            lblFundadorTitulo.Text = "FUNDADOR";
            // 
            // lblFundadorNombre
            // 
            lblFundadorNombre.AutoSize = true;
            lblFundadorNombre.Font = new Font("Segoe UI", 10F);
            lblFundadorNombre.ForeColor = Color.FromArgb(70, 70, 90);
            lblFundadorNombre.Location = new Point(7, 64);
            lblFundadorNombre.Margin = new Padding(4, 0, 4, 0);
            lblFundadorNombre.Name = "lblFundadorNombre";
            lblFundadorNombre.Size = new Size(117, 46);
            lblFundadorNombre.TabIndex = 1;
            lblFundadorNombre.Text = " Aaron Krause\r\n ";
            // 
            // btnContactar
            // 
            btnContactar.BackColor = Color.FromArgb(0, 102, 204);
            btnContactar.FlatStyle = FlatStyle.Flat;
            btnContactar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnContactar.ForeColor = Color.White;
            btnContactar.Location = new Point(13, 115);
            btnContactar.Margin = new Padding(4, 5, 4, 5);
            btnContactar.Name = "btnContactar";
            btnContactar.Size = new Size(147, 49);
            btnContactar.TabIndex = 2;
            btnContactar.Text = "Contactar";
            btnContactar.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(0, 102, 204);
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(173, 115);
            btnPerfil.Margin = new Padding(4, 5, 4, 5);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(147, 49);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // picFundador
            // 
            picFundador.BackColor = Color.Transparent;
            picFundador.Image = (Image)resources.GetObject("picFundador.Image");
            picFundador.Location = new Point(353, 8);
            picFundador.Margin = new Padding(4, 5, 4, 5);
            picFundador.Name = "picFundador";
            picFundador.Size = new Size(140, 162);
            picFundador.SizeMode = PictureBoxSizeMode.Zoom;
            picFundador.TabIndex = 4;
            picFundador.TabStop = false;
            // 
            // lblSobreTitulo
            // 
            lblSobreTitulo.AutoSize = true;
            lblSobreTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSobreTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblSobreTitulo.Location = new Point(727, 577);
            lblSobreTitulo.Margin = new Padding(4, 0, 4, 0);
            lblSobreTitulo.Name = "lblSobreTitulo";
            lblSobreTitulo.Size = new Size(387, 37);
            lblSobreTitulo.TabIndex = 10;
            lblSobreTitulo.Text = "SOBRE EL EMPRENDIMIENTO";
            lblSobreTitulo.Click += lblSobreTitulo_Click;
            // 
            // txtSobreDescripcion
            // 
            txtSobreDescripcion.BackColor = Color.White;
            txtSobreDescripcion.BorderStyle = BorderStyle.None;
            txtSobreDescripcion.Font = new Font("Segoe UI", 9.5F);
            txtSobreDescripcion.ForeColor = Color.FromArgb(60, 60, 70);
            txtSobreDescripcion.Location = new Point(733, 638);
            txtSobreDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtSobreDescripcion.Multiline = true;
            txtSobreDescripcion.Name = "txtSobreDescripcion";
            txtSobreDescripcion.ReadOnly = true;
            txtSobreDescripcion.Size = new Size(487, 231);
            txtSobreDescripcion.TabIndex = 11;
            txtSobreDescripcion.Text = resources.GetString("txtSobreDescripcion.Text");
            // 
            // picProducto1
            // 
            picProducto1.BackColor = Color.Transparent;
            picProducto1.Image = (Image)resources.GetObject("picProducto1.Image");
            picProducto1.Location = new Point(7, 8);
            picProducto1.Margin = new Padding(4, 5, 4, 5);
            picProducto1.Name = "picProducto1";
            picProducto1.Size = new Size(147, 169);
            picProducto1.SizeMode = PictureBoxSizeMode.Zoom;
            picProducto1.TabIndex = 0;
            picProducto1.TabStop = false;
            // 
            // picProducto2
            // 
            picProducto2.BackColor = Color.Transparent;
            picProducto2.Image = (Image)resources.GetObject("picProducto2.Image");
            picProducto2.Location = new Point(173, 8);
            picProducto2.Margin = new Padding(4, 5, 4, 5);
            picProducto2.Name = "picProducto2";
            picProducto2.Size = new Size(147, 169);
            picProducto2.SizeMode = PictureBoxSizeMode.Zoom;
            picProducto2.TabIndex = 1;
            picProducto2.TabStop = false;
            // 
            // picProducto3
            // 
            picProducto3.BackColor = Color.Transparent;
            picProducto3.Image = (Image)resources.GetObject("picProducto3.Image");
            picProducto3.Location = new Point(340, 8);
            picProducto3.Margin = new Padding(4, 5, 4, 5);
            picProducto3.Name = "picProducto3";
            picProducto3.Size = new Size(147, 169);
            picProducto3.SizeMode = PictureBoxSizeMode.Zoom;
            picProducto3.TabIndex = 2;
            picProducto3.TabStop = false;
            // 
            // pnlGallery
            // 
            pnlGallery.Controls.Add(picProducto3);
            pnlGallery.Controls.Add(picProducto2);
            pnlGallery.Controls.Add(picProducto1);
            pnlGallery.Location = new Point(727, 146);
            pnlGallery.Margin = new Padding(4, 5, 4, 5);
            pnlGallery.Name = "pnlGallery";
            pnlGallery.Size = new Size(500, 185);
            pnlGallery.TabIndex = 5;
            // 
            // pictureBoxPerfilEmpre
            // 
            pictureBoxPerfilEmpre.Image = (Image)resources.GetObject("pictureBoxPerfilEmpre.Image");
            pictureBoxPerfilEmpre.Location = new Point(50, 146);
            pictureBoxPerfilEmpre.Name = "pictureBoxPerfilEmpre";
            pictureBoxPerfilEmpre.Size = new Size(183, 185);
            pictureBoxPerfilEmpre.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPerfilEmpre.TabIndex = 12;
            pictureBoxPerfilEmpre.TabStop = false;
            // 
            // picUsuario
            // 
            picUsuario.BackColor = Color.Transparent;
            picUsuario.Image = (Image)resources.GetObject("picUsuario.Image");
            picUsuario.Location = new Point(1167, 31);
            picUsuario.Margin = new Padding(4, 5, 4, 5);
            picUsuario.Name = "picUsuario";
            picUsuario.Size = new Size(62, 62);
            picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuario.TabIndex = 3;
            picUsuario.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Transparent;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVolver.ForeColor = Color.Blue;
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.Location = new Point(517, 42);
            btnVolver.Margin = new Padding(4, 5, 4, 5);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(54, 47);
            btnVolver.TabIndex = 1;
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(53, 31);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(187, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlNavbar
            // 
            pnlNavbar.Controls.Add(btnEmprendimientos);
            pnlNavbar.Controls.Add(btnEventos);
            pnlNavbar.Controls.Add(btnNoticiasMenu);
            pnlNavbar.Controls.Add(btnMensajes);
            pnlNavbar.Controls.Add(picLogo);
            pnlNavbar.Controls.Add(btnVolver);
            pnlNavbar.Controls.Add(picUsuario);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(0, 0);
            pnlNavbar.Margin = new Padding(4, 5, 4, 5);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1285, 127);
            pnlNavbar.TabIndex = 0;
            pnlNavbar.Paint += pnlNavbar_Paint;
            // 
            // btnEmprendimientos
            // 
            btnEmprendimientos.Cursor = Cursors.Hand;
            btnEmprendimientos.FlatAppearance.BorderSize = 0;
            btnEmprendimientos.FlatStyle = FlatStyle.Flat;
            btnEmprendimientos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEmprendimientos.ForeColor = Color.Blue;
            btnEmprendimientos.Location = new Point(592, 47);
            btnEmprendimientos.Name = "btnEmprendimientos";
            btnEmprendimientos.Size = new Size(183, 35);
            btnEmprendimientos.TabIndex = 5;
            btnEmprendimientos.Text = "Emprendimientos";
            // 
            // btnEventos
            // 
            btnEventos.Cursor = Cursors.Hand;
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEventos.ForeColor = Color.FromArgb(70, 70, 70);
            btnEventos.Location = new Point(785, 47);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(100, 35);
            btnEventos.TabIndex = 6;
            btnEventos.Text = "Eventos";
            // 
            // btnNoticiasMenu
            // 
            btnNoticiasMenu.Cursor = Cursors.Hand;
            btnNoticiasMenu.FlatAppearance.BorderSize = 0;
            btnNoticiasMenu.FlatStyle = FlatStyle.Flat;
            btnNoticiasMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNoticiasMenu.ForeColor = Color.FromArgb(70, 70, 70);
            btnNoticiasMenu.Location = new Point(895, 47);
            btnNoticiasMenu.Name = "btnNoticiasMenu";
            btnNoticiasMenu.Size = new Size(100, 35);
            btnNoticiasMenu.TabIndex = 7;
            btnNoticiasMenu.Text = "Noticias";
            btnNoticiasMenu.Click += btnNoticiasMenu_Click;
            // 
            // btnMensajes
            // 
            btnMensajes.Cursor = Cursors.Hand;
            btnMensajes.FlatAppearance.BorderSize = 0;
            btnMensajes.FlatStyle = FlatStyle.Flat;
            btnMensajes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMensajes.ForeColor = Color.FromArgb(70, 70, 70);
            btnMensajes.Location = new Point(1005, 47);
            btnMensajes.Name = "btnMensajes";
            btnMensajes.Size = new Size(100, 35);
            btnMensajes.TabIndex = 8;
            btnMensajes.Text = "Mensajes";
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1285, 923);
            Controls.Add(pictureBoxPerfilEmpre);
            Controls.Add(txtSobreDescripcion);
            Controls.Add(lblSobreTitulo);
            Controls.Add(pnlFundador);
            Controls.Add(btnNextVideo);
            Controls.Add(btnPrevVideo);
            Controls.Add(pnlVideoContainer);
            Controls.Add(pnlGallery);
            Controls.Add(btnLike);
            Controls.Add(lblCategoria);
            Controls.Add(lblProductName);
            Controls.Add(picProductIcon);
            Controls.Add(pnlNavbar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle del Producto - Pitcher";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)picProductIcon).EndInit();
            pnlVideoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlFundador.ResumeLayout(false);
            pnlFundador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFundador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducto1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducto2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducto3).EndInit();
            pnlGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPerfilEmpre).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlNavbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private PictureBox picProducto1;
        private PictureBox picProducto2;
        private PictureBox picProducto3;
        private Panel pnlGallery;
        private PictureBox pictureBoxPerfilEmpre;
        private PictureBox pictureBox2;
        private PictureBox picUsuario;
        private Button btnVolver;
        private PictureBox picLogo;
        private Panel pnlNavbar;
        private Button btnEmprendimientos;
        private Button btnEventos;
        private Button btnNoticiasMenu;
        private Button btnMensajes;
    }
}