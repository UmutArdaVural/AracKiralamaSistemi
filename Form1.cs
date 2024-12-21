using System.Drawing.Drawing2D;

namespace Araç_Kiralama_Ve_Yönetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Yuvarlak köşeleri oluşturacak bir GraphicsPath nesnesi
            GraphicsPath path = new GraphicsPath();
            int radius = 30; // Yuvarlaklık yarıçapı
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.MediumTurquoise;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.WhiteSmoke;

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }
        int x, y;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            this.Left += e.X - x;
            this.Top += e.Y - y;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Azure;
            button1.ForeColor = Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumTurquoise;
            button1.ForeColor = Color.Black;

        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Azure;
            button2.ForeColor = Color.White;

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumTurquoise;
            button2.ForeColor = Color.Black;

        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Azure;
            button3.ForeColor = Color.White;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumTurquoise;
            button3.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide(); // Form1'i aç

            Giris giris = new Giris();
            giris.label4.Text = button1.Text;

            giris.Show(); // Giris formunu gizle
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Giris giris = new Giris();
            giris.label4.Text = button2.Text;

            giris.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Form1'i aç

            Giris giris = new Giris();
            giris.label4.Text = button3.Text;

            giris.Show(); // Giris formunu gizle
        }
    }
}
