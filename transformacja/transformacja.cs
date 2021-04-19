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
    public partial class Transformacja : Form
    {
        private int width, height;
        public Transformacja()
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
            int red, green, blue;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color = b1.GetPixel(x, y);
                    if ((255 * Math.Pow(color.R / 255.0, double.Parse(nbNumber1.Text))) > 255)
                    {
                        red = 255;
                    }
                    else
                    {
                        red = (int)(255 * Math.Pow(color.R / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if ((255 * Math.Pow(color.G / 255.0, double.Parse(nbNumber1.Text)) > 255))
                    {
                        green = 255;
                    }
                    else
                    {
                        green = (int)(255 * Math.Pow(color.G / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if ((255 * Math.Pow(color.B / 255.0, double.Parse(nbNumber1.Text)) > 255))
                    {
                        blue = 255;
                    }
                    else
                    {
                        blue = (int)(255 * Math.Pow(color.B / 255.0, double.Parse(nbNumber1.Text)));
                    }
                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;
                    b2.SetPixel(x, y, Color.FromArgb(red, blue, green));
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
            int red, green, blue;
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
                    red = color.R;
                    green = color.G;
                    blue = color.B;
                    if ((wartosc * (color.R - 127) + 127) > 255)
                    {
                        red = 255;
                    }
                    else if ((wartosc * (color.R - 127) + 127) < 0)
                    {
                        red = 0;
                    }
                    else
                    {
                        red = (int)(wartosc * (color.R - 127) + 127);
                    }
                    if ((wartosc * (color.G - 127) + 127) > 255)
                    {
                        green = 255;
                    }
                    else if ((wartosc * (color.G - 127) + 127) < 0)
                    {
                        green = 0;
                    }
                    else
                    {
                        green = (int)(wartosc * (color.G - 127) + 127);
                    }
                    if ((wartosc * (color.B - 127) + 127) > 255)
                    {
                        blue = 255;
                    }
                    else if ((wartosc * (color.B - 127) + 127) < 0)
                    {
                        blue = 0;
                    }
                    else
                    {
                        blue = (int)(wartosc * (color.B - 127) + 127);
                    }
                    wynik.SetPixel(x, y, Color.FromArgb(red, green, blue));
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

