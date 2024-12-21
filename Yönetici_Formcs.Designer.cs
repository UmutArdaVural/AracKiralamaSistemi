namespace Araç_Kiralama_Ve_Yönetim
{
    partial class Yönetici_Formcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yönetici_Formcs));
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button5 = new Button();
            panel5 = new Panel();
            groupBox8 = new GroupBox();
            button10 = new Button();
            pictureBox2 = new PictureBox();
            groupBox10 = new GroupBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            groupBox9 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label40 = new Label();
            txtkulllanıcıadı = new TextBox();
            label41 = new Label();
            txtsifre = new TextBox();
            maskedtel = new MaskedTextBox();
            label48 = new Label();
            textmail = new TextBox();
            maskedtc = new MaskedTextBox();
            label47 = new Label();
            textsoyad = new TextBox();
            button16 = new Button();
            label38 = new Label();
            textad = new TextBox();
            cmbehliyet = new ComboBox();
            label39 = new Label();
            cmbsehir = new ComboBox();
            label42 = new Label();
            label45 = new Label();
            label46 = new Label();
            groupBox3 = new GroupBox();
            label6 = new Label();
            button6 = new Button();
            txtcalisanno = new TextBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 40);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Chocolate;
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Right;
            panel3.ForeColor = Color.Chocolate;
            panel3.Location = new Point(1605, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 40);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 8);
            label4.Name = "label4";
            label4.Size = new Size(238, 29);
            label4.TabIndex = 0;
            label4.Text = "Yönetici Mödülü";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.Chocolate;
            panel2.Location = new Point(-4, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(196, 37);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 10;
            label1.Text = "ARAÇ KİRALAMA ";
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1842, 0);
            button1.Name = "button1";
            button1.Size = new Size(39, 40);
            button1.TabIndex = 9;
            button1.Text = "⏪";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Chocolate;
            button5.Dock = DockStyle.Right;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1881, 0);
            button5.Name = "button5";
            button5.Size = new Size(39, 40);
            button5.TabIndex = 8;
            button5.Text = "X";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.BackColor = Color.MintCream;
            panel5.Controls.Add(groupBox8);
            panel5.Location = new Point(12, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(1199, 199);
            panel5.TabIndex = 14;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.MintCream;
            groupBox8.Controls.Add(button10);
            groupBox8.Controls.Add(pictureBox2);
            groupBox8.Controls.Add(groupBox10);
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox8.ForeColor = Color.SeaGreen;
            groupBox8.Location = new Point(15, 16);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(1166, 158);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Yönetici Bilgileri  ";
            // 
            // button10
            // 
            button10.BackColor = Color.Azure;
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.BottomLeft;
            button10.Location = new Point(831, 70);
            button10.Name = "button10";
            button10.Size = new Size(266, 69);
            button10.TabIndex = 13;
            button10.Text = "Bilgileri Güncelle";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(273, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // groupBox10
            // 
            groupBox10.BackColor = Color.Azure;
            groupBox10.Controls.Add(label3);
            groupBox10.Controls.Add(pictureBox3);
            groupBox10.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox10.ForeColor = Color.Chocolate;
            groupBox10.Location = new Point(17, 54);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(366, 85);
            groupBox10.TabIndex = 11;
            groupBox10.TabStop = false;
            groupBox10.Text = "Yönetici Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 38);
            label3.Name = "label3";
            label3.Size = new Size(81, 29);
            label3.TabIndex = 15;
            label3.Text = "label3";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(258, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Azure;
            groupBox9.Controls.Add(label2);
            groupBox9.Controls.Add(pictureBox1);
            groupBox9.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.SeaGreen;
            groupBox9.Location = new Point(400, 54);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(386, 85);
            groupBox9.TabIndex = 10;
            groupBox9.TabStop = false;
            groupBox9.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 29);
            label2.TabIndex = 13;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label40);
            groupBox1.Controls.Add(txtkulllanıcıadı);
            groupBox1.Controls.Add(label41);
            groupBox1.Controls.Add(txtsifre);
            groupBox1.Controls.Add(maskedtel);
            groupBox1.Controls.Add(label48);
            groupBox1.Controls.Add(textmail);
            groupBox1.Controls.Add(maskedtc);
            groupBox1.Controls.Add(label47);
            groupBox1.Controls.Add(textsoyad);
            groupBox1.Controls.Add(button16);
            groupBox1.Controls.Add(label38);
            groupBox1.Controls.Add(textad);
            groupBox1.Controls.Add(cmbehliyet);
            groupBox1.Controls.Add(label39);
            groupBox1.Controls.Add(cmbsehir);
            groupBox1.Controls.Add(label42);
            groupBox1.Controls.Add(label45);
            groupBox1.Controls.Add(label46);
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 271);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 797);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çalışan Ekle";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label40.Location = new Point(15, 513);
            label40.Name = "label40";
            label40.Size = new Size(154, 29);
            label40.TabIndex = 63;
            label40.Text = "Kişi Kullanıcı Adı";
            // 
            // txtkulllanıcıadı
            // 
            txtkulllanıcıadı.Location = new Point(189, 514);
            txtkulllanıcıadı.Name = "txtkulllanıcıadı";
            txtkulllanıcıadı.Size = new Size(145, 29);
            txtkulllanıcıadı.TabIndex = 62;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label41.Location = new Point(15, 462);
            label41.Name = "label41";
            label41.Size = new Size(90, 29);
            label41.TabIndex = 61;
            label41.Text = "Kişi Şifre";
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(189, 462);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(145, 29);
            txtsifre.TabIndex = 60;
            // 
            // maskedtel
            // 
            maskedtel.Location = new Point(189, 283);
            maskedtel.Mask = "(999) 000-0000";
            maskedtel.Name = "maskedtel";
            maskedtel.Size = new Size(152, 29);
            maskedtel.TabIndex = 59;
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label48.Location = new Point(15, 282);
            label48.Name = "label48";
            label48.Size = new Size(76, 29);
            label48.TabIndex = 58;
            label48.Text = "Kişi Tel";
            // 
            // textmail
            // 
            textmail.Location = new Point(189, 216);
            textmail.Name = "textmail";
            textmail.Size = new Size(145, 29);
            textmail.TabIndex = 57;
            // 
            // maskedtc
            // 
            maskedtc.Location = new Point(189, 160);
            maskedtc.Mask = "00000000000";
            maskedtc.Name = "maskedtc";
            maskedtc.Size = new Size(152, 29);
            maskedtc.TabIndex = 56;
            maskedtc.ValidatingType = typeof(int);
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label47.Location = new Point(15, 96);
            label47.Name = "label47";
            label47.Size = new Size(104, 29);
            label47.TabIndex = 55;
            label47.Text = "Kişi Soyad";
            // 
            // textsoyad
            // 
            textsoyad.Location = new Point(189, 98);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(145, 29);
            textsoyad.TabIndex = 54;
            // 
            // button16
            // 
            button16.BackColor = Color.Azure;
            button16.FlatAppearance.BorderColor = Color.Black;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.ImageAlign = ContentAlignment.BottomLeft;
            button16.Location = new Point(108, 707);
            button16.Name = "button16";
            button16.Size = new Size(162, 69);
            button16.TabIndex = 45;
            button16.Text = "Tamamla ";
            button16.TextAlign = ContentAlignment.MiddleRight;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label38.Location = new Point(15, 45);
            label38.Name = "label38";
            label38.Size = new Size(73, 29);
            label38.TabIndex = 53;
            label38.Text = "Kişi Ad";
            // 
            // textad
            // 
            textad.Location = new Point(189, 46);
            textad.Name = "textad";
            textad.Size = new Size(145, 29);
            textad.TabIndex = 52;
            // 
            // cmbehliyet
            // 
            cmbehliyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbehliyet.FormattingEnabled = true;
            cmbehliyet.Location = new Point(189, 415);
            cmbehliyet.Name = "cmbehliyet";
            cmbehliyet.Size = new Size(145, 31);
            cmbehliyet.TabIndex = 51;
            cmbehliyet.SelectedIndexChanged += cmbehliyet_SelectedIndexChanged;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label39.Location = new Point(15, 407);
            label39.Name = "label39";
            label39.Size = new Size(116, 29);
            label39.TabIndex = 50;
            label39.Text = "Ehliyet Türü";
            // 
            // cmbsehir
            // 
            cmbsehir.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbsehir.FormattingEnabled = true;
            cmbsehir.Location = new Point(189, 348);
            cmbsehir.Name = "cmbsehir";
            cmbsehir.Size = new Size(145, 31);
            cmbsehir.TabIndex = 45;
            cmbsehir.SelectedIndexChanged += cmbsehir_SelectedIndexChanged;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label42.Location = new Point(15, 350);
            label42.Name = "label42";
            label42.Size = new Size(95, 29);
            label42.TabIndex = 44;
            label42.Text = "Kişi Şehir";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label45.Location = new Point(16, 215);
            label45.Name = "label45";
            label45.Size = new Size(49, 29);
            label45.TabIndex = 38;
            label45.Text = "Mail";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label46.Location = new Point(16, 159);
            label46.Name = "label46";
            label46.Size = new Size(75, 29);
            label46.TabIndex = 37;
            label46.Text = "Kişi TC";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLightLight;
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(button6);
            groupBox3.Controls.Add(txtcalisanno);
            groupBox3.Location = new Point(389, 271);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(234, 154);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Çalışanı Yönetiçi Yap";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(56, 25);
            label6.Name = "label6";
            label6.Size = new Size(112, 29);
            label6.TabIndex = 18;
            label6.Text = "Yönetiçi No";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.Location = new Point(56, 96);
            button6.Name = "button6";
            button6.Size = new Size(112, 31);
            button6.TabIndex = 1;
            button6.Text = "İşlem Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // txtcalisanno
            // 
            txtcalisanno.Location = new Point(38, 62);
            txtcalisanno.Name = "txtcalisanno";
            txtcalisanno.Size = new Size(145, 23);
            txtcalisanno.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // Yönetici_Formcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1920, 1080);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Yönetici_Formcs";
            Text = "Yönetici_Formcs";
            WindowState = FormWindowState.Maximized;
            Load += Yönetici_Formcs_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button5;
        private Panel panel5;
        private GroupBox groupBox8;
        private Button button10;
        private PictureBox pictureBox2;
        private GroupBox groupBox10;
        private Label label3;
        private PictureBox pictureBox3;
        private GroupBox groupBox9;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label40;
        private TextBox txtkulllanıcıadı;
        private Label label41;
        private TextBox txtsifre;
        private MaskedTextBox maskedtel;
        private Label label48;
        private TextBox textmail;
        private MaskedTextBox maskedtc;
        private Label label47;
        private TextBox textsoyad;
        private Button button16;
        private Label label38;
        private TextBox textad;
        private ComboBox cmbehliyet;
        private Label label39;
        private ComboBox cmbsehir;
        private Label label42;
        private Label label45;
        private Label label46;
        private GroupBox groupBox3;
        private Label label6;
        private Button button6;
        private TextBox txtcalisanno;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
    }
}