
namespace grafika___lab8
{
    partial class Form1
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
            this.bWczytaj = new System.Windows.Forms.Button();
            this.pbZdjecie1 = new System.Windows.Forms.PictureBox();
            this.pbZdjecie2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bPionSobel = new System.Windows.Forms.Button();
            this.bPionPrewitt = new System.Windows.Forms.Button();
            this.bPionRoberts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bMediana = new System.Windows.Forms.Button();
            this.bMax = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bLaplace = new System.Windows.Forms.Button();
            this.bPoziomRoberts = new System.Windows.Forms.Button();
            this.bPoziomPrewitt = new System.Windows.Forms.Button();
            this.bPoziomSobel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie2)).BeginInit();
            this.SuspendLayout();
            // 
            // bWczytaj
            // 
            this.bWczytaj.BackColor = System.Drawing.Color.White;
            this.bWczytaj.Location = new System.Drawing.Point(12, 12);
            this.bWczytaj.Name = "bWczytaj";
            this.bWczytaj.Size = new System.Drawing.Size(348, 23);
            this.bWczytaj.TabIndex = 0;
            this.bWczytaj.Text = "Wczytaj zdjęcie";
            this.bWczytaj.UseVisualStyleBackColor = false;
            this.bWczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // pbZdjecie1
            // 
            this.pbZdjecie1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbZdjecie1.Location = new System.Drawing.Point(12, 41);
            this.pbZdjecie1.Name = "pbZdjecie1";
            this.pbZdjecie1.Size = new System.Drawing.Size(348, 360);
            this.pbZdjecie1.TabIndex = 2;
            this.pbZdjecie1.TabStop = false;
            // 
            // pbZdjecie2
            // 
            this.pbZdjecie2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pbZdjecie2.Location = new System.Drawing.Point(366, 41);
            this.pbZdjecie2.Name = "pbZdjecie2";
            this.pbZdjecie2.Size = new System.Drawing.Size(348, 360);
            this.pbZdjecie2.TabIndex = 3;
            this.pbZdjecie2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bPionSobel
            // 
            this.bPionSobel.BackColor = System.Drawing.Color.White;
            this.bPionSobel.Location = new System.Drawing.Point(12, 425);
            this.bPionSobel.Name = "bPionSobel";
            this.bPionSobel.Size = new System.Drawing.Size(116, 23);
            this.bPionSobel.TabIndex = 3;
            this.bPionSobel.Text = "Sobel";
            this.bPionSobel.UseVisualStyleBackColor = false;
            this.bPionSobel.Click += new System.EventHandler(this.pionSobel_Click);
            // 
            // bPionPrewitt
            // 
            this.bPionPrewitt.BackColor = System.Drawing.Color.White;
            this.bPionPrewitt.Location = new System.Drawing.Point(244, 425);
            this.bPionPrewitt.Name = "bPionPrewitt";
            this.bPionPrewitt.Size = new System.Drawing.Size(116, 23);
            this.bPionPrewitt.TabIndex = 2;
            this.bPionPrewitt.Text = "Prewitt";
            this.bPionPrewitt.UseVisualStyleBackColor = false;
            this.bPionPrewitt.Click += new System.EventHandler(this.pionPrewitt_Click);
            // 
            // bPionRoberts
            // 
            this.bPionRoberts.BackColor = System.Drawing.Color.White;
            this.bPionRoberts.Location = new System.Drawing.Point(128, 425);
            this.bPionRoberts.Name = "bPionRoberts";
            this.bPionRoberts.Size = new System.Drawing.Size(116, 23);
            this.bPionRoberts.TabIndex = 1;
            this.bPionRoberts.Text = "Roberts";
            this.bPionRoberts.UseVisualStyleBackColor = false;
            this.bPionRoberts.Click += new System.EventHandler(this.pionRoberts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pionowe";
            // 
            // bMediana
            // 
            this.bMediana.BackColor = System.Drawing.Color.White;
            this.bMediana.Location = new System.Drawing.Point(627, 12);
            this.bMediana.Name = "bMediana";
            this.bMediana.Size = new System.Drawing.Size(87, 23);
            this.bMediana.TabIndex = 3;
            this.bMediana.Text = "Medianowy";
            this.bMediana.UseVisualStyleBackColor = false;
            this.bMediana.Click += new System.EventHandler(this.mediana_Click);
            // 
            // bMax
            // 
            this.bMax.BackColor = System.Drawing.Color.White;
            this.bMax.Location = new System.Drawing.Point(366, 12);
            this.bMax.Name = "bMax";
            this.bMax.Size = new System.Drawing.Size(87, 23);
            this.bMax.TabIndex = 2;
            this.bMax.Text = "Maksimum";
            this.bMax.UseVisualStyleBackColor = false;
            this.bMax.Click += new System.EventHandler(this.max_Click);
            // 
            // bMin
            // 
            this.bMin.BackColor = System.Drawing.Color.White;
            this.bMin.Location = new System.Drawing.Point(453, 12);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(87, 23);
            this.bMin.TabIndex = 1;
            this.bMin.Text = "Minimum";
            this.bMin.UseVisualStyleBackColor = false;
            this.bMin.Click += new System.EventHandler(this.min_Click);
            // 
            // bLaplace
            // 
            this.bLaplace.BackColor = System.Drawing.Color.White;
            this.bLaplace.Location = new System.Drawing.Point(540, 12);
            this.bLaplace.Name = "bLaplace";
            this.bLaplace.Size = new System.Drawing.Size(87, 23);
            this.bLaplace.TabIndex = 0;
            this.bLaplace.Text = "Laplace";
            this.bLaplace.UseVisualStyleBackColor = false;
            this.bLaplace.Click += new System.EventHandler(this.laplacea_Click);
            // 
            // bPoziomRoberts
            // 
            this.bPoziomRoberts.BackColor = System.Drawing.Color.White;
            this.bPoziomRoberts.Location = new System.Drawing.Point(482, 425);
            this.bPoziomRoberts.Name = "bPoziomRoberts";
            this.bPoziomRoberts.Size = new System.Drawing.Size(116, 23);
            this.bPoziomRoberts.TabIndex = 0;
            this.bPoziomRoberts.Text = "Roberts";
            this.bPoziomRoberts.UseVisualStyleBackColor = false;
            this.bPoziomRoberts.Click += new System.EventHandler(this.pozRoberts_Click);
            // 
            // bPoziomPrewitt
            // 
            this.bPoziomPrewitt.BackColor = System.Drawing.Color.White;
            this.bPoziomPrewitt.Location = new System.Drawing.Point(598, 425);
            this.bPoziomPrewitt.Name = "bPoziomPrewitt";
            this.bPoziomPrewitt.Size = new System.Drawing.Size(116, 23);
            this.bPoziomPrewitt.TabIndex = 1;
            this.bPoziomPrewitt.Text = "Prewitt";
            this.bPoziomPrewitt.UseVisualStyleBackColor = false;
            this.bPoziomPrewitt.Click += new System.EventHandler(this.pozPrewitt_Click);
            // 
            // bPoziomSobel
            // 
            this.bPoziomSobel.BackColor = System.Drawing.Color.White;
            this.bPoziomSobel.Location = new System.Drawing.Point(366, 425);
            this.bPoziomSobel.Name = "bPoziomSobel";
            this.bPoziomSobel.Size = new System.Drawing.Size(116, 23);
            this.bPoziomSobel.TabIndex = 2;
            this.bPoziomSobel.Text = "Sobel";
            this.bPoziomSobel.UseVisualStyleBackColor = false;
            this.bPoziomSobel.Click += new System.EventHandler(this.pozSobel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(504, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Poziome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 454);
            this.Controls.Add(this.bPoziomRoberts);
            this.Controls.Add(this.bPoziomSobel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPoziomPrewitt);
            this.Controls.Add(this.bPionPrewitt);
            this.Controls.Add(this.bPionSobel);
            this.Controls.Add(this.bPionRoberts);
            this.Controls.Add(this.bMediana);
            this.Controls.Add(this.bMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bLaplace);
            this.Controls.Add(this.pbZdjecie2);
            this.Controls.Add(this.pbZdjecie1);
            this.Controls.Add(this.bWczytaj);
            this.MaximumSize = new System.Drawing.Size(738, 493);
            this.MinimumSize = new System.Drawing.Size(738, 493);
            this.Name = "Form1";
            this.Text = "Modyfikacja obrazu w oparciu o filtry";
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZdjecie2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bWczytaj;
        private System.Windows.Forms.PictureBox pbZdjecie1;
        private System.Windows.Forms.PictureBox pbZdjecie2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button bPionSobel;
        private System.Windows.Forms.Button bPionPrewitt;
        private System.Windows.Forms.Button bPionRoberts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bMediana;
        private System.Windows.Forms.Button bMax;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bLaplace;
        private System.Windows.Forms.Button bPoziomRoberts;
        private System.Windows.Forms.Button bPoziomPrewitt;
        private System.Windows.Forms.Button bPoziomSobel;
        private System.Windows.Forms.Label label1;
    }
}

