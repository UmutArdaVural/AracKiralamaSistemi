using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Npgsql;

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class Musteri_Arac_Arama : Form
    {
        Sql_baglantı sql = new Sql_baglantı();
        public Musteri_Arac_Arama()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        int sayac = 100;

        private void Musteri_Arac_Arama_Load(object sender, EventArgs e)
        {
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("Select markaad From marka ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {

                comboBox1.Items.Add(sqlDataReader2[0]);
            }
            sql.Baglantı().Close();

            NpgsqlCommand sqlCommand4 = new NpgsqlCommand("Select yil From modelyili ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();
            comboBox3.Items.Add("Hepsi");
            while (sqlDataReader4.Read())
            {

                comboBox3.Items.Add(sqlDataReader4[0]);
            }
            sql.Baglantı().Close();

            NpgsqlCommand sqlCommand5 = new NpgsqlCommand("Select ucret From gunlukucretler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
            while (sqlDataReader5.Read())
            {

                comboBox6.Items.Add(sqlDataReader5[0]);
            }
            sql.Baglantı().Close();

            NpgsqlCommand sqlCommand10 = new NpgsqlCommand("Select motortur From motorturu ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader10 = sqlCommand10.ExecuteReader();
            while (sqlDataReader10.Read())
            {

                comboBox5.Items.Add(sqlDataReader10[0]);
            }
            sql.Baglantı().Close();


            // tüm araçları listeleme 
            NpgsqlCommand aracgetir = new NpgsqlCommand("Select aracplaka,markano,modelno,kilometre,modelyili,gunlukucret,aracno From araclar ", sql.Baglantı());
            NpgsqlDataReader aracverileri = aracgetir.ExecuteReader();
            int sayac = 1;
            while(aracverileri.Read())
            {
                Araç_Listele_UC Araç_Listele_UC = new Araç_Listele_UC();

                string plaka = aracverileri[0].ToString();
                int markano = aracverileri.GetInt32(1);
                int modelno = aracverileri.GetInt32(2);
                int km = aracverileri.GetInt32(3);
                int modelyili = aracverileri.GetInt32(4);
                int günlukucret = aracverileri.GetInt32(5);
                int aracnomuz= aracverileri.GetInt32(6);

                // marka ismini getirme 
                NpgsqlCommand aracmarkaADgetir = new NpgsqlCommand("Select markaad From marka  where markano=@p1", sql.Baglantı());
                aracmarkaADgetir.Parameters.AddWithValue("@p1" , markano);
                string markaad = aracmarkaADgetir.ExecuteScalar()?.ToString(); // Veriyi alıyoruz
                sql.Baglantı().Close(); // Bağlantıyı kapatıyoruz

                // model ismi getirm 
                NpgsqlCommand aracmodelgetir = new NpgsqlCommand("Select modelad From model  where modelno=@p1", sql.Baglantı());
                aracmodelgetir.Parameters.AddWithValue("@p1", modelno);
                string modelad = aracmodelgetir.ExecuteScalar()?.ToString(); // Veriyi alıyoruz
                sql.Baglantı().Close(); // Bağlantıyı kapatıyoruz

                // resim geitrme 
                NpgsqlCommand aracresimgetir = new NpgsqlCommand("SELECT buyukresim FROM resimler WHERE aracno = @p1", sql.Baglantı());
                aracresimgetir.Parameters.AddWithValue("@p1", aracnomuz);
                byte[] bigimage = aracresimgetir.ExecuteScalar() as byte[]; // Veriyi byte[] olarak alıyoruz

                sql.Baglantı().Close(); // Bağlantıyı kapatıyoruz
                // resim verisini picture box a ekliyebiliriz 
                if (bigimage != null)
                {
                    using (MemoryStream ms = new MemoryStream(bigimage))
                    {
                        Image image = Image.FromStream(ms);
                        Araç_Listele_UC.pictureBox1.Image = image;
                        // Artık resmi bir PictureBox veya başka bir yerde kullanabilirsiniz
                    }
                }
                Araç_Listele_UC.lblarackm.Text = km.ToString();
                Araç_Listele_UC.lblaracplaka.Text = plaka.ToString();
                Araç_Listele_UC.lblgunlukucret.Text = günlukucret.ToString();
                Araç_Listele_UC.lblmarka.Text = markaad.ToString();
                Araç_Listele_UC.lblmodel.Text = modelad.ToString();
                Araç_Listele_UC.lblmodelyılı.Text = modelyili.ToString();


                // uc ekrana çıkarma kısmı 
                if (sayac % 2 == 0)
                    Araç_Listele_UC.Margin = new Padding(40, 15, 0, 15);
                else
                {
                    Araç_Listele_UC.Margin = new Padding(25, 15, 0, 15);
                }

                flowLayoutPanel1.Controls.Add(Araç_Listele_UC);

                sayac++;
            }

           


        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear(); // Mevcut öğeleri temizle

            if (comboBox1.SelectedIndex != -1) // Seçim yapılmış mı kontrolü
            {
                string selectedValue = comboBox1.SelectedItem.ToString(); // Seçili öğeyi al

                // SQL sorgusu
                using (NpgsqlCommand sqlCommand3 = new NpgsqlCommand(
                    "SELECT model.modelad " +
                    "FROM marka " +
                    "INNER JOIN model ON model.markano = marka.markano " +
                    "WHERE marka.markaad = @markaad",
                    sql.Baglantı()))
                {
                    // Parametre ekle
                    sqlCommand3.Parameters.AddWithValue("@markaad", selectedValue);

                    try
                    {
                        // Sorguyu çalıştır
                        using (NpgsqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader())
                        {
                            while (sqlDataReader3.Read())
                            {
                                // Sonuçları comboBox2'ye ekle
                                comboBox2.Items.Add(sqlDataReader3["modelad"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
