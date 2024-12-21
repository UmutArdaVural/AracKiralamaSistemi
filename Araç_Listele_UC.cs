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
    public partial class Araç_Listele_UC : UserControl
    {
        public Araç_Listele_UC()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string TextData
        {
            get { return lblaracplaka.Text; } // veya myLabel.Text
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MainMenu currentMainMenu = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();

            if (currentMainMenu != null)
            {
                AracKiralaSayfası aracKiralaSayfası = new AracKiralaSayfası();
                aracKiralaSayfası.aracplaka = lblaracplaka.Text;
                // MainMenu bulunduysa işlem yap
                currentMainMenu.plaka = TextData;

                currentMainMenu.button10_Click(currentMainMenu.button10, EventArgs.Empty);

            }
            else
            {
                // MainMenu açık değilse
                MessageBox.Show("MainMenu örneği bulunamadı.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
