using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class AracKiralaSayfası : Form
    {
        public AracKiralaSayfası()
        {
            InitializeComponent();
        }

        public string aracplaka;
        public string plakaal;

        Sql_baglantı sql = new Sql_baglantı();
        int aracnomuz = 0;
        public int kisino = 0;
        public int kiraucret = 0;
        private void AracKiralaSayfası_Load(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;

            lblplaka.Text = plakaal;
            MessageBox.Show(plakaal);
            lblkisino.Text = kisino.ToString();

            // aracverilerini forma taşıma
            try
            {
                NpgsqlCommand aracgetir = new NpgsqlCommand("Select aracno,kilometre,gunlukucret,motorturno,ehliyetno From araclar WHERE aracplaka=@p1 ", sql.Baglantı());
                aracgetir.Parameters.AddWithValue("@p1", plakaal);
                NpgsqlDataReader aracverileri = aracgetir.ExecuteReader();


                while (aracverileri.Read())
                {


                    int aracno = aracverileri.GetInt32(0);
                    int km = aracverileri.GetInt32(1);
                    int gunlukucret = aracverileri.GetInt32(2);
                    kiraucret = gunlukucret;
                    int motorturno = aracverileri.GetInt32(3);
                    int ehliyetno = aracverileri.GetInt32(4);
                    kmdegiskeni = km;
                    aracnomuz = aracno;
                    lblgunlukucret.Text = gunlukucret.ToString() + " TL";
                    lblkm.Text = km.ToString() + " KM";
                    try
                    {
                        // motor verisini alıyoruz 
                        NpgsqlCommand aracmotorgetir = new NpgsqlCommand("Select motortur From motorturu  where motorturno=@p1", sql.Baglantı());
                        aracmotorgetir.Parameters.AddWithValue("@p1", motorturno);
                        string motorad = aracmotorgetir.ExecuteScalar()?.ToString(); // Veriyi alıyoruz

                        // ehliyet verisini alıyoruz 
                        NpgsqlCommand aracehliyetgetir = new NpgsqlCommand("Select ehliyettur From ehliyetler  where ehliyetno=@p1", sql.Baglantı());
                        aracehliyetgetir.Parameters.AddWithValue("@p1", ehliyetno);
                        string ehliyetad = aracehliyetgetir.ExecuteScalar()?.ToString(); // Veriyi alıyoruz
                        lblehliyet.Text = ehliyetad;

                        lblmotorbilgisi.Text = motorad.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);

                    }
                    // verileri yazdırıyoruz 

                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }


            // resimleri atıcaz 
            try
            {
                using (var connection = sql.Baglantı()) // Bağlantıyı using ile açıyoruz
                {
                    NpgsqlCommand aracresimgetir = new NpgsqlCommand("SELECT buyukresim, resim2, resim3, resim4 FROM resimler WHERE aracno = @p1", connection);
                    aracresimgetir.Parameters.AddWithValue("@p1", aracnomuz);

                    // Resim verilerini alıyoruz
                    using (var reader = aracresimgetir.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Resim 1 - buyukresim
                            var bigimage = reader["buyukresim"] as byte[];
                            if (bigimage != null)
                            {
                                using (MemoryStream ms = new MemoryStream(bigimage))
                                {
                                    Image image1 = Image.FromStream(ms);
                                    pictureBox1.Image = image1; // pictureBox1'e ekliyoruz
                                }
                            }

                            // Resim 2 - resim2
                            var image2 = reader["resim2"] as byte[];
                            if (image2 != null)
                            {
                                using (MemoryStream ms = new MemoryStream(image2))
                                {
                                    Image img2 = Image.FromStream(ms);
                                    pictureBox2.Image = img2; // pictureBox2'ye ekliyoruz
                                }
                            }

                            // Resim 3 - resim3
                            var image3 = reader["resim3"] as byte[];
                            if (image3 != null)
                            {
                                using (MemoryStream ms = new MemoryStream(image3))
                                {
                                    Image img3 = Image.FromStream(ms);
                                    pictureBox3.Image = img3; // pictureBox3'e ekliyoruz
                                }
                            }

                            // Resim 4 - resim4
                            var image4 = reader["resim4"] as byte[];
                            if (image4 != null)
                            {
                                using (MemoryStream ms = new MemoryStream(image4))
                                {
                                    Image img4 = Image.FromStream(ms);
                                    pictureBox4.Image = img4; // pictureBox4'e ekliyoruz
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Resimler bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }



        }

        public bool AracMüsaitMi(int aracno)
        {
            // Sql_baglantı sınıfından bağlantıyı alıyoruz
            Sql_baglantı sql = new Sql_baglantı();

            string query = @"
            SELECT COUNT(*) 
            FROM kiralamalar
            WHERE aracno = @aracno 
              AND ((@baslangic BETWEEN baslangictarihi AND bitistarihi)
                   OR (@bitis BETWEEN baslangictarihi AND bitistarihi)
                   OR (baslangictarihi BETWEEN @baslangic AND @bitis))";

            using (NpgsqlConnection connection = sql.Baglantı())  // Baglantı metodunu kullanıyoruz
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@aracno", aracno);
                command.Parameters.AddWithValue("@baslangic", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@bitis", dateTimePicker2.Value);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count == 0; // Eğer 0 ise araç müsait
            }
        }
        int kiralamagünsayısı = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            bool musaitlik = AracMüsaitMi(aracnomuz);
            if (musaitlik == true)
            {
                DateTime startDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                // TimeSpan nesnesini hesaplıyoruz
                TimeSpan difference = endDate - startDate;
                int daysDifference = difference.Days;
                if (daysDifference <= 0)
                {
                    MessageBox.Show("Tarihleri Düzgün Seçmelisiniz   ");

                    return;
                }
                kiralamagünsayısı = daysDifference + 1;
                lbltoplamtutar.Text = (kiralamagünsayısı * kiraucret).ToString();
                MessageBox.Show("Araç müsait " + kiralamagünsayısı.ToString() + "  gün ");

            }
            else
            {
                MessageBox.Show("Araç müsait değil ");

            }
        }
        public int kmdegiskeni=0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool musaitlik = AracMüsaitMi(aracnomuz);
            if (musaitlik == true)
            {
                DateTime startDate = dateTimePicker1.Value;
                DateTime endDate = dateTimePicker2.Value;

                // TimeSpan nesnesini hesaplıyoruz
                TimeSpan difference = endDate - startDate;
                int daysDifference = difference.Days;

                if (daysDifference <= 0)
                {
                    MessageBox.Show("Tarihleri Düzgün Seçmelisiniz   ");

                    return;
                }
                kiralamagünsayısı = daysDifference + 1;
                lbltoplamtutar.Text = (kiralamagünsayısı * kiraucret).ToString();
                MessageBox.Show("Araç müsait " + kiralamagünsayısı.ToString() + "  gün ");

            }
            else
            {
                MessageBox.Show("Araç müsaitdeğil ");
                return;
            }

            // kiralama kısmı 
            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("INSERT INTO kiralamalar (aracno, kisino, baslangictarihi, bitistarihi, ucret, oncekikm, sonrakikm) VALUES (@aracno, @kisino, @baslangictarihi, @bitistarihi, @ucret, @oncekikm, @sonrakikm)", sql.Baglantı());


                sqlCommand.Parameters.AddWithValue("@aracno", aracnomuz);
                sqlCommand.Parameters.AddWithValue("@kisino", kisino);
                sqlCommand.Parameters.AddWithValue("@baslangictarihi", dateTimePicker1.Value);
                sqlCommand.Parameters.AddWithValue("@bitistarihi", dateTimePicker2.Value);
                sqlCommand.Parameters.AddWithValue("@ucret", Convert.ToInt32(lbltoplamtutar.Text));
                sqlCommand.Parameters.AddWithValue("@oncekikm", kmdegiskeni);
                int sonkm = kmdegiskeni;
                sonkm = sonkm + kiralamagünsayısı * 200;
                sqlCommand.Parameters.AddWithValue("@sonrakikm", sonkm);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Başarı ile kaydedildi  ");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"  Araç Kiralanmadı hata   .\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }
    }
}

