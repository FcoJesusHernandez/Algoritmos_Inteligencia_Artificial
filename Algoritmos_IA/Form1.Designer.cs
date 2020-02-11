namespace Algoritmos_IA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plano = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCoordenadaXClick = new System.Windows.Forms.Label();
            this.labelCoordenadaYClick = new System.Windows.Forms.Label();
            this.buttonPerceptron = new System.Windows.Forms.Button();
            this.textBoxLR = new System.Windows.Forms.TextBox();
            this.textBoxEpocasMaximas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEpocasMaximas = new System.Windows.Forms.Label();
            this.Error_cmp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.Adaline = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorCmp = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.plano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_cmp)).BeginInit();
            this.SuspendLayout();
            // 
            // plano
            // 
            this.plano.BackColor = System.Drawing.Color.White;
            this.plano.Location = new System.Drawing.Point(13, 13);
            this.plano.Name = "plano";
            this.plano.Size = new System.Drawing.Size(600, 600);
            this.plano.TabIndex = 0;
            this.plano.TabStop = false;
            this.plano.Click += new System.EventHandler(this.plano_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y : ";
            // 
            // labelCoordenadaXClick
            // 
            this.labelCoordenadaXClick.AutoSize = true;
            this.labelCoordenadaXClick.Location = new System.Drawing.Point(29, 617);
            this.labelCoordenadaXClick.Name = "labelCoordenadaXClick";
            this.labelCoordenadaXClick.Size = new System.Drawing.Size(0, 13);
            this.labelCoordenadaXClick.TabIndex = 3;
            // 
            // labelCoordenadaYClick
            // 
            this.labelCoordenadaYClick.AutoSize = true;
            this.labelCoordenadaYClick.Location = new System.Drawing.Point(29, 630);
            this.labelCoordenadaYClick.Name = "labelCoordenadaYClick";
            this.labelCoordenadaYClick.Size = new System.Drawing.Size(21, 13);
            this.labelCoordenadaYClick.TabIndex = 4;
            this.labelCoordenadaYClick.Text = "y : ";
            // 
            // buttonPerceptron
            // 
            this.buttonPerceptron.Location = new System.Drawing.Point(633, 114);
            this.buttonPerceptron.Name = "buttonPerceptron";
            this.buttonPerceptron.Size = new System.Drawing.Size(147, 34);
            this.buttonPerceptron.TabIndex = 5;
            this.buttonPerceptron.Text = "Inicializador";
            this.buttonPerceptron.UseVisualStyleBackColor = true;
            this.buttonPerceptron.Click += new System.EventHandler(this.buttonPerceptron_Click);
            // 
            // textBoxLR
            // 
            this.textBoxLR.Location = new System.Drawing.Point(723, 35);
            this.textBoxLR.Name = "textBoxLR";
            this.textBoxLR.Size = new System.Drawing.Size(100, 20);
            this.textBoxLR.TabIndex = 6;
            this.textBoxLR.Text = "0.5";
            // 
            // textBoxEpocasMaximas
            // 
            this.textBoxEpocasMaximas.Location = new System.Drawing.Point(723, 76);
            this.textBoxEpocasMaximas.Name = "textBoxEpocasMaximas";
            this.textBoxEpocasMaximas.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpocasMaximas.TabIndex = 7;
            this.textBoxEpocasMaximas.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LR";
            // 
            // labelEpocasMaximas
            // 
            this.labelEpocasMaximas.AutoSize = true;
            this.labelEpocasMaximas.Location = new System.Drawing.Point(630, 79);
            this.labelEpocasMaximas.Name = "labelEpocasMaximas";
            this.labelEpocasMaximas.Size = new System.Drawing.Size(87, 13);
            this.labelEpocasMaximas.TabIndex = 9;
            this.labelEpocasMaximas.Text = "Epocas Maximas";
            // 
            // Error_cmp
            // 
            chartArea1.Name = "ChartArea1";
            this.Error_cmp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Algoritmos";
            this.Error_cmp.Legends.Add(legend1);
            this.Error_cmp.Location = new System.Drawing.Point(633, 313);
            this.Error_cmp.Name = "Error_cmp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Perceptron";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Adaline";
            this.Error_cmp.Series.Add(series1);
            this.Error_cmp.Series.Add(series2);
            this.Error_cmp.Size = new System.Drawing.Size(600, 300);
            this.Error_cmp.TabIndex = 10;
            this.Error_cmp.Text = "Error";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Error por época";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Title2";
            title2.Text = "Error acumulado";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Title3";
            title3.Text = "Época";
            this.Error_cmp.Titles.Add(title1);
            this.Error_cmp.Titles.Add(title2);
            this.Error_cmp.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Entrenar Perceptron";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adaline
            // 
            this.Adaline.Location = new System.Drawing.Point(939, 114);
            this.Adaline.Name = "Adaline";
            this.Adaline.Size = new System.Drawing.Size(147, 34);
            this.Adaline.TabIndex = 12;
            this.Adaline.Text = "Entrenar Adaline";
            this.Adaline.UseVisualStyleBackColor = true;
            this.Adaline.Click += new System.EventHandler(this.Adaline_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Error";
            // 
            // ErrorCmp
            // 
            this.ErrorCmp.Location = new System.Drawing.Point(870, 35);
            this.ErrorCmp.Name = "ErrorCmp";
            this.ErrorCmp.Size = new System.Drawing.Size(100, 20);
            this.ErrorCmp.TabIndex = 14;
            this.ErrorCmp.Text = "0.5";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(633, 222);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 664);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ErrorCmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adaline);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Error_cmp);
            this.Controls.Add(this.labelEpocasMaximas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEpocasMaximas);
            this.Controls.Add(this.textBoxLR);
            this.Controls.Add(this.buttonPerceptron);
            this.Controls.Add(this.labelCoordenadaYClick);
            this.Controls.Add(this.labelCoordenadaXClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Algoritmos Inteligencia Artificial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_cmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoordenadaXClick;
        private System.Windows.Forms.Label labelCoordenadaYClick;
        private System.Windows.Forms.Button buttonPerceptron;
        private System.Windows.Forms.TextBox textBoxLR;
        private System.Windows.Forms.TextBox textBoxEpocasMaximas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelEpocasMaximas;
        private System.Windows.Forms.DataVisualization.Charting.Chart Error_cmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Adaline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrorCmp;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

