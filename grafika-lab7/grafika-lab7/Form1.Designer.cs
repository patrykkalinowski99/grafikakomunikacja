
namespace lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bWczytaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.obrazek1 = new System.Windows.Forms.PictureBox();
            this.obrazek2 = new System.Windows.Forms.PictureBox();
            this.bSkaluj = new System.Windows.Forms.Button();
            this.wykres1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wykres2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bHistogram = new System.Windows.Forms.Button();
            this.bUsredniajacy = new System.Windows.Forms.Button();
            this.bGauss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres2)).BeginInit();
            this.SuspendLayout();
            // 
            // bWczytaj
            // 
            this.bWczytaj.BackColor = System.Drawing.Color.Transparent;
            this.bWczytaj.Location = new System.Drawing.Point(12, 3);
            this.bWczytaj.Name = "bWczytaj";
            this.bWczytaj.Size = new System.Drawing.Size(706, 23);
            this.bWczytaj.TabIndex = 0;
            this.bWczytaj.Text = "Wczytaj";
            this.bWczytaj.UseVisualStyleBackColor = false;
            this.bWczytaj.Click += new System.EventHandler(this.bWczytaj_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // obrazek1
            // 
            this.obrazek1.Location = new System.Drawing.Point(12, 32);
            this.obrazek1.Name = "obrazek1";
            this.obrazek1.Size = new System.Drawing.Size(350, 300);
            this.obrazek1.TabIndex = 1;
            this.obrazek1.TabStop = false;
            // 
            // obrazek2
            // 
            this.obrazek2.Location = new System.Drawing.Point(12, 338);
            this.obrazek2.Name = "obrazek2";
            this.obrazek2.Size = new System.Drawing.Size(350, 300);
            this.obrazek2.TabIndex = 2;
            this.obrazek2.TabStop = false;
            // 
            // bSkaluj
            // 
            this.bSkaluj.BackColor = System.Drawing.Color.Transparent;
            this.bSkaluj.Location = new System.Drawing.Point(368, 644);
            this.bSkaluj.Name = "bSkaluj";
            this.bSkaluj.Size = new System.Drawing.Size(165, 23);
            this.bSkaluj.TabIndex = 4;
            this.bSkaluj.Text = "Skaluj";
            this.bSkaluj.UseVisualStyleBackColor = false;
            this.bSkaluj.Click += new System.EventHandler(this.bSkaluj_Click);
            // 
            // wykres1
            // 
            this.wykres1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wykres1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.Name = "ChartArea1";
            this.wykres1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.wykres1.Legends.Add(legend3);
            this.wykres1.Location = new System.Drawing.Point(368, 32);
            this.wykres1.Name = "wykres1";
            this.wykres1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "R";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series8.Color = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.Name = "G";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.Name = "B";
            this.wykres1.Series.Add(series7);
            this.wykres1.Series.Add(series8);
            this.wykres1.Series.Add(series9);
            this.wykres1.Size = new System.Drawing.Size(350, 300);
            this.wykres1.TabIndex = 5;
            this.wykres1.Text = "chart1";
            // 
            // wykres2
            // 
            this.wykres2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wykres2.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.Name = "ChartArea1";
            this.wykres2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.wykres2.Legends.Add(legend4);
            this.wykres2.Location = new System.Drawing.Point(368, 338);
            this.wykres2.Name = "wykres2";
            this.wykres2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "R";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "G";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.Name = "B";
            this.wykres2.Series.Add(series10);
            this.wykres2.Series.Add(series11);
            this.wykres2.Series.Add(series12);
            this.wykres2.Size = new System.Drawing.Size(350, 300);
            this.wykres2.TabIndex = 6;
            this.wykres2.Text = "chart2";
            // 
            // bHistogram
            // 
            this.bHistogram.BackColor = System.Drawing.Color.Transparent;
            this.bHistogram.Location = new System.Drawing.Point(12, 644);
            this.bHistogram.Name = "bHistogram";
            this.bHistogram.Size = new System.Drawing.Size(172, 23);
            this.bHistogram.TabIndex = 7;
            this.bHistogram.Text = "Histogram";
            this.bHistogram.UseVisualStyleBackColor = false;
            this.bHistogram.Click += new System.EventHandler(this.bHistogram_Click);
            // 
            // bUsredniajacy
            // 
            this.bUsredniajacy.BackColor = System.Drawing.Color.Transparent;
            this.bUsredniajacy.Location = new System.Drawing.Point(190, 644);
            this.bUsredniajacy.Name = "bUsredniajacy";
            this.bUsredniajacy.Size = new System.Drawing.Size(172, 23);
            this.bUsredniajacy.TabIndex = 8;
            this.bUsredniajacy.Text = "Filtr Uśredniający";
            this.bUsredniajacy.UseVisualStyleBackColor = false;
            this.bUsredniajacy.Click += new System.EventHandler(this.bUsredniajacy_Click);
            // 
            // bGauss
            // 
            this.bGauss.BackColor = System.Drawing.Color.Transparent;
            this.bGauss.Location = new System.Drawing.Point(539, 644);
            this.bGauss.Name = "bGauss";
            this.bGauss.Size = new System.Drawing.Size(179, 23);
            this.bGauss.TabIndex = 9;
            this.bGauss.Text = "Filtr Gaussa";
            this.bGauss.UseVisualStyleBackColor = false;
            this.bGauss.Click += new System.EventHandler(this.bGauss_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(724, 671);
            this.Controls.Add(this.bGauss);
            this.Controls.Add(this.bUsredniajacy);
            this.Controls.Add(this.bHistogram);
            this.Controls.Add(this.wykres2);
            this.Controls.Add(this.wykres1);
            this.Controls.Add(this.bSkaluj);
            this.Controls.Add(this.obrazek2);
            this.Controls.Add(this.obrazek1);
            this.Controls.Add(this.bWczytaj);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "Form1";
            this.Text = "Modyfikacja obrazu";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wykres2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bWczytaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox obrazek1;
        private System.Windows.Forms.PictureBox obrazek2;
        private System.Windows.Forms.Button bSkaluj;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykres1;
        private System.Windows.Forms.DataVisualization.Charting.Chart wykres2;
        private System.Windows.Forms.Button bHistogram;
        private System.Windows.Forms.Button bUsredniajacy;
        private System.Windows.Forms.Button bGauss;
    }
}

