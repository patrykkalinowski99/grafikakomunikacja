using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        private int width, height;
        int[] red = new int[256];
        int[] green = new int[256];
        int[] blue = new int[256];
        public Form1()
        {
            InitializeComponent();
        }
        private void bWczytaj_click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                obrazek1.Load(openFileDialog1.FileName);
                width = obrazek1.Image.Width;
                height = obrazek1.Image.Height;
                obrazek2.Image = new Bitmap(width, height);
            }
        }
        private int[] Skaluj(int[] arg)
        {
            int min = 0;
            for (int i = 0; i < 256; i++)
            {
                if (arg[i] != 0)
                {
                    min = i;
                    break;
                }
            }
            int max = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (arg[i] != 0)
                {
                    max = i;
                    break;
                }
            }
            int[] wynik = new int[256];
            double a = 255.0 / (max - min);

            for (int i = 0; i < 256; i++)
            {
                wynik[i] = (int)(a * (i - min));
            }
            return wynik;
        }
        private void bHistogram_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)obrazek1.Image;
            Color kolor;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    kolor = b1.GetPixel(x, y);

                    red[kolor.R]++;
                    green[kolor.G]++;
                    blue[kolor.B]++;
                }
            }
            wykres1.Series["R"].Points.Clear();
            wykres1.Series["G"].Points.Clear();
            wykres1.Series["B"].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                wykres1.Series["R"].Points.AddXY(i, red[i]);
                wykres1.Series["G"].Points.AddXY(i, green[i]);
                wykres1.Series["B"].Points.AddXY(i, blue[i]);
            }
            wykres1.Invalidate();
    }
        private void bUsredniajacy_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)obrazek1.Image;
            Bitmap b2 = (Bitmap)obrazek2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;

            int m1 = 1;
            int m2 = 1;
            int m3 = 1;
            int m4 = 1;
            int m5 = 1;
            int m6 = 1;
            int m7 = 1;
            int m8 = 1;
            int m9 = 1;
            int maski = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9;

            if (maski == 0) maski = 1;

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int r, g, b;

                    k1 = b1.GetPixel(x - 1, y - 1);
                    k2 = b1.GetPixel(x, y - 1);
                    k3 = b1.GetPixel(x + 1, y - 1);
                    k4 = b1.GetPixel(x - 1, y);
                    k5 = b1.GetPixel(x, y);
                    k6 = b1.GetPixel(x + 1, y);
                    k7 = b1.GetPixel(x - 1, y + 1);
                    k8 = b1.GetPixel(x, y + 1);
                    k9 = b1.GetPixel(x + 1, y + 1);

                    r = k1.R * m1 + k2.R * m2 + k3.R * m3 + k4.R * m4 + k5.R * m5 + k6.R * m6 + k7.R * m7 + k8.R * m8 + k9.R * m9;
                    r = r / maski;

                    b = k1.B * m1 + k2.B * m2 + k3.B * m3 + k4.B * m4 + k5.B * m5 + k6.B * m6 + k7.B * m7 + k8.B * m8 + k9.B * m9;
                    b = b / maski;

                    g = k1.G * m1 + k2.G * m2 + k3.G * m3 + k4.G * m4 + k5.G * m5 + k6.G * m6 + k7.G * m7 + k8.G * m8 + k9.G * m9;
                    g = g / maski;

                    if (r > 255) r = 255;
                    if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    if (g < 0) g = 0;


                    if (b > 255) b = 255;
                    if (b < 0) b = 0;

                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            obrazek2.Refresh();
        }
        private void bGauss_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)obrazek1.Image;
            Bitmap b2 = (Bitmap)obrazek2.Image;

            Color kolor1, kolor2, kolor3, kolor4, kolor5, kolor6, kolor7, kolor8, kolor9;

            int m1 = 1;
            int m2 = 2;
            int m3 = 1;
            int m4 = 2;
            int m5 = 4;
            int m6 = 2;
            int m7 = 1;
            int m8 = 2;
            int m9 = 1;
            int maski = m1 + m2 + m3 + m4 + m5 + m6 + m7 + m8 + m9;

            if (maski == 0) maski = 1;

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int r, g, b;

                    kolor1 = b1.GetPixel(x - 1, y - 1);
                    kolor2 = b1.GetPixel(x, y - 1);
                    kolor3 = b1.GetPixel(x + 1, y - 1);
                    kolor4 = b1.GetPixel(x - 1, y);
                    kolor5 = b1.GetPixel(x, y);
                    kolor6 = b1.GetPixel(x + 1, y);
                    kolor7 = b1.GetPixel(x - 1, y + 1);
                    kolor8 = b1.GetPixel(x, y + 1);
                    kolor9 = b1.GetPixel(x + 1, y + 1);


                    r = kolor1.R * m1 + kolor2.R * m2 + kolor3.R * m3 + kolor4.R * m4 + kolor5.R * m5 + kolor6.R * m6 + kolor7.R * m7 + kolor8.R * m8 + kolor9.R * m9;
                    r = r / maski;

                    b = kolor1.B * m1 + kolor2.B * m2 + kolor3.B * m3 + kolor4.B * m4 + kolor5.B * m5 + kolor6.B * m6 + kolor7.B * m7 + kolor8.B * m8 + kolor9.B * m9;
                    b = b / maski;


                    g = kolor1.G * m1 + kolor2.G * m2 + kolor3.G * m3 + kolor4.G * m4 + kolor5.G * m5 + kolor6.G * m6 + kolor7.G * m7 + kolor8.G * m8 + kolor9.G * m9;
                    g = g / maski;

                    if (r > 255) r = 255;
                    if (r < 0) r = 0;

                    if (g > 255) g = 255;
                    if (g < 0) g = 0;

                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            obrazek2.Refresh();
        }
        private void bSkaluj_Click(object sender, EventArgs e)
        {
            int[] LUTred = Skaluj(red);
            int[] LUTgreen = Skaluj(green);
            int[] LUTblue = Skaluj(blue);

            Bitmap b1 = (Bitmap)obrazek1.Image;
            Bitmap b2 = (Bitmap)obrazek2.Image;

            int[] r1 = new int[256];
            int[] g1 = new int[256];
            int[] bl1 = new int[256];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color k = b1.GetPixel(x, y);
                    Color newk = Color.FromArgb(LUTred[k.R], LUTgreen[k.G], LUTblue[k.B]);

                    b2.SetPixel(x, y, newk);

                    r1[newk.R]++;
                    g1[newk.G]++;
                    bl1[newk.B]++;
                }
            }
            obrazek2.Refresh();
            wykres2.Series["R"].Points.Clear();
            wykres2.Series["G"].Points.Clear();
            wykres2.Series["B"].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                wykres2.Series["R"].Points.AddXY(i, r1[i]);
                wykres2.Series["G"].Points.AddXY(i, g1[i]);
                wykres2.Series["B"].Points.AddXY(i, bl1[i]);
            }
            wykres2.Invalidate();
        }
    }
}
