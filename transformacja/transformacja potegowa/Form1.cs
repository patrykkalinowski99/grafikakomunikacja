using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transformacja_potegowa
{
    public partial class Form1 : Form
    {
        private int width, height;
        public Form1()
        {
            InitializeComponent();
        }
        private void bWczytaj(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                obrazek.Load(openFileDialog1.FileName);
                width = obrazek.Image.Width;
                height = obrazek.Image.Height;
                wynik.Image = new Bitmap(width, height);
            }
        }
        private void bTransformacja(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)obrazek.Image;
            Bitmap b2 = (Bitmap)wynik.Image;
            Color color;
            int r, g, b;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color = b1.GetPixel(x, y);
                    if ((255 * Math.Pow(color.R / 255.0, double.Parse(nbNumber1.Text))) > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = (int)(255 * Math.Pow(color.R / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if ((255 * Math.Pow(color.G / 255.0, double.Parse(nbNumber1.Text)) > 255))
                    {
                        g = 255;
                    }
                    else
                    {
                        g = (int)(255 * Math.Pow(color.G / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if ((255 * Math.Pow(color.B / 255.0, double.Parse(nbNumber1.Text)) > 255))
                    {
                        b = 255;
                    }
                    else
                    {
                        b = (int)(255 * Math.Pow(color.B / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if (r > 255) r = 255;
                    if (r < 0) r = 0;
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                    b2.SetPixel(x, y, Color.FromArgb(r, b, g));
                }
            }
            wynik.Refresh();
        }
        private void bKontrast(object sender, EventArgs e)
        {
            double wartosc = int.Parse(nbNumber2.Text);
            Bitmap obrazek = (Bitmap)this.obrazek.Image;
            Bitmap wynik = (Bitmap)this.wynik.Image;
            Color color;
            int r, g, b;
            if (wartosc <= 0)
            {
                wartosc = 1.0 + (wartosc / 256.0);
            }
            else
            {
                wartosc = 256.0 / Math.Pow(2, Math.Log(257 - wartosc, 2));
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color = obrazek.GetPixel(x, y);
                    r = color.R;
                    g = color.G;
                    b = color.B;
                    if ((wartosc * (color.R - 127) + 127) > 255)
                    {
                        r = 255;
                    }
                    else if ((wartosc * (color.R - 127) + 127) < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = (int)(wartosc * (color.R - 127) + 127);
                    }
                    if ((wartosc * (color.G - 127) + 127) > 255)
                    {
                        g = 255;
                    }
                    else if ((wartosc * (color.G - 127) + 127) < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = (int)(wartosc * (color.G - 127) + 127);
                    }
                    if ((wartosc * (color.B - 127) + 127) > 255)
                    {
                        b = 255;
                    }
                    else if ((wartosc * (color.B - 127) + 127) < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = (int)(wartosc * (color.B - 127) + 127);
                    }
                    wynik.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.wynik.Refresh();
        }
        private void nbNumber2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void obrazek1_Click(object sender, EventArgs e)
        {

        }
        private void nbNumber1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

