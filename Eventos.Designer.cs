namespace Proyecto_Integrador
{
    partial class Eventos
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
            pnltop = new Panel();
            pnlfiltrar = new Panel();
            lblfiltrar = new Label();
            pnlbusceda = new Panel();
            lblbuscar = new Label();
            PicAvatar = new PictureBox();
            pnlnav = new Panel();
            lblmensajes = new Label();
            lblnoticias = new Label();
            lbleventos = new Label();
            lblEmprendimientos = new Label();
            piclogo = new PictureBox();
            lbleventosbig = new Label();
            pnlJapanFest = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lbljapanmarket = new Label();
            picJPF = new PictureBox();
            pnlSDF = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            picSDF = new PictureBox();
            pnlFM = new Panel();
            pictureBox2 = new PictureBox();
            picFM = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pnltop.SuspendLayout();
            pnlfiltrar.SuspendLayout();
            pnlbusceda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicAvatar).BeginInit();
            pnlnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            pnlJapanFest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picJPF).BeginInit();
            pnlSDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSDF).BeginInit();
            pnlFM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFM).BeginInit();
            SuspendLayout();
            // 
            // pnltop
            // 
            pnltop.BackColor = Color.FromArgb(240, 244, 249);
            pnltop.Controls.Add(pnlfiltrar);
            pnltop.Controls.Add(pnlbusceda);
            pnltop.Controls.Add(PicAvatar);
            pnltop.Controls.Add(pnlnav);
            pnltop.Controls.Add(piclogo);
            pnltop.Dock = DockStyle.Top;
            pnltop.Location = new Point(0, 0);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(984, 190);
            pnltop.TabIndex = 0;
            pnltop.Paint += panel1_Paint;
            // 
            // pnlfiltrar
            // 
            pnlfiltrar.BackColor = SystemColors.HotTrack;
            pnlfiltrar.Controls.Add(lblfiltrar);
            pnlfiltrar.Location = new Point(179, 109);
            pnlfiltrar.Name = "pnlfiltrar";
            pnlfiltrar.Size = new Size(113, 61);
            pnlfiltrar.TabIndex = 5;
            // 
            // lblfiltrar
            // 
            lblfiltrar.AutoSize = true;
            lblfiltrar.BackColor = Color.Transparent;
            lblfiltrar.Cursor = Cursors.IBeam;
            lblfiltrar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblfiltrar.ForeColor = Color.White;
            lblfiltrar.Location = new Point(14, 14);
            lblfiltrar.Name = "lblfiltrar";
            lblfiltrar.Size = new Size(75, 30);
            lblfiltrar.TabIndex = 5;
            lblfiltrar.Text = "Filtrar";
            // 
            // pnlbusceda
            // 
            pnlbusceda.BackColor = Color.White;
            pnlbusceda.Controls.Add(lblbuscar);
            pnlbusceda.Location = new Point(179, 109);
            pnlbusceda.Name = "pnlbusceda";
            pnlbusceda.Size = new Size(638, 61);
            pnlbusceda.TabIndex = 4;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Cursor = Cursors.IBeam;
            lblbuscar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblbuscar.ForeColor = Color.Gray;
            lblbuscar.Location = new Point(119, 14);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(82, 30);
            lblbuscar.TabIndex = 4;
            lblbuscar.Text = "Buscar";
            lblbuscar.Click += label1_Click_2;
            // 
            // PicAvatar
            // 
            PicAvatar.Image = Properties.Resources.danielayala_png;
            PicAvatar.Location = new Point(895, 29);
            PicAvatar.Name = "PicAvatar";
            PicAvatar.Size = new Size(66, 45);
            PicAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            PicAvatar.TabIndex = 3;
            PicAvatar.TabStop = false;
            PicAvatar.Click += pictureBox1_Click;
            // 
            // pnlnav
            // 
            pnlnav.BackColor = Color.Transparent;
            pnlnav.Controls.Add(lblmensajes);
            pnlnav.Controls.Add(lblnoticias);
            pnlnav.Controls.Add(lbleventos);
            pnlnav.Controls.Add(lblEmprendimientos);
            pnlnav.Location = new Point(400, 30);
            pnlnav.Name = "pnlnav";
            pnlnav.Size = new Size(407, 44);
            pnlnav.TabIndex = 2;
            pnlnav.Paint += pnlnav_Paint;
            // 
            // lblmensajes
            // 
            lblmensajes.AutoSize = true;
            lblmensajes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblmensajes.Location = new Point(319, 10);
            lblmensajes.Name = "lblmensajes";
            lblmensajes.Size = new Size(81, 21);
            lblmensajes.TabIndex = 3;
            lblmensajes.Text = "Mensajes";
            // 
            // lblnoticias
            // 
            lblnoticias.AutoSize = true;
            lblnoticias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblnoticias.Location = new Point(237, 10);
            lblnoticias.Name = "lblnoticias";
            lblnoticias.Size = new Size(73, 21);
            lblnoticias.TabIndex = 2;
            lblnoticias.Text = "Noticias";
            // 
            // lbleventos
            // 
            lbleventos.AutoSize = true;
            lbleventos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbleventos.ForeColor = SystemColors.HotTrack;
            lbleventos.Location = new Point(161, 10);
            lbleventos.Name = "lbleventos";
            lbleventos.Size = new Size(70, 21);
            lbleventos.TabIndex = 1;
            lbleventos.Text = "Eventos";
            lbleventos.Click += label1_Click_1;
            // 
            // lblEmprendimientos
            // 
            lblEmprendimientos.AutoSize = true;
            lblEmprendimientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEmprendimientos.Location = new Point(10, 10);
            lblEmprendimientos.Name = "lblEmprendimientos";
            lblEmprendimientos.Size = new Size(146, 21);
            lblEmprendimientos.TabIndex = 0;
            lblEmprendimientos.Text = "Emprendimientos";
            lblEmprendimientos.Click += label1_Click;
            // 
            // piclogo
            // 
            piclogo.Image = Properties.Resources.pitchr;
            piclogo.Location = new Point(-101, -55);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(459, 218);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 1;
            piclogo.TabStop = false;
            piclogo.Click += piclogo_Click;
            // 
            // lbleventosbig
            // 
            lbleventosbig.AutoSize = true;
            lbleventosbig.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            lbleventosbig.ForeColor = SystemColors.HotTrack;
            lbleventosbig.Location = new Point(405, 231);
            lbleventosbig.Name = "lbleventosbig";
            lbleventosbig.Size = new Size(216, 68);
            lbleventosbig.TabIndex = 4;
            lbleventosbig.Text = "Eventos";
            // 
            // pnlJapanFest
            // 
            pnlJapanFest.BackColor = Color.WhiteSmoke;
            pnlJapanFest.Controls.Add(pictureBox1);
            pnlJapanFest.Controls.Add(label2);
            pnlJapanFest.Controls.Add(label1);
            pnlJapanFest.Controls.Add(lbljapanmarket);
            pnlJapanFest.Controls.Add(picJPF);
            pnlJapanFest.Location = new Point(392, 319);
            pnlJapanFest.Name = "pnlJapanFest";
            pnlJapanFest.Size = new Size(239, 259);
            pnlJapanFest.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.heart;
            pictureBox1.Location = new Point(169, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Corazon_Click;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoEllipsis = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.Location = new Point(9, 217);
            label2.Name = "label2";
            label2.Size = new Size(52, 16);
            label2.TabIndex = 6;
            label2.Text = "20-Julio";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.Location = new Point(6, 183);
            label1.Name = "label1";
            label1.Size = new Size(229, 34);
            label1.TabIndex = 5;
            label1.Text = "Mercado de emprendimientos locales con tematica asiatica";
            // 
            // lbljapanmarket
            // 
            lbljapanmarket.AutoSize = true;
            lbljapanmarket.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbljapanmarket.Location = new Point(64, 162);
            lbljapanmarket.Name = "lbljapanmarket";
            lbljapanmarket.Size = new Size(113, 21);
            lbljapanmarket.TabIndex = 4;
            lbljapanmarket.Text = "Japan Market";
            // 
            // picJPF
            // 
            picJPF.Image = Properties.Resources.Screenshot_2026_10_11_202703;
            picJPF.Location = new Point(-17, -2);
            picJPF.Name = "picJPF";
            picJPF.Size = new Size(277, 159);
            picJPF.SizeMode = PictureBoxSizeMode.Zoom;
            picJPF.TabIndex = 1;
            picJPF.TabStop = false;
            // 
            // pnlSDF
            // 
            pnlSDF.BackColor = Color.WhiteSmoke;
            pnlSDF.Controls.Add(pictureBox3);
            pnlSDF.Controls.Add(label6);
            pnlSDF.Controls.Add(label7);
            pnlSDF.Controls.Add(label8);
            pnlSDF.Controls.Add(picSDF);
            pnlSDF.Location = new Point(719, 319);
            pnlSDF.Name = "pnlSDF";
            pnlSDF.Size = new Size(239, 259);
            pnlSDF.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.heart;
            pictureBox3.Location = new Point(176, 208);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Corazon_Click;
            // 
            // label6
            // 
            label6.AllowDrop = true;
            label6.AutoEllipsis = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label6.Location = new Point(10, 217);
            label6.Name = "label6";
            label6.Size = new Size(78, 16);
            label6.TabIndex = 10;
            label6.Text = "14-agosto";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AllowDrop = true;
            label7.AutoEllipsis = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label7.Location = new Point(7, 183);
            label7.Name = "label7";
            label7.Size = new Size(229, 34);
            label7.TabIndex = 9;
            label7.Text = "Evento de scrub daddy enfocado en productos de limpieza";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(49, 160);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 8;
            label8.Text = "Scrub Daddy Fest";
            // 
            // picSDF
            // 
            picSDF.Image = Properties.Resources.Screenshot_2026_10_11_202732;
            picSDF.Location = new Point(-8, -17);
            picSDF.Name = "picSDF";
            picSDF.Size = new Size(261, 174);
            picSDF.SizeMode = PictureBoxSizeMode.Zoom;
            picSDF.TabIndex = 0;
            picSDF.TabStop = false;
            // 
            // pnlFM
            // 
            pnlFM.BackColor = Color.WhiteSmoke;
            pnlFM.Controls.Add(pictureBox2);
            pnlFM.Controls.Add(picFM);
            pnlFM.Controls.Add(label3);
            pnlFM.Controls.Add(label4);
            pnlFM.Controls.Add(label5);
            pnlFM.Location = new Point(63, 319);
            pnlFM.Name = "pnlFM";
            pnlFM.Size = new Size(239, 259);
            pnlFM.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.heart;
            pictureBox2.Location = new Point(185, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Corazon_Click;
            // 
            // picFM
            // 
            picFM.Image = Properties.Resources.Screenshot_2026_10_11_202749;
            picFM.Location = new Point(-12, -1);
            picFM.Name = "picFM";
            picFM.Size = new Size(262, 158);
            picFM.SizeMode = PictureBoxSizeMode.Zoom;
            picFM.TabIndex = 1;
            picFM.TabStop = false;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoEllipsis = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.Location = new Point(3, 231);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 10;
            label3.Text = "3-octubre";
            // 
            // label4
            // 
            label4.AllowDrop = true;
            label4.AutoEllipsis = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.Location = new Point(3, 183);
            label4.Name = "label4";
            label4.Size = new Size(229, 48);
            label4.TabIndex = 9;
            label4.Text = "Mercado de negocios y emprendimientos de cosas relacionadas con granjeros y ranchos";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(61, 162);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 8;
            label5.Text = "Farmers Market";
            label5.Click += label5_Click;
            // 
            // Eventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(pnlFM);
            Controls.Add(pnlSDF);
            Controls.Add(pnlJapanFest);
            Controls.Add(lbleventosbig);
            Controls.Add(pnltop);
            Location = new Point(920, 25);
            Name = "Eventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eventos";
            Load += Eventos_Load;
            pnltop.ResumeLayout(false);
            pnlfiltrar.ResumeLayout(false);
            pnlfiltrar.PerformLayout();
            pnlbusceda.ResumeLayout(false);
            pnlbusceda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicAvatar).EndInit();
            pnlnav.ResumeLayout(false);
            pnlnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            pnlJapanFest.ResumeLayout(false);
            pnlJapanFest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picJPF).EndInit();
            pnlSDF.ResumeLayout(false);
            pnlSDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSDF).EndInit();
            pnlFM.ResumeLayout(false);
            pnlFM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnltop;
        private Panel pnlnav;
        private PictureBox piclogo;
        private Label lblEmprendimientos;
        private Label lbleventos;
        private Label lblnoticias;
        private Label lblmensajes;
        private PictureBox PicAvatar;
        private Panel pnlbusceda;
        private Label lblbuscar;
        private Label lbleventosbig;
        private Panel pnlfiltrar;
        private Label lblfiltrar;
        private Panel pnlJapanFest;
        private Panel pnlSDF;
        private Panel pnlFM;
        private PictureBox picSDF;
        private PictureBox picJPF;
        private PictureBox picFM;
        private Label lbljapanmarket;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}