using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Araç_Kiralama_Ve_Yönetim
{
    public class Umut_Arda_Vural_Ellipse__Controller : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private Control control;
        private int cornerRadius = 25;

        public Control TargetControl
        {
            get { return control; }
            set
            {
                control = value;
                ApplyRoundedCorners();

                // Boyut değişikliklerini dinle
                control.SizeChanged += (sender, eventArgs) => ApplyRoundedCorners();
            }
        }

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                if (control != null)
                {
                    ApplyRoundedCorners();
                }
            }
        }

        private void ApplyRoundedCorners()
        {
            if (control != null && control.ClientRectangle.Width > 0 && control.ClientRectangle.Height > 0)
            {
                // Yuvarlak köşeli bölgeyi uygula
                IntPtr roundedRegion = CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerRadius, cornerRadius);
                control.Region = Region.FromHrgn(roundedRegion);

                // GDI kaynaklarını serbest bırak
                DeleteObject(roundedRegion);
            }
        }

        [DllImport("Gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);
    }
}
