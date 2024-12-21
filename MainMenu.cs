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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            button10.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI1 == false)
            {
                TIKLANDIMI1 = true;
                button1.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI6 = false;
                TIKLANDIMI7 = false;

                button2.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;



                Musteri_Arac_Arama MCA = new Musteri_Arac_Arama();
                MCA.FormBorderStyle = FormBorderStyle.None;
                MCA.Dock = DockStyle.Fill;
                MCA.TopLevel = false;
                panel2.Controls.Clear();
                panel2.Controls.Add(MCA);
                MCA.Show();
            }


        }

        public bool TIKLANDIMI1 = false;
        public bool TIKLANDIMI2 = false;
        public bool TIKLANDIMI3 = false;
        public bool TIKLANDIMI4 = false;
        public bool TIKLANDIMI5 = false;
        public bool TIKLANDIMI6 = false;
        public bool TIKLANDIMI7 = false;


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI2 == false)
            {
                button1.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;

                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                TIKLANDIMI2 = true;
                panel2.Controls.Clear();
                button2.BackColor = Color.LightSeaGreen;
                TIKLANDIMI1 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI6 = false;
                TIKLANDIMI7 = false;
                MarkaEkle markaEkle = new MarkaEkle(); // form çağır
                markaEkle.Dock = DockStyle.Fill;
                markaEkle.TopLevel = false;
                markaEkle.kisinom = Convert.ToInt32(lblkisino.Text); // değişken taşıma
                panel2.Controls.Add(markaEkle);
                markaEkle.gecmismi = false;
                markaEkle.Show();

                // markaEkle.kisino = Convert.ToInt32(lblkisino.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI3 == false)
            {
                TIKLANDIMI3 = true;
                button4.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI1 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI6 = false;
                TIKLANDIMI7 = false;
                panel2.Controls.Clear();
                button1.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
                panel2.Controls.Clear();
                MarkaEkle markaEkle = new MarkaEkle(); // form çağır
                markaEkle.Dock = DockStyle.Fill;
                markaEkle.TopLevel = false;
                markaEkle.kisinom = Convert.ToInt32(lblkisino.Text); // değişken taşıma
                panel2.Controls.Add(markaEkle);
                markaEkle.gecmismi = true;
                markaEkle.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI4 == false)
            {
                TIKLANDIMI4 = true;
                button5.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI1 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI6 = false;
                TIKLANDIMI7 = false;
                panel2.Controls.Clear();
                button1.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button6.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI5 == false)
            {
                TIKLANDIMI5 = true;
                button6.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI1 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI6 = false;
                TIKLANDIMI7 = false;
                panel2.Controls.Clear();
                button1.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button8.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;

                KullanıcıBakiyeEkle bakiyeEkle = new KullanıcıBakiyeEkle(); // form çağır
                bakiyeEkle.Dock = DockStyle.Fill;
                bakiyeEkle.TopLevel = false;
                bakiyeEkle.kisino = Convert.ToInt32(lblkisino.Text); // değişken taşıma
                bakiyeEkle.kisino = Convert.ToInt32(lblkisino.Text);
                panel2.Controls.Add(bakiyeEkle);
                bakiyeEkle.Show();
                

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI6 == false)
            {
                TIKLANDIMI6 = true;
                button8.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI1 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI7 = false;
                panel2.Controls.Clear();
                button1.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button6.BackColor = Color.AliceBlue;
                button9.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TIKLANDIMI7 == false)
            {
                TIKLANDIMI7 = true;
                button9.BackColor = Color.LightSeaGreen;
                TIKLANDIMI2 = false;
                TIKLANDIMI1 = false;
                TIKLANDIMI3 = false;
                TIKLANDIMI4 = false;
                TIKLANDIMI5 = false;
                TIKLANDIMI6 = false;
                panel2.Controls.Clear();
                button1.BackColor = Color.AliceBlue;
                button4.BackColor = Color.AliceBlue;
                button5.BackColor = Color.AliceBlue;
                button10.BackColor = Color.AliceBlue;

                button6.BackColor = Color.AliceBlue;
                button8.BackColor = Color.AliceBlue;
                button2.BackColor = Color.AliceBlue;
            }
        }
        public string plaka;
        public void button10_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            TIKLANDIMI7 = false;
            button10.BackColor = Color.LightSeaGreen;
            TIKLANDIMI2 = false;
            TIKLANDIMI1 = false;
            TIKLANDIMI3 = false;
            TIKLANDIMI4 = false;
            TIKLANDIMI5 = false;
            TIKLANDIMI6 = false;

            AracKiralaSayfası aracKiralaSayfası = new AracKiralaSayfası(); // form çağır
            aracKiralaSayfası.Dock = DockStyle.Fill;
            aracKiralaSayfası.TopLevel = false;
            aracKiralaSayfası.plakaal = plaka; // değişken taşıma
            aracKiralaSayfası.kisino = Convert.ToInt32(lblkisino.Text); 
            panel2.Controls.Add(aracKiralaSayfası);
            aracKiralaSayfası.Show();
            aracKiralaSayfası.lblplaka.Text = plaka;

            button1.BackColor = Color.AliceBlue;
            button4.BackColor = Color.AliceBlue;
            button5.BackColor = Color.AliceBlue;
            button9.BackColor = Color.AliceBlue;

            button6.BackColor = Color.AliceBlue;
            button8.BackColor = Color.AliceBlue;
            button2.BackColor = Color.AliceBlue;

        }

        private void UserInformation_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
