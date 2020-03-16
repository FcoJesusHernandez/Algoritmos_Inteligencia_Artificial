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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plano = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCoordenadaXClick = new System.Windows.Forms.Label();
            this.labelCoordenadaYClick = new System.Windows.Forms.Label();
            this.Error_cmp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAlerta = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.RegresionLogisticaSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AdalineSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.InicializarBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.LimpiarBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.PerceptronSwitch = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CompetirBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.NextBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.NeuronaPcTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NeuronaPcLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ClasesTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ClaseSelected = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ClasesLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LearningRateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LearningRateTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ErrorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textoxEpocasMaximas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EpocasMaximasTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.plano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_cmp)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InicializarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompetirBtn)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // plano
            // 
            this.plano.BackColor = System.Drawing.Color.White;
            this.plano.Location = new System.Drawing.Point(41, 40);
            this.plano.Name = "plano";
            this.plano.Size = new System.Drawing.Size(600, 600);
            this.plano.TabIndex = 0;
            this.plano.TabStop = false;
            this.plano.Click += new System.EventHandler(this.Plano_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "x : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "y : ";
            // 
            // labelCoordenadaXClick
            // 
            this.labelCoordenadaXClick.AutoSize = true;
            this.labelCoordenadaXClick.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaXClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordenadaXClick.ForeColor = System.Drawing.Color.White;
            this.labelCoordenadaXClick.Location = new System.Drawing.Point(57, 219);
            this.labelCoordenadaXClick.Name = "labelCoordenadaXClick";
            this.labelCoordenadaXClick.Size = new System.Drawing.Size(0, 18);
            this.labelCoordenadaXClick.TabIndex = 3;
            // 
            // labelCoordenadaYClick
            // 
            this.labelCoordenadaYClick.AutoSize = true;
            this.labelCoordenadaYClick.BackColor = System.Drawing.Color.Transparent;
            this.labelCoordenadaYClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordenadaYClick.ForeColor = System.Drawing.Color.White;
            this.labelCoordenadaYClick.Location = new System.Drawing.Point(57, 240);
            this.labelCoordenadaYClick.Name = "labelCoordenadaYClick";
            this.labelCoordenadaYClick.Size = new System.Drawing.Size(0, 18);
            this.labelCoordenadaYClick.TabIndex = 4;
            // 
            // Error_cmp
            // 
            this.Error_cmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.Error_cmp.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Algoritmos";
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.Error_cmp.Legends.Add(legend1);
            this.Error_cmp.Location = new System.Drawing.Point(668, 340);
            this.Error_cmp.Name = "Error_cmp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Perceptron";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Adaline";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Regresión logistica";
            this.Error_cmp.Series.Add(series1);
            this.Error_cmp.Series.Add(series2);
            this.Error_cmp.Series.Add(series3);
            this.Error_cmp.Size = new System.Drawing.Size(600, 300);
            this.Error_cmp.TabIndex = 10;
            this.Error_cmp.Text = "Error";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Error por época";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title2";
            title2.Text = "Error acumulado";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title3";
            title3.Text = "Época";
            this.Error_cmp.Titles.Add(title1);
            this.Error_cmp.Titles.Add(title2);
            this.Error_cmp.Titles.Add(title3);
            // 
            // labelAlerta
            // 
            this.labelAlerta.AutoSize = true;
            this.labelAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlerta.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelAlerta.Location = new System.Drawing.Point(187, 617);
            this.labelAlerta.Name = "labelAlerta";
            this.labelAlerta.Size = new System.Drawing.Size(0, 20);
            this.labelAlerta.TabIndex = 18;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.plano);
            this.bunifuGradientPanel1.Controls.Add(this.Error_cmp);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -3);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1315, 713);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.bunifuSeparator2);
            this.bunifuGradientPanel3.Controls.Add(this.RegresionLogisticaSwitch);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel3.Controls.Add(this.AdalineSwitch);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel3.Controls.Add(this.InicializarBtn);
            this.bunifuGradientPanel3.Controls.Add(this.LimpiarBtn);
            this.bunifuGradientPanel3.Controls.Add(this.PerceptronSwitch);
            this.bunifuGradientPanel3.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel3.Controls.Add(this.CompetirBtn);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(1039, 40);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 15;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(229, 284);
            this.bunifuGradientPanel3.TabIndex = 24;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 177);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(204, 21);
            this.bunifuSeparator2.TabIndex = 30;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // RegresionLogisticaSwitch
            // 
            this.RegresionLogisticaSwitch.BackColor = System.Drawing.Color.Transparent;
            this.RegresionLogisticaSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegresionLogisticaSwitch.BackgroundImage")));
            this.RegresionLogisticaSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegresionLogisticaSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegresionLogisticaSwitch.Location = new System.Drawing.Point(172, 149);
            this.RegresionLogisticaSwitch.Name = "RegresionLogisticaSwitch";
            this.RegresionLogisticaSwitch.OffColor = System.Drawing.Color.DarkRed;
            this.RegresionLogisticaSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.RegresionLogisticaSwitch.Size = new System.Drawing.Size(43, 25);
            this.RegresionLogisticaSwitch.TabIndex = 28;
            this.RegresionLogisticaSwitch.Value = false;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(13, 152);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(153, 22);
            this.bunifuCustomLabel5.TabIndex = 29;
            this.bunifuCustomLabel5.Text = "Regresión Logística";
            // 
            // AdalineSwitch
            // 
            this.AdalineSwitch.BackColor = System.Drawing.Color.Transparent;
            this.AdalineSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdalineSwitch.BackgroundImage")));
            this.AdalineSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdalineSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdalineSwitch.Location = new System.Drawing.Point(172, 118);
            this.AdalineSwitch.Name = "AdalineSwitch";
            this.AdalineSwitch.OffColor = System.Drawing.Color.DarkRed;
            this.AdalineSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.AdalineSwitch.Size = new System.Drawing.Size(43, 25);
            this.AdalineSwitch.TabIndex = 26;
            this.AdalineSwitch.Value = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(100, 121);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 22);
            this.bunifuCustomLabel4.TabIndex = 27;
            this.bunifuCustomLabel4.Text = "Adaline";
            // 
            // InicializarBtn
            // 
            this.InicializarBtn.BackColor = System.Drawing.Color.Transparent;
            this.InicializarBtn.Image = ((System.Drawing.Image)(resources.GetObject("InicializarBtn.Image")));
            this.InicializarBtn.ImageActive = null;
            this.InicializarBtn.Location = new System.Drawing.Point(21, 13);
            this.InicializarBtn.Name = "InicializarBtn";
            this.InicializarBtn.Size = new System.Drawing.Size(50, 50);
            this.InicializarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InicializarBtn.TabIndex = 23;
            this.InicializarBtn.TabStop = false;
            this.InicializarBtn.Zoom = 10;
            this.InicializarBtn.Click += new System.EventHandler(this.InicializarBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.BackColor = System.Drawing.Color.Transparent;
            this.LimpiarBtn.Image = ((System.Drawing.Image)(resources.GetObject("LimpiarBtn.Image")));
            this.LimpiarBtn.ImageActive = null;
            this.LimpiarBtn.Location = new System.Drawing.Point(165, 13);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(50, 50);
            this.LimpiarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LimpiarBtn.TabIndex = 25;
            this.LimpiarBtn.TabStop = false;
            this.LimpiarBtn.Zoom = 10;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // PerceptronSwitch
            // 
            this.PerceptronSwitch.BackColor = System.Drawing.Color.Transparent;
            this.PerceptronSwitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PerceptronSwitch.BackgroundImage")));
            this.PerceptronSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PerceptronSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PerceptronSwitch.Location = new System.Drawing.Point(172, 87);
            this.PerceptronSwitch.Name = "PerceptronSwitch";
            this.PerceptronSwitch.OffColor = System.Drawing.Color.DarkRed;
            this.PerceptronSwitch.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.PerceptronSwitch.Size = new System.Drawing.Size(43, 25);
            this.PerceptronSwitch.TabIndex = 15;
            this.PerceptronSwitch.Value = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(77, 90);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(89, 22);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Perceptrón";
            // 
            // CompetirBtn
            // 
            this.CompetirBtn.BackColor = System.Drawing.Color.Transparent;
            this.CompetirBtn.Image = ((System.Drawing.Image)(resources.GetObject("CompetirBtn.Image")));
            this.CompetirBtn.ImageActive = null;
            this.CompetirBtn.Location = new System.Drawing.Point(94, 13);
            this.CompetirBtn.Name = "CompetirBtn";
            this.CompetirBtn.Size = new System.Drawing.Size(50, 50);
            this.CompetirBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompetirBtn.TabIndex = 24;
            this.CompetirBtn.TabStop = false;
            this.CompetirBtn.Zoom = 10;
            this.CompetirBtn.Click += new System.EventHandler(this.CompetirBtn_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.NextBtn);
            this.bunifuGradientPanel2.Controls.Add(this.NeuronaPcTb);
            this.bunifuGradientPanel2.Controls.Add(this.NeuronaPcLabel);
            this.bunifuGradientPanel2.Controls.Add(this.ClasesTb);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel7);
            this.bunifuGradientPanel2.Controls.Add(this.ClaseSelected);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel2.Controls.Add(this.ClasesLabel);
            this.bunifuGradientPanel2.Controls.Add(this.LearningRateLabel);
            this.bunifuGradientPanel2.Controls.Add(this.LearningRateTb);
            this.bunifuGradientPanel2.Controls.Add(this.ErrorLabel);
            this.bunifuGradientPanel2.Controls.Add(this.ErrorTb);
            this.bunifuGradientPanel2.Controls.Add(this.textoxEpocasMaximas);
            this.bunifuGradientPanel2.Controls.Add(this.EpocasMaximasTb);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Controls.Add(this.labelCoordenadaYClick);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.Controls.Add(this.labelCoordenadaXClick);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(668, 40);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(364, 284);
            this.bunifuGradientPanel2.TabIndex = 22;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Transparent;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.ImageActive = null;
            this.NextBtn.Location = new System.Drawing.Point(322, 211);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(25, 25);
            this.NextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NextBtn.TabIndex = 30;
            this.NextBtn.TabStop = false;
            this.NextBtn.Zoom = 10;
            // 
            // NeuronaPcTb
            // 
            this.NeuronaPcTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NeuronaPcTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NeuronaPcTb.ForeColor = System.Drawing.SystemColors.Control;
            this.NeuronaPcTb.HintForeColor = System.Drawing.Color.Empty;
            this.NeuronaPcTb.HintText = "";
            this.NeuronaPcTb.isPassword = false;
            this.NeuronaPcTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.NeuronaPcTb.LineIdleColor = System.Drawing.Color.Gray;
            this.NeuronaPcTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NeuronaPcTb.LineThickness = 3;
            this.NeuronaPcTb.Location = new System.Drawing.Point(277, 177);
            this.NeuronaPcTb.Margin = new System.Windows.Forms.Padding(4);
            this.NeuronaPcTb.Name = "NeuronaPcTb";
            this.NeuronaPcTb.Size = new System.Drawing.Size(70, 27);
            this.NeuronaPcTb.TabIndex = 29;
            this.NeuronaPcTb.Text = "1";
            this.NeuronaPcTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NeuronaPcLabel
            // 
            this.NeuronaPcLabel.AutoSize = true;
            this.NeuronaPcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NeuronaPcLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NeuronaPcLabel.Location = new System.Drawing.Point(166, 180);
            this.NeuronaPcLabel.Name = "NeuronaPcLabel";
            this.NeuronaPcLabel.Size = new System.Drawing.Size(104, 18);
            this.NeuronaPcLabel.TabIndex = 28;
            this.NeuronaPcLabel.Text = "Neuronas/pc";
            // 
            // ClasesTb
            // 
            this.ClasesTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClasesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ClasesTb.ForeColor = System.Drawing.SystemColors.Control;
            this.ClasesTb.HintForeColor = System.Drawing.Color.Empty;
            this.ClasesTb.HintText = "";
            this.ClasesTb.isPassword = false;
            this.ClasesTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ClasesTb.LineIdleColor = System.Drawing.Color.Gray;
            this.ClasesTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ClasesTb.LineThickness = 3;
            this.ClasesTb.Location = new System.Drawing.Point(277, 142);
            this.ClasesTb.Margin = new System.Windows.Forms.Padding(4);
            this.ClasesTb.Name = "ClasesTb";
            this.ClasesTb.Size = new System.Drawing.Size(70, 27);
            this.ClasesTb.TabIndex = 27;
            this.ClasesTb.Text = "2";
            this.ClasesTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(10, 147);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(102, 18);
            this.bunifuCustomLabel7.TabIndex = 26;
            this.bunifuCustomLabel7.Text = "Clase Actual";
            // 
            // ClaseSelected
            // 
            this.ClaseSelected.BackColor = System.Drawing.Color.Transparent;
            this.ClaseSelected.BorderRadius = 3;
            this.ClaseSelected.ForeColor = System.Drawing.Color.White;
            this.ClaseSelected.Items = new string[0];
            this.ClaseSelected.Location = new System.Drawing.Point(118, 147);
            this.ClaseSelected.Name = "ClaseSelected";
            this.ClaseSelected.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ClaseSelected.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ClaseSelected.selectedIndex = -1;
            this.ClaseSelected.Size = new System.Drawing.Size(70, 18);
            this.ClaseSelected.TabIndex = 25;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 123);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(334, 21);
            this.bunifuSeparator1.TabIndex = 24;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // ClasesLabel
            // 
            this.ClasesLabel.AutoSize = true;
            this.ClasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClasesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ClasesLabel.Location = new System.Drawing.Point(210, 147);
            this.ClasesLabel.Name = "ClasesLabel";
            this.ClasesLabel.Size = new System.Drawing.Size(60, 18);
            this.ClasesLabel.TabIndex = 23;
            this.ClasesLabel.Text = "Clases";
            // 
            // LearningRateLabel
            // 
            this.LearningRateLabel.AutoSize = true;
            this.LearningRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningRateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LearningRateLabel.Location = new System.Drawing.Point(158, 65);
            this.LearningRateLabel.Name = "LearningRateLabel";
            this.LearningRateLabel.Size = new System.Drawing.Size(112, 18);
            this.LearningRateLabel.TabIndex = 21;
            this.LearningRateLabel.Text = "Learning Rate";
            // 
            // LearningRateTb
            // 
            this.LearningRateTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LearningRateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LearningRateTb.ForeColor = System.Drawing.SystemColors.Control;
            this.LearningRateTb.HintForeColor = System.Drawing.Color.Empty;
            this.LearningRateTb.HintText = "";
            this.LearningRateTb.isPassword = false;
            this.LearningRateTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.LearningRateTb.LineIdleColor = System.Drawing.Color.Gray;
            this.LearningRateTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.LearningRateTb.LineThickness = 3;
            this.LearningRateTb.Location = new System.Drawing.Point(277, 59);
            this.LearningRateTb.Margin = new System.Windows.Forms.Padding(4);
            this.LearningRateTb.Name = "LearningRateTb";
            this.LearningRateTb.Size = new System.Drawing.Size(70, 24);
            this.LearningRateTb.TabIndex = 20;
            this.LearningRateTb.Text = "0.1";
            this.LearningRateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ErrorLabel.Location = new System.Drawing.Point(223, 98);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(47, 18);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "Error";
            // 
            // ErrorTb
            // 
            this.ErrorTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ErrorTb.ForeColor = System.Drawing.SystemColors.Control;
            this.ErrorTb.HintForeColor = System.Drawing.Color.Empty;
            this.ErrorTb.HintText = "";
            this.ErrorTb.isPassword = false;
            this.ErrorTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.ErrorTb.LineIdleColor = System.Drawing.Color.Gray;
            this.ErrorTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ErrorTb.LineThickness = 3;
            this.ErrorTb.Location = new System.Drawing.Point(277, 91);
            this.ErrorTb.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorTb.Name = "ErrorTb";
            this.ErrorTb.Size = new System.Drawing.Size(70, 25);
            this.ErrorTb.TabIndex = 18;
            this.ErrorTb.Text = "0.0005";
            this.ErrorTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoxEpocasMaximas
            // 
            this.textoxEpocasMaximas.AutoSize = true;
            this.textoxEpocasMaximas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoxEpocasMaximas.ForeColor = System.Drawing.SystemColors.Control;
            this.textoxEpocasMaximas.Location = new System.Drawing.Point(133, 33);
            this.textoxEpocasMaximas.Name = "textoxEpocasMaximas";
            this.textoxEpocasMaximas.Size = new System.Drawing.Size(137, 18);
            this.textoxEpocasMaximas.TabIndex = 17;
            this.textoxEpocasMaximas.Text = "Épocas máximas";
            // 
            // EpocasMaximasTb
            // 
            this.EpocasMaximasTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EpocasMaximasTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EpocasMaximasTb.ForeColor = System.Drawing.SystemColors.Control;
            this.EpocasMaximasTb.HintForeColor = System.Drawing.Color.Empty;
            this.EpocasMaximasTb.HintText = "";
            this.EpocasMaximasTb.isPassword = false;
            this.EpocasMaximasTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.EpocasMaximasTb.LineIdleColor = System.Drawing.Color.Gray;
            this.EpocasMaximasTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.EpocasMaximasTb.LineThickness = 3;
            this.EpocasMaximasTb.Location = new System.Drawing.Point(277, 24);
            this.EpocasMaximasTb.Margin = new System.Windows.Forms.Padding(4);
            this.EpocasMaximasTb.Name = "EpocasMaximasTb";
            this.EpocasMaximasTb.Size = new System.Drawing.Size(70, 27);
            this.EpocasMaximasTb.TabIndex = 16;
            this.EpocasMaximasTb.Text = "200";
            this.EpocasMaximasTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 711);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.labelAlerta);
            this.Name = "Form1";
            this.Text = "Algoritmos Inteligencia Artificial";
            ((System.ComponentModel.ISupportInitialize)(this.plano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_cmp)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InicializarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimpiarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompetirBtn)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoordenadaXClick;
        private System.Windows.Forms.Label labelCoordenadaYClick;
        private System.Windows.Forms.DataVisualization.Charting.Chart Error_cmp;
        private System.Windows.Forms.Label labelAlerta;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuiOSSwitch PerceptronSwitch;
        private Bunifu.Framework.UI.BunifuCustomLabel textoxEpocasMaximas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EpocasMaximasTb;
        private Bunifu.Framework.UI.BunifuCustomLabel LearningRateLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LearningRateTb;
        private Bunifu.Framework.UI.BunifuCustomLabel ErrorLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ErrorTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton LimpiarBtn;
        private Bunifu.Framework.UI.BunifuImageButton CompetirBtn;
        private Bunifu.Framework.UI.BunifuImageButton InicializarBtn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Bunifu.Framework.UI.BunifuiOSSwitch RegresionLogisticaSwitch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuiOSSwitch AdalineSwitch;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ClasesTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDropdown ClaseSelected;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel ClasesLabel;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton NextBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NeuronaPcTb;
        private Bunifu.Framework.UI.BunifuCustomLabel NeuronaPcLabel;
    }
}

