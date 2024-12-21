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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class Çalışan_İşlemelri : Form
    {
        Sql_baglantı sql = new Sql_baglantı();

        public Çalışan_İşlemelri()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Çalışan_İşlemelri_Load(object sender, EventArgs e)
        {
            // araç ekle kısmı işlemleri veri ekleme 
            // gunlukucretkısmı
            NpgsqlCommand sqlCommand65 = new NpgsqlCommand("Select ucret  From gunlukucretler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader65 = sqlCommand65.ExecuteReader();
            while (sqlDataReader65.Read())
            {

                cmbgunlukucret.Items.Add(sqlDataReader65[0]);
            }
            sql.Baglantı().Close();
            sqlDataReader65.Close();

            // motor turu 

            NpgsqlCommand sqlCommand17 = new NpgsqlCommand("Select motortur From motorturu ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader17 = sqlCommand17.ExecuteReader();
            while (sqlDataReader17.Read())
            {

                cmbmotorturu.Items.Add(sqlDataReader17[0]);
            }
            sql.Baglantı().Close();
            sqlDataReader17.Close();

            // ehliyet getirme
            NpgsqlCommand sqlCommand16 = new NpgsqlCommand("Select ehliyettur From ehliyetler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader16 = sqlCommand16.ExecuteReader();
            while (sqlDataReader16.Read())
            {

                cmbehliyet.Items.Add(sqlDataReader16[0]);
            }
            sql.Baglantı().Close();
            sqlDataReader16.Close();

            // durumu getirme 
            NpgsqlCommand sqlCommand15 = new NpgsqlCommand("Select durum From durum ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader15 = sqlCommand15.ExecuteReader();

            while (sqlDataReader15.Read())
            {

                cmbdurum.Items.Add(sqlDataReader15[0]);
            }
            sql.Baglantı().Close();

            // yil getirme 
            NpgsqlCommand sqlCommand14 = new NpgsqlCommand("Select yil From modelyili ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader14 = sqlCommand14.ExecuteReader();

            while (sqlDataReader14.Read())
            {

                cmbmodelyili.Items.Add(sqlDataReader14[0]);
            }
            sql.Baglantı().Close();


            // marka getirme
            try
            {
                NpgsqlCommand sqlCommand6 = new NpgsqlCommand("SELECT   markaad FROM marka ", sql.Baglantı());
                NpgsqlDataReader sqlDataReader6 = sqlCommand6.ExecuteReader();
                while (sqlDataReader6.Read())
                {
                    cmbmarka2.Items.Add(sqlDataReader6[0]);
                }


            }
            catch
            {

            }
            cmbmarka2.SelectedIndex = 1;


            // BURDA markalar eklenior model için 
            try
            {
                cmbmarka.Items.Clear();
                NpgsqlCommand sqlCommand5 = new NpgsqlCommand("SELECT   markaad FROM marka ", sql.Baglantı());
                NpgsqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
                while (sqlDataReader5.Read())
                {
                    cmbmarka.Items.Add(sqlDataReader5[0]);
                }


            }
            catch
            {

            }
            cmbmarka.SelectedIndex = 0;

            // muşteri combobox a ehliyet türü ekleme 
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("Select ehliyettur From ehliyetler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {

                comboBox14.Items.Add(sqlDataReader1[0]);
            }
            sql.Baglantı().Close();
            sqlDataReader1.Close();


            // müşteri şehir ekleme 
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("Select sehirad From sehirler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {

                comboBox17.Items.Add(sqlDataReader2[0]);
            }
            sql.Baglantı().Close();
            sqlDataReader2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        byte[] BgiimageBytes;
        byte[] imageBytes2;
        byte[] imageBytes3;
        byte[] imageBytes4;
        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dosyanın yolu
                string filePath = openFileDialog.FileName;

                // Dosyayı byte array'e dönüştür
                BgiimageBytes = File.ReadAllBytes(filePath);

                // imageBytes dizisi şimdi seçilen resmin byte array versiyonudur.
                // Bu diziyi istediğiniz gibi kullanabilirsiniz.
            }
            if (BgiimageBytes == null)
                return;

            // Byte array'i bir MemoryStream'e dönüştür
            using (MemoryStream ms = new MemoryStream(BgiimageBytes))
            {
                // MemoryStream'i bir Image nesnesine dönüştür
                Image image = Image.FromStream(ms);

                // PictureBox'a resmi atayın
                picturedıs.Image = image; // pictureBox, formunuzda var olan PictureBox kontrolünüz
            }

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public int kullanıcışehirid = -1;
        private void button16_Click(object sender, EventArgs e)
        {
            NpgsqlCommand sqlCommand = new NpgsqlCommand(
    "SELECT musterivekişiekle(@kisiad, @kisooyad, @kisitc, @kisitur, @mail, @kistel, @kissehir, @ehliyetno, @musterisifre, @musterikullaniciadi, @musteribakiye);",
    sql.Baglantı()
);

            // Parametreleri ekle
            sqlCommand.Parameters.AddWithValue("@kisiad", textBox8.Text); // Kişi adı
            sqlCommand.Parameters.AddWithValue("@kisooyad", textBox10.Text); // Kişi soyadı
            sqlCommand.Parameters.AddWithValue("@kisitur", "M"); // Kişi türü (Müşteri)
            sqlCommand.Parameters.AddWithValue("@kisitc", maskedTextBox4.Text); // TC Kimlik numarası
            sqlCommand.Parameters.AddWithValue("@mail", textBox9.Text); // Mail adresi
            sqlCommand.Parameters.AddWithValue("@kistel", maskedTextBox5.Text); // Telefon numarası
            sqlCommand.Parameters.AddWithValue("@kissehir", kullanıcışehirid); // Şehir ID (Örneğin: İstanbul için 34)
            sqlCommand.Parameters.AddWithValue("@ehliyetno", ehliyetNokişiekle); // Ehliyet numarası (örnek)
            sqlCommand.Parameters.AddWithValue("@musterisifre", textBox12.Text); // Müşteri şifresi
            sqlCommand.Parameters.AddWithValue("@musterikullaniciadi", textBox11.Text); // Kullanıcı adı
            sqlCommand.Parameters.AddWithValue("@musteribakiye", 0); // Başlangıç bakiyesi

            try
            {
                // Saklı yordamı çalıştır
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("MüŞTERİ EKLENDİ.");
                //Temizle(groupBox1);
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (sql.Baglantı().State == ConnectionState.Open)
                {
                    sql.Baglantı().Close();
                }

            }

        }
        public int ehliyetNokişiekle = -1;
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEhliyetTur = comboBox14.SelectedItem.ToString();

            // Ehliyet numarasını tutacak değişken
            ehliyetNokişiekle = -1;  // Varsayılan değeri -1, veritabanından gelen değerle değiştirilecek

            // SQL sorgusu
            string query = "SELECT ehliyetno FROM ehliyetler WHERE ehliyettur = @ehliyettur";

            using (var sqlCommand = new NpgsqlCommand(query, sql.Baglantı()))
            {
                // Parametreleri ekle
                sqlCommand.Parameters.AddWithValue("@ehliyettur", selectedEhliyetTur);

                // Veritabanı bağlantısını aç
                sql.Baglantı();

                // Veritabanından gelen değeri al
                var result = sqlCommand.ExecuteScalar();

                // Eğer bir değer dönerse, ehliyetNo'yu al
                if (result != null)
                {
                    ehliyetNokişiekle = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Seçilen ehliyet türüne ait bir numara bulunamadı.");
                }

                // Bağlantıyı kapat
                sql.Baglantı().Close();

                //MessageBox.Show(ehliyetNokişiekle.ToString());
            }

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedSehirTur = comboBox17.SelectedItem.ToString();

            // Ehliyet numarasını tutacak değişken
            kullanıcışehirid = -1;  // Varsayılan değeri -1, veritabanından gelen değerle değiştirilecek

            // SQL sorgusu
            string query = "SELECT sehirno FROM sehirler WHERE sehirad = @sehirad";

            using (var sqlCommand = new NpgsqlCommand(query, sql.Baglantı()))
            {
                // Parametreleri ekle
                sqlCommand.Parameters.AddWithValue("@sehirad", selectedSehirTur);

                // Veritabanı bağlantısını aç
                sql.Baglantı();

                // Veritabanından gelen değeri al
                var result = sqlCommand.ExecuteScalar();

                // Eğer bir değer dönerse, ehliyetNo'yu al
                if (result != null)
                {
                    kullanıcışehirid = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Seçilen ehliyet türüne ait bir numara bulunamadı.");
                }

                // Bağlantıyı kapat
                sql.Baglantı().Close();
                // MessageBox.Show(kullanıcışehirid.ToString());
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null  || textBox1.Text == "")
            {
                return;
            }

            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("INSERT INTO marka (markaad) VALUES (@markaad)", sql.Baglantı());
                sqlCommand.Parameters.AddWithValue("@markaad", textBox1.Text); // Eklemek istediğiniz marka adı
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Başarı ile kaydedildi  ");
            }
            catch
            {
                MessageBox.Show("Hata ");
            }
            try
            {
                cmbmarka.Items.Clear();
                NpgsqlCommand sqlCommand2 = new NpgsqlCommand("SELECT   markaad FROM marka ", sql.Baglantı());
                NpgsqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
                while (sqlDataReader1.Read())
                {
                    cmbmarka.Items.Add(sqlDataReader1[0]);
                }
                sqlDataReader1.Close();
                sql.Baglantı().Close();

            }
            catch
            {

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string markaismi = cmbmarka.SelectedItem.ToString();
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("SELECT   markano FROM marka WHERE markaad=@p1 ", sql.Baglantı());
            sqlCommand1.Parameters.AddWithValue("@p1", markaismi);

            int marknano = 0;
            object result = sqlCommand1.ExecuteScalar();
            if (result != null)
            {
                marknano = Convert.ToInt32(result); // Gelen değeri `int`'e dönüştür
            }
            MessageBox.Show(marknano.ToString());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            if(textBox2.Text =="" || textBox2.Text == null)
            {

            }
            
            string markaismi = cmbmarka.SelectedItem.ToString();
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("SELECT   markano FROM marka WHERE markaad=@p1 ", sql.Baglantı());
            sqlCommand1.Parameters.AddWithValue("@p1", markaismi);

            int marknano = 0;
            object result = sqlCommand1.ExecuteScalar();
            if (result != null)
            {
                marknano = Convert.ToInt32(result); // Gelen değeri `int`'e dönüştür
            }
            //MessageBox.Show(marknano.ToString());

            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("INSERT INTO model (markano, modelad) VALUES (@p2, @p3)", sql.Baglantı());
            sqlCommand2.Parameters.AddWithValue("@p2", marknano);
            sqlCommand2.Parameters.AddWithValue("@p3", textBox2.Text);



            try
            {
                sqlCommand2.ExecuteNonQuery(); // Sorguyu çalıştır
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                sqlCommand2.Connection.Close(); // Bağlantıyı kapat
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text =="" || textBox3.Text ==null) 
            {
                return;
            }
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("INSERT INTO motorturu (motortur) VALUES (@p4)", sql.Baglantı());
            sqlCommand2.Parameters.AddWithValue("@p4", textBox3.Text);

            try
            {
                sqlCommand2.ExecuteNonQuery(); // Sorguyu çalıştır
                MessageBox.Show("Veri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                sqlCommand2.Connection.Close(); // Bağlantıyı kapat
            }
        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbmarka2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Items.Clear(); // Mevcut öğeleri temizle

            if (cmbmarka.SelectedIndex != -1) // Seçim yapılmış mı kontrolü
            {
                string selectedValue = cmbmarka2.SelectedItem.ToString(); // Seçili öğeyi al

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
                                cmbmodel.Items.Add(sqlDataReader3["modelad"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }







            /*string markaismi = cmbmarka2.SelectedItem.ToString();
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("SELECT   markano FROM marka WHERE markaad=@p1 ", sql.Baglantı());
            sqlCommand1.Parameters.AddWithValue("@p1", markaismi);

             int marknano2 = 0;
            object result = sqlCommand1.ExecuteScalar();
            if (result != null)
            {
                marknano2 = Convert.ToInt32(result); // Gelen değeri `int`'e dönüştür
            }
            MessageBox.Show(marknano2.ToString());
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("SELECT model.modelad FROM marka INNER JOIN model ON model.markano = marka.markano WHERE marka.markaad = @markaad   ", sql.Baglantı());
            sqlCommand2.Parameters.AddWithValue("@markaad",cmbmarka2.Text);*/
        }



        private void button9_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dosyanın yolu
                string filePath = openFileDialog.FileName;

                // Dosyayı byte array'e dönüştür
                imageBytes2 = File.ReadAllBytes(filePath);

                // imageBytes2 dizisi şimdi seçilen resmin byte array versiyonudur.
                // Bu diziyi istediğiniz gibi kullanabilirsiniz.
            }
            if (imageBytes2 == null)
            {
                return;
                MessageBox.Show("rESİM SEİLMEDİ");
            }


            // Byte array'i bir MemoryStream'e dönüştür
            using (MemoryStream ms = new MemoryStream(imageBytes2))
            {
                // MemoryStream'i bir Image nesnesine dönüştür
                Image image = Image.FromStream(ms);

                // PictureBox'a resmi atayın
                pictureBox5.Image = image; // pictureBox, formunuzda var olan PictureBox kontrolünüz
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dosyanın yolu
                string filePath = openFileDialog.FileName;

                // Dosyayı byte array'e dönüştür
                imageBytes3 = File.ReadAllBytes(filePath);

                // imageBytes2 dizisi şimdi seçilen resmin byte array versiyonudur.
                // Bu diziyi istediğiniz gibi kullanabilirsiniz.
            }
            if (imageBytes3 == null)
            {
                return;
                MessageBox.Show("rESİM SEİLMEDİ");
            }


            // Byte array'i bir MemoryStream'e dönüştür
            using (MemoryStream ms = new MemoryStream(imageBytes3))
            {
                // MemoryStream'i bir Image nesnesine dönüştür
                Image image = Image.FromStream(ms);

                // PictureBox'a resmi atayın
                pictureBox6.Image = image; // pictureBox, formunuzda var olan PictureBox kontrolünüz
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Dosyanın yolu
                string filePath = openFileDialog.FileName;

                // Dosyayı byte array'e dönüştür
                imageBytes4 = File.ReadAllBytes(filePath);

                // imageBytes4 dizisi şimdi seçilen resmin byte array versiyonudur.
                // Bu diziyi istediğiniz gibi kullanabilirsiniz.
            }
            if (imageBytes4 == null)
            {
                return;
                MessageBox.Show("rESİM SEİLMEDİ");
            }


            // Byte array'i bir MemoryStream'e dönüştür
            using (MemoryStream ms = new MemoryStream(imageBytes4))
            {
                // MemoryStream'i bir Image nesnesine dönüştür
                Image image = Image.FromStream(ms);

                // PictureBox'a resmi atayın
                pictureBox7.Image = image; // pictureBox, formunuzda var olan PictureBox kontrolünüz
            }
        }

        private void AracEkle_Click(object sender, EventArgs e)
        {
            if (BgiimageBytes == null || imageBytes2 == null || imageBytes3 == null || imageBytes4 == null)
            {
                MessageBox.Show("Lütfen resimleri  doldurun ");
                return;
            }
            if (cmbehliyet.SelectedIndex == -1 || cmbdurum.SelectedIndex == -1 || cmbmarka.SelectedIndex == -1 || cmbmarka2.SelectedIndex == -1 || cmbmotorturu.SelectedIndex == -1 || cmbgunlukucret.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları   doldurun ");
                return;
            }
            // ehliyet no almak 
            string ehliyetisim = cmbehliyet.SelectedItem.ToString();
            NpgsqlCommand sqlCommand5 = new NpgsqlCommand("SELECT   ehliyetno FROM ehliyetler WHERE ehliyettur=@p1 ", sql.Baglantı());
            sqlCommand5.Parameters.AddWithValue("@p1", ehliyetisim);

            int ehliyetno = 0;
            object result5 = sqlCommand5.ExecuteScalar();
            if (result5 != null)
            {
                ehliyetno = Convert.ToInt32(result5); // Gelen değeri `int`'e dönüştür
            }



            // motor türü no alma 
            string motorturu = cmbmotorturu.SelectedItem.ToString();
            NpgsqlCommand sqlCommand4 = new NpgsqlCommand("SELECT   motorturno FROM motorturu WHERE motortur=@p1 ", sql.Baglantı());
            sqlCommand4.Parameters.AddWithValue("@p1", motorturu);

            int motorno = 0;
            object result4 = sqlCommand4.ExecuteScalar();
            if (result4 != null)
            {
                motorno = Convert.ToInt32(result4); // Gelen değeri `int`'e dönüştür
            }

            // arac durum 
            string durumismi = cmbdurum.SelectedItem.ToString();
            NpgsqlCommand sqlCommand3 = new NpgsqlCommand("SELECT   durumno FROM durum WHERE durum=@p1 ", sql.Baglantı());
            sqlCommand3.Parameters.AddWithValue("@p1", durumismi);

            int durumno = 0;
            object result3 = sqlCommand3.ExecuteScalar();
            if (result3 != null)
            {
                durumno = Convert.ToInt32(result3); // Gelen değeri `int`'e dönüştür
            }


            // arac model idsi
            string modelismi = cmbmodel.SelectedItem.ToString();
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("SELECT   modelno FROM model WHERE modelad=@p1 ", sql.Baglantı());
            sqlCommand2.Parameters.AddWithValue("@p1", modelismi);

            int modelno = 0;
            object result2 = sqlCommand2.ExecuteScalar();
            if (result2 != null)
            {
                modelno = Convert.ToInt32(result2); // Gelen değeri `int`'e dönüştür
            }

            //aracmarka idsi 
            string markaismi = cmbmarka2.SelectedItem.ToString();
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("SELECT   markano FROM marka WHERE markaad=@p1 ", sql.Baglantı());
            sqlCommand1.Parameters.AddWithValue("@p1", markaismi);

            int markano = 0;
            object result = sqlCommand1.ExecuteScalar();
            if (result != null)
            {
                markano = Convert.ToInt32(result); // Gelen değeri `int`'e dönüştür
            }


            // arac plaka yapıldı 





            // veri tabanına ekleme kısmı 
            try
            {
                NpgsqlCommand sqlCommand = new NpgsqlCommand("INSERT INTO araclar (aracplaka, markano, modelno, kilometre, modelyili, durum, motorturno, ehliyetno,gunlukucret) VALUES (@aracplaka, @markano, @modelno, @kilometre, @modelyili, @durum, @motorturno, @ehliyetno,@gunlukucret)", sql.Baglantı());


                sqlCommand.Parameters.AddWithValue("@aracplaka", textBox5.Text);
                sqlCommand.Parameters.AddWithValue("@markano", markano);
                sqlCommand.Parameters.AddWithValue("@modelno", modelno);
                sqlCommand.Parameters.AddWithValue("@kilometre", Convert.ToInt32(textBox13.Text));
                sqlCommand.Parameters.AddWithValue("@modelyili", Convert.ToInt32(cmbmodelyili.SelectedItem));
                sqlCommand.Parameters.AddWithValue("@durum", durumno);
                sqlCommand.Parameters.AddWithValue("@motorturno", motorno);
                sqlCommand.Parameters.AddWithValue("@ehliyetno", ehliyetno);
                sqlCommand.Parameters.AddWithValue("@gunlukucret", Convert.ToInt32(cmbgunlukucret.SelectedItem));




                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Başarı ile kaydedildi  ");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"  arac kaydolmadı  .\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            int resim_Icin_Arac_No = 0;
            try
            {
                NpgsqlCommand sqlCommand13 = new NpgsqlCommand("SELECT   aracno FROM araclar WHERE aracplaka=@p1 ", sql.Baglantı());
                sqlCommand13.Parameters.AddWithValue("@p1", textBox5.Text);
                NpgsqlDataReader reader = sqlCommand13.ExecuteReader();

                while (reader.Read())
                {
                    resim_Icin_Arac_No = Convert.ToInt32(reader[0]);
                }

            }
            catch
            {
                MessageBox.Show("Hata Resim için Araç plakası bulunmadı ");
            }
            try
            {
                NpgsqlCommand sqlCommand54 = new NpgsqlCommand("INSERT INTO resimler (aracno, buyukresim, resim2, resim3, resim4) VALUES (@p1, @p2, @p3, @p4, @p5)", sql.Baglantı());
                sqlCommand54.Parameters.AddWithValue("@p1", resim_Icin_Arac_No);
                sqlCommand54.Parameters.AddWithValue("@p2", BgiimageBytes);
                sqlCommand54.Parameters.AddWithValue("@p3", imageBytes2);
                sqlCommand54.Parameters.AddWithValue("@p4", imageBytes3);
                sqlCommand54.Parameters.AddWithValue("@p5", imageBytes4);
                sqlCommand54.ExecuteNonQuery(); // Sorguyu çalıştır
                MessageBox.Show("ResiM EKLENDİ   ");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"  resim eklenmedi  .\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int aracnoforuptade = 0;
        public int aracıngüncellenmedenöncekikm = 0;

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand sqlCommand13 = new NpgsqlCommand("SELECT  kilometre,durum,motorturno,ehliyetno,aracno FROM araclar WHERE aracplaka=@p1 ", sql.Baglantı());
                sqlCommand13.Parameters.AddWithValue("@p1", txtplakagüncelle.Text);
                NpgsqlDataReader npgsqlDataReader = sqlCommand13.ExecuteReader();

                int km = 0; int durum = 0; int motorno = 0; int ehliyetno = 0;

                while (npgsqlDataReader.Read())
                {
                    km = Convert.ToInt32(npgsqlDataReader[0]); durum = Convert.ToInt32(npgsqlDataReader[1]);
                    motorno = Convert.ToInt32(npgsqlDataReader[2]); ehliyetno = Convert.ToInt32(npgsqlDataReader[3]);
                    aracnoforuptade = Convert.ToInt32(npgsqlDataReader[4]);
                }
                aracıngüncellenmedenöncekikm = km;
                txtgüncelkm.Text = km.ToString();
                // comboboxlara gerçek değerleri atama 

                // motor turu 

                NpgsqlCommand sqlCommand17 = new NpgsqlCommand("Select motortur From motorturu ", sql.Baglantı());
                NpgsqlDataReader sqlDataReader17 = sqlCommand17.ExecuteReader();
                comboBoxmotor.Items.Clear();
                while (sqlDataReader17.Read())
                {

                    comboBoxmotor.Items.Add(sqlDataReader17[0]);
                }
                comboBoxmotor.SelectedIndex = motorno - 1;
                sql.Baglantı().Close();
                sqlDataReader17.Close();

                // ehliyet getirme
                NpgsqlCommand sqlCommand16 = new NpgsqlCommand("Select ehliyettur From ehliyetler ", sql.Baglantı());
                comboBoxehliyet.Items.Clear();
                NpgsqlDataReader sqlDataReader16 = sqlCommand16.ExecuteReader();
                while (sqlDataReader16.Read())
                {

                    comboBoxehliyet.Items.Add(sqlDataReader16[0]);
                }
                sql.Baglantı().Close();
                sqlDataReader16.Close();
                comboBoxehliyet.SelectedIndex = ehliyetno - 1;
                // durumu getirme 
                NpgsqlCommand sqlCommand15 = new NpgsqlCommand("Select durum From durum ", sql.Baglantı());
                NpgsqlDataReader sqlDataReader15 = sqlCommand15.ExecuteReader();
                comboboxdurum.Items.Clear();
                while (sqlDataReader15.Read())
                {

                    comboboxdurum.Items.Add(sqlDataReader15[0]);
                }
                comboboxdurum.SelectedIndex = durum - 1;
                sql.Baglantı().Close();


            }
            catch
            {
                MessageBox.Show("hata veri gelmiyor ");
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            // ehliyet no almak 
            if(comboBoxehliyet.SelectedIndex == -1)
            {
                return;
            }
            string ehliyetisim = comboBoxehliyet.SelectedItem.ToString();
            NpgsqlCommand sqlCommand5 = new NpgsqlCommand("SELECT   ehliyetno FROM ehliyetler WHERE ehliyettur=@p1 ", sql.Baglantı());
            sqlCommand5.Parameters.AddWithValue("@p1", ehliyetisim);

            int ehliyetno = 0;
            object result5 = sqlCommand5.ExecuteScalar();
            if (result5 != null)
            {
                ehliyetno = Convert.ToInt32(result5); // Gelen değeri `int`'e dönüştür
            }



            // motor türü no alma 
            string motorturu = comboBoxmotor.SelectedItem.ToString();
            NpgsqlCommand sqlCommand4 = new NpgsqlCommand("SELECT   motorturno FROM motorturu WHERE motortur=@p1 ", sql.Baglantı());
            sqlCommand4.Parameters.AddWithValue("@p1", motorturu);

            int motorno = 0;
            object result4 = sqlCommand4.ExecuteScalar();
            if (result4 != null)
            {
                motorno = Convert.ToInt32(result4); // Gelen değeri `int`'e dönüştür
            }

            // arac durum 
            string durumismi = comboboxdurum.SelectedItem.ToString();
            NpgsqlCommand sqlCommand3 = new NpgsqlCommand("SELECT   durumno FROM durum WHERE durum=@p1 ", sql.Baglantı());
            sqlCommand3.Parameters.AddWithValue("@p1", durumismi);

            int durumno = 0;
            object result3 = sqlCommand3.ExecuteScalar();
            if (result3 != null)
            {
                durumno = Convert.ToInt32(result3); // Gelen değeri `int`'e dönüştür
            }



            try
            {
                NpgsqlCommand sqlCommand13 = new NpgsqlCommand("UPDATE araclar SET kilometre=@p2, durum=@p3, motorturno=@p4, ehliyetno=@p5 WHERE aracplaka=@p1", sql.Baglantı());
                sqlCommand13.Parameters.AddWithValue("@p1", txtplakagüncelle.Text); // Güncellenecek aracın plakası
                sqlCommand13.Parameters.AddWithValue("@p2", Convert.ToInt32(txtgüncelkm.Text)); // Yeni kilometre değeri
                sqlCommand13.Parameters.AddWithValue("@p3", durumno); // Yeni durum
                sqlCommand13.Parameters.AddWithValue("@p4", motorno); // Yeni motor turnosu
                sqlCommand13.Parameters.AddWithValue("@p5", ehliyetno); // Yeni ehliyet numarası

                // Sorguyu çalıştır
                sqlCommand13.ExecuteNonQuery();

                if (aracıngüncellenmedenöncekikm != Convert.ToInt32(txtgüncelkm.Text))
                {




                    try
                    {
                        // Güncellenmiş kilometre değerini al
                        int güncelKm = Convert.ToInt32(txtgüncelkm.Text);

                        // Bakım tablosunda geçmiş bakım ve gelecek bakımı güncelle
                        NpgsqlCommand bakımGüncelleCommand = new NpgsqlCommand(
                            "UPDATE bakim " +
                            "SET gecmisbakimkm=@p1, gelecekbakimkm=@p2 " +
                            "WHERE aracno=@p3",
                            sql.Baglantı());
                        // Parametreler
                        bakımGüncelleCommand.Parameters.AddWithValue("@p1", güncelKm); // Geçmiş bakım için yeni kilometre
                        bakımGüncelleCommand.Parameters.AddWithValue("@p2", güncelKm + 10000); // Gelecek bakım, varsayalım +10.000 km
                        bakımGüncelleCommand.Parameters.AddWithValue("@p3", aracnoforuptade); // Güncellenecek aracın ID'si

                        // Sorguyu çalıştır
                        bakımGüncelleCommand.ExecuteNonQuery();

                        MessageBox.Show("Bakım tablosu başarıyla güncellendi.");

                    }
                    catch
                    {

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Araç güncellenemedi.\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand sqlCommand3 = new NpgsqlCommand("SELECT bakim.gecmisbakimkm, bakim.gelecekbakimkm, araclar.kilometre  FROM araclar  INNER JOIN bakim  ON araclar.aracno = bakim.aracno WHERE araclar.aracplaka = @p1", sql.Baglantı());
                sqlCommand3.Parameters.AddWithValue("@p1", textBox4.Text); // Araç plakası için parametre
                NpgsqlDataReader npgsqlDataReader = sqlCommand3.ExecuteReader();
                int gecmisBakimKm = 0; int gelecekBakimKm = 0; int kilometre = 0;
                while (npgsqlDataReader.Read())
                {
                    gecmisBakimKm = Convert.ToInt32(npgsqlDataReader[0]); // İlk sütun
                    gelecekBakimKm = npgsqlDataReader.GetInt32(1); // İkinci sütun
                    kilometre = npgsqlDataReader.GetInt32(2); // Üçüncü sütun
                }
                label14.Text = kilometre.ToString();
                label11.Text = gecmisBakimKm.ToString();
                label12.Text = gelecekBakimKm.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"bakım bilgisi gelmedi.\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void button7_Click(object sender, EventArgs e)
        {   
            if(textBox4.Text ==null || textBox4.Text =="")
            {
                return;

            }

            try
            {
                NpgsqlCommand sqlCommand3 = new NpgsqlCommand("SELECT araclar.aracno,araclar.kilometre  FROM araclar  INNER JOIN bakim  ON araclar.aracno = bakim.aracno WHERE araclar.aracplaka = @p1", sql.Baglantı());
                sqlCommand3.Parameters.AddWithValue("@p1", textBox4.Text); // Araç plakası için parametre
                NpgsqlDataReader npgsqlDataReader = sqlCommand3.ExecuteReader();
                int aracnomuz = 0; int güncelKm = 0;
                while (npgsqlDataReader.Read())
                {
                    aracnomuz = npgsqlDataReader.GetInt32(0); güncelKm = npgsqlDataReader.GetInt32(1);
                }
                // Bakım tablosunda geçmiş bakım ve gelecek bakımı güncelle
                NpgsqlCommand bakımGüncelleCommand = new NpgsqlCommand(
                    "UPDATE bakim " +
                    "SET gecmisbakimkm=@p1, gelecekbakimkm=@p2 " +
                    "WHERE aracno=@p3",
                    sql.Baglantı());
                // Parametreler
                bakımGüncelleCommand.Parameters.AddWithValue("@p1", güncelKm); // Geçmiş bakım için yeni kilometre
                bakımGüncelleCommand.Parameters.AddWithValue("@p2", güncelKm + 10000); // Gelecek bakım, varsayalım +10.000 km
                bakımGüncelleCommand.Parameters.AddWithValue("@p3", aracnomuz); // Güncellenecek aracın ID'si


                // Sorguyu çalıştır
                bakımGüncelleCommand.ExecuteNonQuery();

                MessageBox.Show("Bakım tablosu başarıyla güncellendi.");

            }
            catch (Exception ex)
            {

                MessageBox.Show($"  bakim güncellenmedi .\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void button18_Click(object sender, EventArgs e)
        {

            try
            {
                // Ücretin veritabanında mevcut olup olmadığını kontrol et
                NpgsqlCommand kontrol = new NpgsqlCommand("SELECT COUNT(*) FROM gunlukucretler WHERE ucret=@p1", sql.Baglantı());
                kontrol.Parameters.AddWithValue("@p1", Convert.ToInt32(txtucretsil.Text));

                int mevcutUcret = Convert.ToInt32(kontrol.ExecuteScalar());

                if (mevcutUcret > 0)
                {
                    // Ücret varsa, silme işlemi yapılır
                    NpgsqlCommand ucretsil = new NpgsqlCommand("DELETE FROM gunlukucretler WHERE ucret=@p1", sql.Baglantı());
                    ucretsil.Parameters.AddWithValue("@p1", Convert.ToInt32(txtucretsil.Text));
                    ucretsil.ExecuteNonQuery();
                    MessageBox.Show("Başarı ile silindi. Silinen ücret: " + txtucretsil.Text);
                }
                else
                {
                    // Ücret bulunamadıysa, kullanıcıya bilgi verir
                    MessageBox.Show("Ücret bulunamadı. Silme işlemi gerçekleştirilemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ücret güncellenmedi.\nHata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
