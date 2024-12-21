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
    public partial class KullanıcıBakiyeEkle : Form
    {
        public KullanıcıBakiyeEkle()
        {
            InitializeComponent();
        }
        public int kisino = 0;
        Sql_baglantı sql_Baglantı = new Sql_baglantı();
        private void KullanıcıBakiyeEkle_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlCommand bakiyegetir = new NpgsqlCommand("Select musteribakiye From musteriler WHERE musterino=@p1 ", sql_Baglantı.Baglantı());
                bakiyegetir.Parameters.AddWithValue("@p1", kisino);
                NpgsqlDataReader bakiyegetirokuma = bakiyegetir.ExecuteReader();
                while (bakiyegetirokuma.Read())
                {
                    lblmevcutbakiye.Text = bakiyegetirokuma[0].ToString() + " TL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if( textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    NpgsqlCommand sqlCommand = new NpgsqlCommand(
                     "UPDATE musteriler SET musteribakiye = musteribakiye + @eklenenBakiye WHERE musterino = @musteriNo",
                     sql_Baglantı.Baglantı()
                    );
                    // Parametreleri ekleyin
                    sqlCommand.Parameters.AddWithValue("@eklenenBakiye", Convert.ToInt32(textBox1.Text));
                    sqlCommand.Parameters.AddWithValue("@musteriNo", kisino);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show(" Başarı ile eklendi . Eklenen tutar  : " + Convert.ToInt32(textBox1.Text) );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally {
                    try
                    {
                        NpgsqlCommand bakiyegetir = new NpgsqlCommand("Select musteribakiye From musteriler WHERE musterino=@p1 ", sql_Baglantı.Baglantı());
                        bakiyegetir.Parameters.AddWithValue("@p1", kisino);
                        NpgsqlDataReader bakiyegetirokuma = bakiyegetir.ExecuteReader();
                        while (bakiyegetirokuma.Read())
                        {
                            lblmevcutbakiye.Text = bakiyegetirokuma[0].ToString() + " TL";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("tüm alanları doldurun");
            }

        }
    }
}
