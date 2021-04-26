
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
            this.button4 = new System.Windows.Forms.Button();
            this.nbKontrast1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nbKontrast2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKontrast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKontrast2)).BeginInit();
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(438, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Kontrast 1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.bKontrast1);
            // 
            // nbKontrast1
            // 
            this.nbKontrast1.Location = new System.Drawing.Point(391, 312);
            this.nbKontrast1.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nbKontrast1.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.nbKontrast1.Name = "nbKontrast1";
            this.nbKontrast1.Size = new System.Drawing.Size(41, 20);
            this.nbKontrast1.TabIndex = 9;
            this.nbKontrast1.ValueChanged += new System.EventHandler(this.nbNumber2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kontrast>0 - zwiększenie kontrastu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "wariant 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kontrast<0 - zmniejszenie kontrastu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "wariant 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kontrast>0 - zwiększenie kontrastu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kontrast<0 - zmniejszenie kontrastu";
            // 
            // nbKontrast2
            // 
            this.nbKontrast2.Location = new System.Drawing.Point(391, 349);
            this.nbKontrast2.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.nbKontrast2.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.nbKontrast2.Name = "nbKontrast2";
            this.nbKontrast2.Size = new System.Drawing.Size(41, 20);
            this.nbKontrast2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(438, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = "Kontrast 2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bKontrast2);
            // 
            // Transformacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(536, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nbKontrast2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbKontrast1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximumSize = new System.Drawing.Size(552, 415);
            this.MinimumSize = new System.Drawing.Size(552, 415);
            this.Name = "Transformacja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modyfikacja kontrastu";
            this.TransparencyKey = System.Drawing.Color.Cornsilk;
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKontrast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbKontrast2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.PictureBox wynik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown nbKontrast1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nbKontrast2;
        private System.Windows.Forms.Button button1;
    }
}

