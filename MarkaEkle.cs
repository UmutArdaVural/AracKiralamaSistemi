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

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class MarkaEkle : Form
    { 
        public int kisinom = 0;
        public MarkaEkle()
        {
            InitializeComponent();
        }
        Sql_baglantı sql_Baglantı = new Sql_baglantı();

        public bool gecmismi = false;
        private void MarkaEkle_Load(object sender, EventArgs e)
        {
            if (gecmismi == false)
            {
                try
                {   // Kiralamalar tablosundan gerekli verileri al
                    NpgsqlCommand sqlCommand10 = new NpgsqlCommand(
                        "SELECT aracno, baslangictarihi, bitistarihi, ucret, oncekikm, sonrakikm FROM kiralamalar WHERE kisino=@p1 AND bitistarihi > CURRENT_DATE",
                        sql_Baglantı.Baglantı()
                    );
                    sqlCommand10.Parameters.AddWithValue("@p1", kisinom);
                    // Veri okuyucu başlat
                    NpgsqlDataReader sqlDataReader10 = sqlCommand10.ExecuteReader();

                    // DataGridView'i temizle
                    dataGridView1.Rows.Clear();

                    // Kiralamalar tablosundaki her bir satır için döngü
                    while (sqlDataReader10.Read())
                    {
                        // Aracno bilgisini al
                        int aracno = Convert.ToInt32(sqlDataReader10["aracno"]);

                        // Resimler tablosundan aracno'ya göre resmi al
                        NpgsqlCommand resimCommand = new NpgsqlCommand(
                            "SELECT buyukresim FROM resimler WHERE aracno = @aracno",
                            sql_Baglantı.Baglantı()
                        );


                        resimCommand.Parameters.AddWithValue("@aracno", aracno);

                        byte[] resimVerisi = resimCommand.ExecuteScalar() as byte[]; // Resmi byte[] olarak al

                        Image resim = null;
                        if (resimVerisi != null)
                        {
                            // Resim verisini dönüştür
                            using (MemoryStream ms = new MemoryStream(resimVerisi))
                            {
                                resim = Image.FromStream(ms);
                            }
                        }
                        NpgsqlCommand araccoomand = new NpgsqlCommand(
                         "SELECT aracplaka FROM araclar WHERE aracno = @aracno",
                         sql_Baglantı.Baglantı()
                     );
                        araccoomand.Parameters.AddWithValue("@aracno", aracno);
                        string plaka = araccoomand.ExecuteScalar() as string;

                        // DataGridView'e yeni satır ekle
                        dataGridView1.Rows.Add(
                            resim,                 // Resim sütunu (sıfırıncı index)
                            plaka,  // Arac No (1. index)
                            sqlDataReader10["baslangictarihi"],  // Başlangıç Tarihi (2. index)
                            sqlDataReader10["bitistarihi"],  // Bitiş Tarihi (3. index)
                            sqlDataReader10["ucret"],  // Ücret (4. index)
                            sqlDataReader10["oncekikm"],  // Önceki KM (5. index)
                            sqlDataReader10["sonrakikm"]   // Sonraki KM (6. index)
                        );
                        resimVerisi = null;
                    }

                    // DataReader ve bağlantıyı kapat
                    sqlDataReader10.Close();
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                try
                {   // Kiralamalar tablosundan gerekli verileri al
                    NpgsqlCommand sqlCommand10 = new NpgsqlCommand(
                        "SELECT aracno, baslangictarihi, bitistarihi, ucret, oncekikm, sonrakikm FROM kiralamalar WHERE kisino=@p1 AND bitistarihi < CURRENT_DATE",
                        sql_Baglantı.Baglantı()
                    );
                    sqlCommand10.Parameters.AddWithValue("@p1", kisinom);
                    // Veri okuyucu başlat
                    NpgsqlDataReader sqlDataReader10 = sqlCommand10.ExecuteReader();

                    // DataGridView'i temizle
                    dataGridView1.Rows.Clear();

                    // Kiralamalar tablosundaki her bir satır için döngü
                    while (sqlDataReader10.Read())
                    {
                        // Aracno bilgisini al
                        int aracno = Convert.ToInt32(sqlDataReader10["aracno"]);

                        // Resimler tablosundan aracno'ya göre resmi al
                        NpgsqlCommand resimCommand = new NpgsqlCommand(
                            "SELECT buyukresim FROM resimler WHERE aracno = @aracno",
                            sql_Baglantı.Baglantı()
                        );


                        resimCommand.Parameters.AddWithValue("@aracno", aracno);

                        byte[] resimVerisi = resimCommand.ExecuteScalar() as byte[]; // Resmi byte[] olarak al

                        Image resim = null;
                        if (resimVerisi != null)
                        {
                            // Resim verisini dönüştür
                            using (MemoryStream ms = new MemoryStream(resimVerisi))
                            {
                                resim = Image.FromStream(ms);
                            }
                        }
                        NpgsqlCommand araccoomand = new NpgsqlCommand(
                         "SELECT aracplaka FROM araclar WHERE aracno = @aracno",
                         sql_Baglantı.Baglantı()
                     );
                        araccoomand.Parameters.AddWithValue("@aracno", aracno);
                        string plaka = araccoomand.ExecuteScalar() as string;

                        // DataGridView'e yeni satır ekle
                        dataGridView1.Rows.Add(
                            resim,                 // Resim sütunu (sıfırıncı index)
                            plaka,  // Arac No (1. index)
                            sqlDataReader10["baslangictarihi"],  // Başlangıç Tarihi (2. index)
                            sqlDataReader10["bitistarihi"],  // Bitiş Tarihi (3. index)
                            sqlDataReader10["ucret"],  // Ücret (4. index)
                            sqlDataReader10["oncekikm"],  // Önceki KM (5. index)
                            sqlDataReader10["sonrakikm"]   // Sonraki KM (6. index)
                        );
                        resimVerisi = null;
                    }

                    // DataReader ve bağlantıyı kapat
                    sqlDataReader10.Close();
                }
                catch (Exception ex)
                {
                    // Hata durumunda mesaj göster
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }
    }
}
