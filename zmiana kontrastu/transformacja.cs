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
        
        private void bKontrast1(object sender, EventArgs e)
        {
            double wartosc = int.Parse(nbKontrast1.Text);
            Bitmap obrazek = (Bitmap)this.obrazek.Image;
            Bitmap wynik = (Bitmap)this.wynik.Image;
            Color color;
            int red, green, blue;
            if (wartosc < -128)
            {
                wartosc = -128;
            }
            else if (wartosc > 127)
            {
                wartosc = 127;
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color = obrazek.GetPixel(x, y);
                    red = color.R;
                    green = color.G;
                    blue = color.B;
                    if (wartosc >= 0 && wartosc <= 127)
                    {
                        if ((int)(127 / (127 - wartosc) * (color.R - wartosc)) > 255)
                        {
                            red = 255;
                        }
                        else if ((int)(127 / (127 - wartosc) * (color.R - wartosc)) < 0)
                        {
                            red = 0;
                        }
                        else
                        {
                            /*red = (int)(wartosc * (color.R - 127) + 127);*/
                            red = (int)(127 / (127 - wartosc) * (color.R - wartosc));
                        }
                        if ((int)(127 / (127 - wartosc) * (color.G - wartosc)) > 255)
                        {
                            green = 255;
                        }
                        else if ((int)(127 / (127 - wartosc) * (color.G - wartosc)) < 0)
                        {
                            green = 0;
                        }
                        else
                        {
                            /*green = (int)(wartosc * (color.G - 127) + 127);*/
                            green = (int)(127 / (127 - wartosc) * (color.G - wartosc));
                        }
                        if ((int)(127 / (127 - wartosc) * (color.B - wartosc)) > 255)
                        {
                            blue = 255;
                        }
                        else if ((int)(127 / (127 - wartosc) * (color.B - wartosc)) < 0)
                        {
                            blue = 0;
                        }
                        else
                        {
                            /*blue = (int)(wartosc * (color.B - 127) + 127);*/
                            blue = (int)(127 / (127 - wartosc) * (color.B - wartosc));
                        }
                    }
                    else if (wartosc < 0 && wartosc >= -128)
                    {
                        if ((int)((127 + wartosc) / 127 * (color.R - wartosc)) > 255)
                        {
                            red = 255;
                        }
                        else if ((int)((127 + wartosc) / 127 * (color.R - wartosc)) < 0)
                        {
                            red = 0;
                        }
                        else
                        {
                            red = (int)((127 + wartosc) / 127 * (color.R - wartosc));
                        }
                        if ((int)((127 + wartosc) / 127 * (color.G - wartosc)) > 255)
                        {
                            green = 255;
                        }
                        else if ((int)((127 + wartosc) / 127 * (color.G - wartosc)) < 0)
                        {
                            green = 0;
                        }
                        else
                        {
                            green = (int)((127 + wartosc) / 127 * (color.G - wartosc));
                        }
                        if ((int)((127 + wartosc) / 127 * (color.B - wartosc)) > 255)
                        {
                            blue = 255;
                        }
                        else if ((int)((127 + wartosc) / 127 * (color.B - wartosc)) < 0)
                        {
                            blue = 0;
                        }
                        else
                        {
                            blue = (int)((127 + wartosc) / 127 * (color.B - wartosc));
                        }
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

        private void bKontrast2(object sender, EventArgs e)
        {
            double wartosc = int.Parse(nbKontrast2.Text);
            Bitmap obrazek = (Bitmap)this.obrazek.Image;
            Bitmap wynik = (Bitmap)this.wynik.Image;
            Color color;
            int red, green, blue;
            if (wartosc < -128)
            {
                wartosc = -127;
            }
            else if (wartosc > 127)
            {
                wartosc = 127;
            }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    color = obrazek.GetPixel(x, y);
                    red = color.R;
                    green = color.G;
                    blue = color.B;
                    if (wartosc<=0 && wartosc>=127)
                    {
                        if ((int)((127 - wartosc) / 127 * color.R) > 255)
                        {
                            red = 255;
                        }
                        else if ((int)((127 - wartosc) / 127 * color.R) < 0)
                        {
                            red = 0;
                        }
                        else if (color.R < 127)
                        {
                            red = (int)((127 - wartosc) / 127 * color.R);
                        }
                        else if (color.R >= 127)
                        {
                            red = (int)((127 - wartosc) / 127 * color.R + 2*wartosc);
                        }

                        if ((int)((127 - wartosc) / 127 * color.B) > 255)
                        {
                            blue = 255;
                        }
                        else if ((int)((127 - wartosc) / 127 * color.B) < 0)
                        {
                            blue = 0;
                        }
                        else if (color.B < 127)
                        {
                            blue = (int)((127 - wartosc) / 127 * color.B);
                        }
                        else if (color.B >= 127)
                        {
                            blue = (int)((127 - wartosc) / 127 * color.B + 2*wartosc);
                        }

                        if ((int)((127 - wartosc) / 127 * color.G) > 255)
                        {
                            green = 255;
                        }
                        else if ((int)((127 - wartosc) / 127 * color.G) < 0)
                        {
                            green = 0;
                        }
                        else if (color.G < 127)
                        {
                            green = (int)((127 - wartosc) / 127 * color.G);
                        }
                        else if (color.G >= 127)
                        {
                            green = (int)((127 - wartosc) / 127 * color.G + 2*wartosc);
                        }
                    }
                    else if (wartosc>=-127 && wartosc<0)
                    {
                        if ((int)(127 / (127 + wartosc) * color.R) > 255)
                        {
                            red = 255;
                        }
                        else if ((int)(127 / (127 + wartosc) * color.R) < 0)
                        {
                            red = 0;
                        }
                        else if (color.R < 127+wartosc)
                        {
                            red = (int)((127 - wartosc) / 127 * color.R);
                        }
                        else if (color.R > 127- wartosc)
                        {
                            red = (int)((127 - wartosc) / 127 * color.R + 2 * wartosc);
                        }
                        else
                        {
                            red = 127;
                        }

                        if ((int)(127 / (127 + wartosc) * color.B) > 255)
                        {
                            blue = 255;
                        }
                        else if ((int)(127 / (127 + wartosc) * color.B) < 0)
                        {
                            blue = 0;
                        }
                        else if (color.B < 127 + wartosc)
                        {
                            blue = (int)((127 - wartosc) / 127 * color.B);
                        }
                        else if (color.B > 127 - wartosc)
                        {
                            blue = (int)((127 - wartosc) / 127 * color.B + 2 * wartosc);
                        }
                        else
                        {
                            blue = 127;
                        }

                        if ((int)(127 / (127 + wartosc) * color.G) > 255)
                        {
                            green = 255;
                        }
                        else if ((int)(127 / (127 + wartosc) * color.G) < 0)
                        {
                            green = 0;
                        }
                        else if (color.B < 127 + wartosc)
                        {
                            green = (int)((127 - wartosc) / 127 * color.G);
                        }
                        else if (color.G > 127 - wartosc)
                        {
                            green = (int)((127 - wartosc) / 127 * color.G + 2 * wartosc);
                        }
                        else
                        {
                            green = 127;
                        }
                    }
                    wynik.SetPixel(x, y, Color.FromArgb(red, green, blue));
                }
            }
            this.wynik.Refresh();
        }

        private void nbNumber1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

