using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16wzorow
{
    public partial class Mieszanie : Form
    {
        private int width, height;
        public Mieszanie()
        {
            InitializeComponent();
        }
        private void bWczytaj1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                obrazek1.Load(openFileDialog1.FileName);
                width = obrazek1.Image.Width;
                height = obrazek1.Image.Height;
                wynik.Image = new Bitmap(width, height);
            }
        }
        private void bWczytaj2(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                obrazek2.Load(openFileDialog1.FileName);

                width = obrazek1.Image.Width;

                height = obrazek1.Image.Height;

                wynik.Image = new Bitmap(width, height);

            }
        }

        private void bSuma(object sender, EventArgs e)
        {
            Bitmap bmObrazek1 = (Bitmap)obrazek1.Image;

            Bitmap bmObrazek2 = (Bitmap)obrazek2.Image;

            Bitmap bmWynik = (Bitmap)wynik.Image;



            Color color1, color2;

            int red, blue, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    color1 = bmObrazek1.GetPixel(x, y);

                    color2 = bmObrazek2.GetPixel(x, y);



                    red = (color1.R + color2.R);

                    blue = (color1.B + color2.B);

                    g = (color1.G + color2.G);



                    if (red > 255) red = 255;

                    if (red < 0) red = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (blue > 255) blue = 255;

                    if (blue < 0) blue = 0;

                    bmWynik.SetPixel(x, y, Color.FromArgb(red, blue, g));

                }

            }

            wynik.Refresh();
        }
        private void bOdejmowanie(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    r = (int)((k1.R - k2.R));

                    g = (int)((k1.G - k2.G));

                    b = (int)((k1.B - k2.B));

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, g, b));



                }

            }

            wynik.Refresh();

        }



        private void bRoznica(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k1.R < k2.R)

                    {

                        r = (k2.R - k1.R);

                    }

                    else

                    {

                        r = (k1.R - k2.R);

                    }



                    if (k1.G < k2.G)

                    {

                        g = (k2.G - k1.G);

                    }

                    else

                    {

                        g = (k1.G - k2.G);

                    }

                    if (k1.B < k2.B)

                    {

                        b = (k2.B - k1.B);

                    }

                    else

                    {

                        b = (k1.B - k2.B);

                    }

                    b3.SetPixel(x, y, Color.FromArgb(r, g, b));

                }

            }

            wynik.Refresh();

        }



        private void bMnozenie(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    r = (k1.R * k2.R) / 255;

                    b = (k1.B * k2.B) / 255;

                    g = (k1.G * k2.G) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }



        private void bMnozenieReverse(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    r = k1.R + k2.R - (k1.R * k2.R) / 255;

                    g = k1.G + k2.G - (k1.G * k2.G) / 255;

                    b = k1.B + k2.B - (k1.B * k2.B) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }



        private void bNegacja(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if ((255 - k1.R - k2.R) > 0)

                    {

                        r = 255 - (255 - k1.R - k2.R);

                    }

                    else

                    {

                        r = 255 - (255 - k1.R - k2.R) * (-1);

                    }



                    if ((255 - k1.G - k1.G) > 0)

                    {

                        g = 255 - (255 - k1.G - k2.G);

                    }

                    else

                    {

                        g = 255 - (255 - k1.G - k2.G) * (-1);

                    }



                    if ((255 - k1.B - k2.B) > 0)

                    {

                        b = 255 - (255 - k1.B - k2.B);

                    }

                    else

                    {

                        b = 255 - (255 - k1.B - k2.B) * (-1);

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }



        private void bCiemniejsze(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k1.R < k2.R)

                    {

                        r = k1.R;

                    }

                    else

                    {

                        r = k2.R;

                    }

                    if (k1.G < k2.G)

                    {

                        g = k1.G;

                    }

                    else

                    {

                        g = k2.G;

                    }

                    if (k1.B < k2.B)

                    {

                        b = k1.B;

                    }

                    else

                    {

                        b = k2.B;

                    }

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }



        private void bJasniejsze(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    if (k1.R < k2.R)

                    {

                        r = k2.R;

                    }

                    else

                    {

                        r = k1.R;

                    }

                    if (k1.G < k2.G)

                    {

                        g = k2.G;

                    }

                    else

                    {

                        g = k1.G;

                    }

                    if (k1.B < k2.B)

                    {

                        b = k2.B;

                    }

                    else

                    {

                        b = k1.B;

                    }



                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }

        private void bWylaczenie(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    r = k1.R + k2.R - 2 * (k1.R * k2.R) / 255;

                    g = k1.G + k2.G - 2 * (k1.G * k2.G) / 255;

                    b = k1.B + k2.B - 2 * (k1.B * k2.B) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();

        }

        private void bNakladka(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int red, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k1.R < 128)

                    {

                        red = 2 * k1.R * k2.R / 255;

                    }

                    else

                    {

                        red = 255 - 2 * ((255 - k1.R) * (255 - k2.R)) / 255;

                    }



                    if (k1.G < 128)

                    {

                        g = 2 * k1.G * k2.G / 255;

                    }

                    else

                    {

                        g = 255 - 2 * ((255 - k1.G) * (255 - k2.G)) / 255;

                    }



                    if (k1.B < 128)

                    {

                        b = 2 * k1.B * k2.B / 255;

                    }

                    else

                    {

                        b = 255 - 2 * ((255 - k1.B) * (255 - k2.B)) / 255;

                    }

                    if (red > 255) red = 255;

                    if (red < 0) red = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(red, b, g));

                }

            }

            wynik.Refresh();



        }





        private void bOstreSwiatlo(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k2.R == 0)

                    {

                        r = 2 * k1.R * k2.R / 255;

                    }

                    else

                    {

                        r = 255 - 2 * ((255 - k1.R) * (255 - k2.R)) / 255;

                    }



                    if (k2.G == 0)

                    {

                        g = 2 * k1.G * k2.G / 255;

                    }

                    else

                    {

                        g = 255 - 2 * ((255 - k1.G) * (255 - k2.G)) / 255;

                    }



                    if (k2.B == 0)

                    {

                        b = 2 * k1.B * k2.B / 255;

                    }

                    else

                    {

                        b = 255 - 2 * ((255 - k1.B) * (255 - k2.B)) / 255;

                    }



                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();



        }



        private void bLagodneSwiatlo(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k2.R < 128)

                    {

                        r = (2 * k1.R * k2.R + (k1.R * k1.R) * (255 - 2 * k2.R)) / 255;

                    }

                    else

                    {

                        r = (k1.R * (2 * k2.R - 255) + (2 * k1.R * (255 - k2.R))) / 255;



                    }



                    if (k1.G < 128)

                    {

                        g = (2 * k1.G * k2.G + (k1.G * k1.G) * (255 - 2 * k2.G)) / 255;

                    }

                    else

                    {

                        g = (k1.G * (2 * k2.G - 255) + (2 * k1.G * (255 - k2.G))) / 255;

                    }



                    if (k1.B < 128)

                    {

                        b = (2 * k1.B * k2.B + (k1.B * k1.B) * (255 - 2 * k2.B)) / 255;

                    }

                    else

                    {

                        b = (k1.B * (2 * k2.B - 255) + (2 * k1.B * (255 - k2.B))) / 255;

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();



        }



        private void bRozcienczenie(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    if (k2.R == 255)

                    {

                        r = 255;

                    }

                    else if (k2.R == 0)

                    {

                        r = 255;

                    }

                    else

                    {

                        r = (int)((k1.R * 255 / (255 - k2.R)));

                    }

                    if (k2.G == 255)

                    {

                        g = 255;

                    }

                    else if (k2.G == 0)

                    {

                        g = 255;

                    }

                    else

                    {

                        g = (int)((k1.G * 255 / (255 - k2.G)));

                    }

                    if (k2.B == 255)

                    {

                        b = 255;

                    }

                    else if (k2.B == 0)

                    {

                        b = 255;

                    }

                    else

                    {

                        b = (int)((k1.B * 255 / (255 - k2.B)));

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();



        }



        private void bWypalanie(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k2.R == 0)

                    {

                        r = 255;

                    }

                    else

                    {

                        r = (int)(255 - (((255 - k1.R) * 255) / k2.R));

                    }

                    if (k2.G == 0)

                    {

                        g = 255;

                    }

                    else

                    {

                        g = (int)(255 - (((255 - k1.G) * 255) / k2.G));

                    }

                    if (k2.B == 0)

                    {

                        b = 255;

                    }

                    else

                    {

                        b = (int)(255 - (((255 - k1.B) * 255) / k2.B));

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();



        }



        private void bReflectMode(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)obrazek1.Image;

            Bitmap b2 = (Bitmap)obrazek2.Image;

            Bitmap b3 = (Bitmap)wynik.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (255 - k2.R == 0)

                    {

                        r = 0;

                    }

                    else

                    {

                        r = (k1.R * k1.R) / (255 - k2.R);

                    }



                    if (255 - k2.G == 0)

                    {

                        g = 0;

                    }

                    else

                    {

                        g = (k1.G * k1.G) / (255 - k2.G);

                    }



                    if (255 - k2.B == 0)

                    {

                        b = 0;

                    }

                    else

                    {

                        b = (k1.B * k1.B) / (255 - k2.B);

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            wynik.Refresh();



        }

        private void bPrzezroczystosc(object sender, EventArgs e)

        {

            Bitmap bmObrazek1 = (Bitmap)obrazek1.Image;

            Bitmap bmObrazek2 = (Bitmap)obrazek2.Image;

            Bitmap bmWynik = (Bitmap)wynik.Image;



            Color color1, color2;

            int red, green, blue;

            int przezroczystoscValue = int.Parse(tbPrzezroczystoscValue.Text);

            for (int x = 0; x < width; x++)

            {

                for (int y = 0; y < height; y++)

                {

                    color1 = bmObrazek1.GetPixel(x, y);

                    color2 = bmObrazek2.GetPixel(x, y);

                    red = (1 - przezroczystoscValue) * color2.R + przezroczystoscValue * color1.R;

                    green = (1 - przezroczystoscValue) * color2.G + przezroczystoscValue * color1.G;

                    blue = (1 - przezroczystoscValue) * color2.B + przezroczystoscValue * color1.B;

                    if (red > 255) red = 255;

                    if (red < 0) red = 0;

                    if (green > 255) green = 255;

                    if (green < 0) green = 0;

                    if (blue > 255) blue = 255;

                    if (blue < 0) blue = 0;

                    bmWynik.SetPixel(x, y, Color.FromArgb(red, blue, green));

                }

            }

            wynik.Refresh();



        }

        
    }

}

