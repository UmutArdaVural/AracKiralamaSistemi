namespace Araç_Kiralama_Ve_Yönetim
{
    partial class Araç_Listele_UC
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Araç_Listele_UC));
            panel1 = new Panel();
            groupBox7 = new GroupBox();
            lblaracplaka = new Label();
            button10 = new Button();
            groupBox6 = new GroupBox();
            lblmodel = new Label();
            groupBox5 = new GroupBox();
            lblmodelyılı = new Label();
            groupBox4 = new GroupBox();
            lblmarka = new Label();
            groupBox3 = new GroupBox();
            lblgunlukucret = new Label();
            groupBox2 = new GroupBox();
            lblarackm = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox7);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 386);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = SystemColors.HighlightText;
            groupBox7.Controls.Add(lblaracplaka);
            groupBox7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox7.ForeColor = Color.Chocolate;
            groupBox7.Location = new Point(358, 181);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(96, 93);
            groupBox7.TabIndex = 15;
            groupBox7.TabStop = false;
            groupBox7.Text = "Araç Plaka";
            // 
            // lblaracplaka
            // 
            lblaracplaka.AutoSize = true;
            lblaracplaka.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblaracplaka.ForeColor = Color.Black;
            lblaracplaka.Location = new Point(6, 37);
            lblaracplaka.Name = "lblaracplaka";
            lblaracplaka.Size = new Size(46, 20);
            lblaracplaka.TabIndex = 0;
            lblaracplaka.Text = "label6";
            // 
            // button10
            // 
            button10.BackColor = Color.Azure;
            button10.FlatAppearance.BorderColor = Color.Black;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.BottomLeft;
            button10.Location = new Point(383, 301);
            button10.Name = "button10";
            button10.Size = new Size(188, 68);
            button10.TabIndex = 14;
            button10.Text = "Kirala ";
            button10.TextAlign = ContentAlignment.MiddleRight;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.HighlightText;
            groupBox6.Controls.Add(lblmodel);
            groupBox6.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox6.ForeColor = Color.Chocolate;
            groupBox6.Location = new Point(192, 277);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(174, 100);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Marka ";
            // 
            // lblmodel
            // 
            lblmodel.AutoSize = true;
            lblmodel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblmodel.ForeColor = Color.Black;
            lblmodel.Location = new Point(6, 49);
            lblmodel.Name = "lblmodel";
            lblmodel.Size = new Size(46, 20);
            lblmodel.TabIndex = 0;
            lblmodel.Text = "label5";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.HighlightText;
            groupBox5.Controls.Add(lblmodelyılı);
            groupBox5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox5.ForeColor = Color.Chocolate;
            groupBox5.Location = new Point(460, 181);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(111, 93);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Model Yılı";
            // 
            // lblmodelyılı
            // 
            lblmodelyılı.AutoSize = true;
            lblmodelyılı.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblmodelyılı.ForeColor = Color.Black;
            lblmodelyılı.Location = new Point(7, 37);
            lblmodelyılı.Name = "lblmodelyılı";
            lblmodelyılı.Size = new Size(46, 20);
            lblmodelyılı.TabIndex = 0;
            lblmodelyılı.Text = "label4";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.HighlightText;
            groupBox4.Controls.Add(lblmarka);
            groupBox4.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.Chocolate;
            groupBox4.Location = new Point(6, 277);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(180, 100);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Model";
            // 
            // lblmarka
            // 
            lblmarka.AutoSize = true;
            lblmarka.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblmarka.ForeColor = Color.Black;
            lblmarka.Location = new Point(6, 49);
            lblmarka.Name = "lblmarka";
            lblmarka.Size = new Size(46, 20);
            lblmarka.TabIndex = 0;
            lblmarka.Text = "label3";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.HighlightText;
            groupBox3.Controls.Add(lblgunlukucret);
            groupBox3.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.Chocolate;
            groupBox3.Location = new Point(371, 91);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 84);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Günlük Ücret";
            // 
            // lblgunlukucret
            // 
            lblgunlukucret.AutoSize = true;
            lblgunlukucret.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblgunlukucret.ForeColor = Color.Black;
            lblgunlukucret.Location = new Point(6, 42);
            lblgunlukucret.Name = "lblgunlukucret";
            lblgunlukucret.Size = new Size(55, 23);
            lblgunlukucret.TabIndex = 0;
            lblgunlukucret.Text = "label2";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.HighlightText;
            groupBox2.Controls.Add(lblarackm);
            groupBox2.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Chocolate;
            groupBox2.Location = new Point(371, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 78);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Araç Km ";
            // 
            // lblarackm
            // 
            lblarackm.AutoSize = true;
            lblarackm.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblarackm.ForeColor = Color.Black;
            lblarackm.Location = new Point(6, 44);
            lblarackm.Name = "lblarackm";
            lblarackm.Size = new Size(55, 23);
            lblarackm.TabIndex = 0;
            lblarackm.Text = "label1";
            lblarackm.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(7, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Araç Resim";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(6, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Araç_Listele_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            Controls.Add(panel1);
            Name = "Araç_Listele_UC";
            Size = new Size(591, 395);
            panel1.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox7;
        public PictureBox pictureBox1;
        public Button button10;
        public Label lblarackm;
        public Label lblgunlukucret;
        public Label lblaracplaka;
        public Label lblmodelyılı;
        public Label lblmarka;
        public Label lblmodel;
    }
}
