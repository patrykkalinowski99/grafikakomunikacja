
namespace transformacja_potegowa
{
    partial class Transformacja
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.wynik = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nbNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nbNumber2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(10, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wczytaj zdjęcie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bWczytaj);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // obrazek
            // 
            this.obrazek.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.obrazek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.obrazek.Location = new System.Drawing.Point(10, 25);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(256, 275);
            this.obrazek.TabIndex = 2;
            this.obrazek.TabStop = false;
            this.obrazek.Click += new System.EventHandler(this.obrazek1_Click);
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wynik.Location = new System.Drawing.Point(272, 25);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(256, 275);
            this.wynik.TabIndex = 3;
            this.wynik.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(176, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "Transformuj";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.bTransformacja);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(176, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kontrast";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.bKontrast);
            // 
            // nbNumber1
            // 
            this.nbNumber1.Location = new System.Drawing.Point(129, 306);
            this.nbNumber1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbNumber1.Name = "nbNumber1";
            this.nbNumber1.Size = new System.Drawing.Size(41, 20);
            this.nbNumber1.TabIndex = 8;
            this.nbNumber1.ValueChanged += new System.EventHandler(this.nbNumber1_ValueChanged);
            // 
            // nbNumber2
            // 
            this.nbNumber2.Location = new System.Drawing.Point(129, 332);
            this.nbNumber2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nbNumber2.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.nbNumber2.Name = "nbNumber2";
            this.nbNumber2.Size = new System.Drawing.Size(41, 20);
            this.nbNumber2.TabIndex = 9;
            this.nbNumber2.ValueChanged += new System.EventHandler(this.nbNumber2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kontrast: przyciemnianie < 0 > rozjaśnianie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "zakres [-255..255]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "zakres [0..1]";
            // 
            // Transformacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(536, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbNumber2);
            this.Controls.Add(this.nbNumber1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximumSize = new System.Drawing.Size(552, 415);
            this.MinimumSize = new System.Drawing.Size(552, 415);
            this.Name = "Transformacja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transformacja liniowa obrazu";
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.PictureBox wynik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown nbNumber1;
        private System.Windows.Forms.NumericUpDown nbNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

