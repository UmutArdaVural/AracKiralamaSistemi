namespace Araç_Kiralama_Ve_Yönetim
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtkuladı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtsifre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            umut_Arda_Vural_Ellipse__Controller1 = new Umut_Arda_Vural_Ellipse__Controller();
            umut_Arda_Vural_Ellipse__Controller2 = new Umut_Arda_Vural_Ellipse__Controller();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(553, 597);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Honeydew;
            label4.Location = new Point(638, 59);
            label4.Name = "label4";
            label4.Size = new Size(117, 65);
            label4.TabIndex = 1;
            label4.Text = "giris";
            // 
            // txtkuladı
            // 
            txtkuladı.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkuladı.ForeColor = Color.Turquoise;
            txtkuladı.Location = new Point(789, 200);
            txtkuladı.Name = "txtkuladı";
            txtkuladı.Size = new Size(234, 35);
            txtkuladı.TabIndex = 2;
            txtkuladı.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MintCream;
            label1.Location = new Point(603, 197);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MintCream;
            label2.Location = new Point(603, 298);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 5;
            label2.Text = "Şifre               :";
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtsifre.ForeColor = Color.Turquoise;
            txtsifre.Location = new Point(789, 301);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(234, 35);
            txtsifre.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Turquoise;
            button1.Location = new Point(727, 398);
            button1.Name = "button1";
            button1.Size = new Size(176, 83);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.FlatAppearance.BorderColor = Color.DarkCyan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            button2.Font = new Font("Unispace", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Honeydew;
            button2.Location = new Point(997, 9);
            button2.Name = "button2";
            button2.Size = new Size(45, 47);
            button2.TabIndex = 7;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // umut_Arda_Vural_Ellipse__Controller1
            // 
            umut_Arda_Vural_Ellipse__Controller1.CornerRadius = 50;
            umut_Arda_Vural_Ellipse__Controller1.TargetControl = this;
            // 
            // umut_Arda_Vural_Ellipse__Controller2
            // 
            umut_Arda_Vural_Ellipse__Controller2.CornerRadius = 50;
            umut_Arda_Vural_Ellipse__Controller2.TargetControl = button1;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1050, 595);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtsifre);
            Controls.Add(label1);
            Controls.Add(txtkuladı);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            ForeColor = Color.PaleTurquoise;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += Giris_Load;
            MouseDown += Giris_MouseDown;
            MouseMove += Giris_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Label label4;
        private TextBox txtkuladı;
        public Label label1;
        public Label label2;
        private TextBox txtsifre;
        private Button button1;
        private Button button2;
        private Umut_Arda_Vural_Ellipse__Controller umut_Arda_Vural_Ellipse__Controller1;
        private Umut_Arda_Vural_Ellipse__Controller umut_Arda_Vural_Ellipse__Controller2;
    }
}