
namespace _16wzorow
{
    partial class Mieszanie
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
            this.button3 = new System.Windows.Forms.Button();
            this.obrazek1 = new System.Windows.Forms.PictureBox();
            this.obrazek2 = new System.Windows.Forms.PictureBox();
            this.wynik = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tbPrzezroczystoscValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "WCZYTAJ OBRAZEK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bWczytaj1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "WCZYTAJ OBRAZEK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bWczytaj2);
            // 
            // obrazek1
            // 
            this.obrazek1.BackColor = System.Drawing.SystemColors.Control;
            this.obrazek1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.obrazek1.Location = new System.Drawing.Point(14, 47);
            this.obrazek1.Name = "obrazek1";
            this.obrazek1.Size = new System.Drawing.Size(233, 215);
            this.obrazek1.TabIndex = 3;
            this.obrazek1.TabStop = false;
            // 
            // obrazek2
            // 
            this.obrazek2.BackColor = System.Drawing.SystemColors.Control;
            this.obrazek2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.obrazek2.Location = new System.Drawing.Point(254, 47);
            this.obrazek2.Name = "obrazek2";
            this.obrazek2.Size = new System.Drawing.Size(233, 215);
            this.obrazek2.TabIndex = 4;
            this.obrazek2.TabStop = false;
            // 
            // wynik
            // 
            this.wynik.BackColor = System.Drawing.SystemColors.Control;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wynik.Location = new System.Drawing.Point(495, 15);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(639, 505);
            this.wynik.TabIndex = 5;
            this.wynik.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "SUMA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bSuma);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(254, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "ODEJMOWANIE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.bOdejmowanie);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 303);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(233, 25);
            this.button6.TabIndex = 8;
            this.button6.Text = "RÓŻNICA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.bRoznica);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(254, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 25);
            this.button7.TabIndex = 9;
            this.button7.Text = "MNOŻENIE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.bMnozenie);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(14, 335);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(233, 25);
            this.button8.TabIndex = 10;
            this.button8.Text = "MNOŻENIE ODWROTNOŚCI";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bMnozenieReverse);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(254, 335);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(233, 25);
            this.button9.TabIndex = 11;
            this.button9.Text = "NEGACJA";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.bNegacja);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(14, 367);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 25);
            this.button10.TabIndex = 12;
            this.button10.Text = "CIEMNIEJSZE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.bCiemniejsze);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(254, 367);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 25);
            this.button11.TabIndex = 13;
            this.button11.Text = "JAŚNIEJSZE";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.bJasniejsze);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(14, 399);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(233, 25);
            this.button12.TabIndex = 14;
            this.button12.Text = "WYŁĄCZENIE";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.bWylaczenie);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(254, 399);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(233, 25);
            this.button13.TabIndex = 15;
            this.button13.Text = "NAKŁADKA";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.bNakladka);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(14, 431);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(233, 25);
            this.button14.TabIndex = 16;
            this.button14.Text = "OSTRE ŚWIATŁO";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.bOstreSwiatlo);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(254, 431);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(233, 25);
            this.button15.TabIndex = 17;
            this.button15.Text = "ŁAGODNE ŚWIATŁO";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.bLagodneSwiatlo);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(14, 463);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(233, 25);
            this.button16.TabIndex = 18;
            this.button16.Text = "ROZCIEŃCZENIE";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.bRozcienczenie);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(254, 463);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(233, 25);
            this.button17.TabIndex = 19;
            this.button17.Text = "WYPALANIE";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.bWypalanie);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(14, 495);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(233, 25);
            this.button18.TabIndex = 20;
            this.button18.Text = "REFLECT MODE";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.bReflectMode);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(254, 495);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(163, 25);
            this.button19.TabIndex = 21;
            this.button19.Text = "PRZEŹROCZYSTOŚĆ";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.bPrzezroczystosc);
            // 
            // tbPrzezroczystoscValue
            // 
            this.tbPrzezroczystoscValue.Location = new System.Drawing.Point(423, 497);
            this.tbPrzezroczystoscValue.Name = "tbPrzezroczystoscValue";
            this.tbPrzezroczystoscValue.Size = new System.Drawing.Size(64, 21);
            this.tbPrzezroczystoscValue.TabIndex = 23;
            this.tbPrzezroczystoscValue.Text = "0";
            // 
            // Mieszanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1148, 530);
            this.Controls.Add(this.tbPrzezroczystoscValue);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.obrazek2);
            this.Controls.Add(this.obrazek1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximumSize = new System.Drawing.Size(1164, 569);
            this.MinimumSize = new System.Drawing.Size(1164, 569);
            this.Name = "Mieszanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mieszanie dwóch obrazków";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox obrazek1;
        private System.Windows.Forms.PictureBox obrazek2;
        private System.Windows.Forms.PictureBox wynik;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox tbPrzezroczystoscValue;
    }
}

