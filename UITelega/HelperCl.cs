using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UITelega
{
    public static class HelperCl
    {
        public static string pathPh;

        static HelperCl()
        {
            pathPh = System.Reflection.Assembly.GetExecutingAssembly().Location.TrimEnd("UITelega.exe".ToCharArray()) + "ph02.jpg";
        }

        public static void ResizeImg(string path)
        {
            Image img   = Image.FromFile(path);
            int nWidth  = img.Width;
            int nHeight = img.Height;

            while (nWidth > 100 && nHeight > 100)
            {
                nWidth -= nWidth / 100;
                nHeight -= nHeight / 100;
            }

            Image result = new Bitmap(nWidth, nHeight);
            
            using (Graphics g = Graphics.FromImage((Image)result))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, nWidth, nHeight);
                g.Dispose();
            }
            result.Save(pathPh);
        }

        public static void AnimationForm(System.Windows.Window w)
        {
            System.Windows.Media.Animation.DoubleAnimation dblAnim = new System.Windows.Media.Animation.DoubleAnimation
            {
                From = 0.0,
                To = 1.0,
                Duration = new System.Windows.Duration(TimeSpan.FromMilliseconds(500))
            };
            w.BeginAnimation(System.Windows.Window.OpacityProperty, dblAnim);
        }
    }
}
