using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class Giris : Form
    {
        Sql_baglantı sql = new Sql_baglantı();

        public Giris()
        {
            InitializeComponent();
            // Yuvarlak köşeleri oluşturacak bir GraphicsPath nesnesi
            GraphicsPath path = new GraphicsPath();
            int radius = 50; // Yuvarlaklık yarıçapı
            Rectangle newRect = new Rectangle(0, 0, this.Width, this.Height);

            // Yuvarlak dikdörtgen oluşturma
            path.StartFigure();
            path.AddArc(newRect.X, newRect.Y, radius, radius, 180, 90); // Sol üst
            path.AddArc(newRect.X + newRect.Width - radius, newRect.Y, radius, radius, 270, 90); // Sağ üst
            path.AddArc(newRect.X + newRect.Width - radius, newRect.Y + newRect.Height - radius, radius, radius, 0, 90); // Sağ alt
            path.AddArc(newRect.X, newRect.Y + newRect.Height - radius, radius, radius, 90, 90); // Sol alt
            path.CloseFigure();

            // Formun bölgesini belirle
            this.Region = new Region(path);
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            /* GraphicsPath path = new GraphicsPath();
             path.AddArc(0, 0, 20, 20, 180, 90);
             path.AddArc(textBox1.Width - 20, 0, 20, 20, 270, 90);
             path.AddArc(textBox1.Width - 20, textBox1.Height - 20, 20, 20, 0, 90);
             path.AddArc(0, textBox1.Height - 20, 20, 20, 90, 90);
             path.CloseFigure();

             textBox1.Region = new Region(path);
             */
           /* ApplyRoundedCorners(textBox1, 15);
            ApplyRoundedCorners(button1, 15);
            ApplyRoundedCorners(textBox2, 15);*/

        }
        public void ApplyRoundedCorners(Control control, int cornerRadius)
        {
            /*if (control == null || cornerRadius < 0) return;

            // Yuvarlak köşe çizim yolu
            GraphicsPath path = new GraphicsPath();
            int arcWidth = cornerRadius * 2;

            // Yuvarlak köşe alanlarını ekle
            path.AddArc(0, 0, arcWidth, arcWidth, 180, 90); // Sol üst köşe
            path.AddArc(control.Width - arcWidth, 0, arcWidth, arcWidth, 270, 90); // Sağ üst köşe
            path.AddArc(control.Width - arcWidth, control.Height - arcWidth, arcWidth, arcWidth, 0, 90); // Sağ alt köşe
            path.AddArc(0, control.Height - arcWidth, arcWidth, arcWidth, 90, 90); // Sol alt köşe
            path.CloseFigure();

            // Kontrolün bölgesini güncelle
            control.Region = new Region(path);

            // Antialiasing için optimize
            control.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            };*/
        }





        int x, y;
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left += e.X - x;
            this.Top += e.Y - y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kuladı=txtkuladı.Text;
            string sifre = txtsifre.Text;
            if (label4.Text == "Müşteri Girişi")
            {
                using (var connection = sql.Baglantı()) // Veritabanı bağlantısı
                {
                    string query = "SELECT musterino FROM musteriler WHERE musterikullaniciadi = @musterikullaniciadi AND musterisifre = @sifre";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@musterikullaniciadi", kuladı);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            int kisino = Convert.ToInt32(result);
                            MessageBox.Show("Giriş başarılı!");
                            NpgsqlCommand sqlCommand13 = new NpgsqlCommand("SELECT kisiad,kisiooyad FROM kisiler WHERE kisino = @p1", sql.Baglantı());
                            sqlCommand13.Parameters.AddWithValue("@p1", kisino);
                            NpgsqlDataReader reader = sqlCommand13.ExecuteReader();
                        

                            // Giriş başarılı olduğunda yapılacak işlemleri ekleyebilirsiniz
                            string ad="";
                            while(reader.Read())
                            {
                                ad = reader.GetString(0)+" "+reader.GetString(1);
                            }
                            MainMenu MM = new MainMenu();
                            this.Hide();
                            MM.Show();
                            MM.lblkuladı.Text = ad;
                            MM.lblkisino.Text = kisino.ToString(); // Kişi numarasını label'a ekliyoruz
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                        }
                    }
                }


            }
            else if (label4.Text == "Çalışan Girişi")
            {
                Çalışan_İşlemelri çalışan_İşlemelri = new Çalışan_İşlemelri();
                this.Hide();
                çalışan_İşlemelri.Show();
            }
            else if (label4.Text == "Yönetici Girişi")
            {
                Yönetici_Formcs yönetici_Formcs = new Yönetici_Formcs();
                this.Hide();
                yönetici_Formcs.Show();
            }
        }
    }
}
