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
    public partial class Yönetici_Formcs : Form
    {
        public Yönetici_Formcs()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        Sql_baglantı sql = new Sql_baglantı();

        private void Yönetici_Formcs_Load(object sender, EventArgs e)
        {
            // muşteri combobox a ehliyet türü ekleme 
            NpgsqlCommand sqlCommand1 = new NpgsqlCommand("Select ehliyettur From ehliyetler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {

                cmbehliyet.Items.Add(sqlDataReader1[0]);
            }
            sql.Baglantı().Close();

            // müşteri şehir ekleme 
            NpgsqlCommand sqlCommand2 = new NpgsqlCommand("Select sehirad From sehirler ", sql.Baglantı());
            NpgsqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
            while (sqlDataReader2.Read())
            {

                cmbsehir.Items.Add(sqlDataReader2[0]);
            }
            sql.Baglantı().Close();
        }
        public int sehirno = 0;
        private void cmbsehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSehirTur = cmbsehir.SelectedItem.ToString();

            // Ehliyet numarasını tutacak değişken
            sehirno = -1;  // Varsayılan değeri -1, veritabanından gelen değerle değiştirilecek

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
                    sehirno = Convert.ToInt32(result);
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
        public int ehliyetno = 0;
        private void cmbehliyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEhliyetTur = cmbehliyet.SelectedItem.ToString();

            // Ehliyet numarasını tutacak değişken
            ehliyetno = -1;  // Varsayılan değeri -1, veritabanından gelen değerle değiştirilecek

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
                    ehliyetno = Convert.ToInt32(result);
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

        private void button16_Click(object sender, EventArgs e)
        {
            // Fonksiyon çağrısını yapmak için NpgsqlCommand kullanıyoruz.
            NpgsqlCommand sqlCommand = new NpgsqlCommand(
                "SELECT calisanvekişiekle(@kisiad, @kisooyad, @kisitc, @kisitur, @mail, @kistel, @kissehir, @ehliyetno, @calisansifre, @calisankullaniciadi);",
                sql.Baglantı()
            );

            // Parametreleri ekle
            sqlCommand.Parameters.AddWithValue("@kisiad", textad.Text);  // Kişi adı
            sqlCommand.Parameters.AddWithValue("@kisooyad", textsoyad.Text);  // Kişi soyadı
            sqlCommand.Parameters.AddWithValue("@kisitur", "C");  // Kişi türü (Çalışan)
            sqlCommand.Parameters.AddWithValue("@kisitc", maskedtc.Text);  // TC Kimlik numarası
            sqlCommand.Parameters.AddWithValue("@mail", textmail.Text);  // Mail adresi
            sqlCommand.Parameters.AddWithValue("@kistel", maskedtel.Text);  // Telefon numarası
            sqlCommand.Parameters.AddWithValue("@kissehir", sehirno);  // Şehir ID (Örneğin: İstanbul için 34)
            sqlCommand.Parameters.AddWithValue("@ehliyetno", ehliyetno);  // Ehliyet numarası
            sqlCommand.Parameters.AddWithValue("@calisansifre", txtsifre.Text);  // Çalışan şifresi
            sqlCommand.Parameters.AddWithValue("@calisankullaniciadi", txtkulllanıcıadı.Text);  // Çalışan kullanıcı adı

            try
            {
                // Veritabanına bağlan
                sql.Baglantı();

                // Fonksiyonu çalıştır ve sonucu al
                var result = sqlCommand.ExecuteScalar();


                MessageBox.Show("Çalışan başarıyla eklenmiştir.");


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

        private void button6_Click(object sender, EventArgs e)
        {   
            if(txtcalisanno.Text =="" || txtcalisanno.Text == null )
            {
                return ; 
            }

            NpgsqlCommand sqlCommand = new NpgsqlCommand(
               "SELECT calisaniyoneticiyap(@calisanno);",
               sql.Baglantı()
           );
            sqlCommand.Parameters.AddWithValue("@calisanno", Convert.ToInt32(txtcalisanno.Text));  // Çalışan numarası

            try
            {
                // Veritabanına bağlan
                sql.Baglantı();

                // Fonksiyonu çalıştır ve sonucu al
                var result = sqlCommand.ExecuteScalar();


                MessageBox.Show("Çalışan başarıyla yönetici tablosuna eklenmiştir.");


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
    }
}
