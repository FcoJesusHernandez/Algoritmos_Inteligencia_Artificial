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
            this.bunifuFlatButtonEntrenarRegresionLogistica = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxLR = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorCmp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textoxEpocasMaximas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBoxEpocasMaximas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.buttonAdaline = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Competir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonPerceptron = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.plano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_cmp)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
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
            this.plano.Click += new System.EventHandler(this.plano_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
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
            this.label2.Size = new System.Drawing.Size(38, 22);
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
            this.labelCoordenadaXClick.Size = new System.Drawing.Size(0, 22);
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
            this.labelCoordenadaYClick.Size = new System.Drawing.Size(0, 22);
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
            this.labelAlerta.Size = new System.Drawing.Size(0, 24);
            this.labelAlerta.TabIndex = 18;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButtonEntrenarRegresionLogistica);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel2);
            this.bunifuGradientPanel1.Controls.Add(this.buttonAdaline);
            this.bunifuGradientPanel1.Controls.Add(this.buttonLimpiar);
            this.bunifuGradientPanel1.Controls.Add(this.Competir);
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.buttonPerceptron);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1283, 671);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // bunifuFlatButtonEntrenarRegresionLogistica
            // 
            this.bunifuFlatButtonEntrenarRegresionLogistica.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonEntrenarRegresionLogistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonEntrenarRegresionLogistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonEntrenarRegresionLogistica.BorderRadius = 0;
            this.bunifuFlatButtonEntrenarRegresionLogistica.ButtonText = "Entrenar Regresiòn Logistica";
            this.bunifuFlatButtonEntrenarRegresionLogistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonEntrenarRegresionLogistica.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Iconimage = null;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Iconimage_right = null;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Iconimage_right_Selected = null;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Iconimage_Selected = null;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconMarginLeft = 0;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconMarginRight = 0;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconRightVisible = true;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconRightZoom = 0D;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconVisible = true;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IconZoom = 90D;
            this.bunifuFlatButtonEntrenarRegresionLogistica.IsTab = false;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Location = new System.Drawing.Point(1038, 169);
            this.bunifuFlatButtonEntrenarRegresionLogistica.Name = "bunifuFlatButtonEntrenarRegresionLogistica";
            this.bunifuFlatButtonEntrenarRegresionLogistica.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButtonEntrenarRegresionLogistica.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButtonEntrenarRegresionLogistica.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonEntrenarRegresionLogistica.selected = false;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButtonEntrenarRegresionLogistica.TabIndex = 23;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Text = "Entrenar Regresiòn Logistica";
            this.bunifuFlatButtonEntrenarRegresionLogistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonEntrenarRegresionLogistica.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonEntrenarRegresionLogistica.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonEntrenarRegresionLogistica.Click += new System.EventHandler(this.bunifuFlatButtonEntrenarRegresionLogistica_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel2.Controls.Add(this.textBoxLR);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel2.Controls.Add(this.ErrorCmp);
            this.bunifuGradientPanel2.Controls.Add(this.textoxEpocasMaximas);
            this.bunifuGradientPanel2.Controls.Add(this.textBoxEpocasMaximas);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuiOSSwitch1);
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
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(364, 264);
            this.bunifuGradientPanel2.TabIndex = 22;
            this.bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 162);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(168, 25);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Regresión Logística";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Consolas", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(46, 75);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(126, 20);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Learning Rate";
            // 
            // textBoxLR
            // 
            this.textBoxLR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxLR.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxLR.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxLR.HintText = "";
            this.textBoxLR.isPassword = false;
            this.textBoxLR.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxLR.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxLR.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxLR.LineThickness = 3;
            this.textBoxLR.Location = new System.Drawing.Point(179, 62);
            this.textBoxLR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLR.Name = "textBoxLR";
            this.textBoxLR.Size = new System.Drawing.Size(151, 38);
            this.textBoxLR.TabIndex = 20;
            this.textBoxLR.Text = "0.1";
            this.textBoxLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Consolas", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(116, 121);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(54, 20);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Error";
            // 
            // ErrorCmp
            // 
            this.ErrorCmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ErrorCmp.ForeColor = System.Drawing.SystemColors.Control;
            this.ErrorCmp.HintForeColor = System.Drawing.Color.Empty;
            this.ErrorCmp.HintText = "";
            this.ErrorCmp.isPassword = false;
            this.ErrorCmp.LineFocusedColor = System.Drawing.Color.Blue;
            this.ErrorCmp.LineIdleColor = System.Drawing.Color.Gray;
            this.ErrorCmp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ErrorCmp.LineThickness = 3;
            this.ErrorCmp.Location = new System.Drawing.Point(179, 108);
            this.ErrorCmp.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorCmp.Name = "ErrorCmp";
            this.ErrorCmp.Size = new System.Drawing.Size(151, 38);
            this.ErrorCmp.TabIndex = 18;
            this.ErrorCmp.Text = "0.0005";
            this.ErrorCmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textoxEpocasMaximas
            // 
            this.textoxEpocasMaximas.AutoSize = true;
            this.textoxEpocasMaximas.Font = new System.Drawing.Font("Consolas", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoxEpocasMaximas.ForeColor = System.Drawing.SystemColors.Control;
            this.textoxEpocasMaximas.Location = new System.Drawing.Point(37, 31);
            this.textoxEpocasMaximas.Name = "textoxEpocasMaximas";
            this.textoxEpocasMaximas.Size = new System.Drawing.Size(135, 20);
            this.textoxEpocasMaximas.TabIndex = 17;
            this.textoxEpocasMaximas.Text = "Épocas Máximas";
            // 
            // textBoxEpocasMaximas
            // 
            this.textBoxEpocasMaximas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEpocasMaximas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxEpocasMaximas.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxEpocasMaximas.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxEpocasMaximas.HintText = "";
            this.textBoxEpocasMaximas.isPassword = false;
            this.textBoxEpocasMaximas.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBoxEpocasMaximas.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxEpocasMaximas.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBoxEpocasMaximas.LineThickness = 3;
            this.textBoxEpocasMaximas.Location = new System.Drawing.Point(179, 13);
            this.textBoxEpocasMaximas.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEpocasMaximas.Name = "textBoxEpocasMaximas";
            this.textBoxEpocasMaximas.Size = new System.Drawing.Size(151, 38);
            this.textBoxEpocasMaximas.TabIndex = 16;
            this.textBoxEpocasMaximas.Text = "200";
            this.textBoxEpocasMaximas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(287, 162);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 15;
            this.bunifuiOSSwitch1.Value = false;
            // 
            // buttonAdaline
            // 
            this.buttonAdaline.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdaline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdaline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdaline.BorderRadius = 0;
            this.buttonAdaline.ButtonText = "Entrenar Adaline";
            this.buttonAdaline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdaline.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdaline.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdaline.Iconimage = null;
            this.buttonAdaline.Iconimage_right = null;
            this.buttonAdaline.Iconimage_right_Selected = null;
            this.buttonAdaline.Iconimage_Selected = null;
            this.buttonAdaline.IconMarginLeft = 0;
            this.buttonAdaline.IconMarginRight = 0;
            this.buttonAdaline.IconRightVisible = true;
            this.buttonAdaline.IconRightZoom = 0D;
            this.buttonAdaline.IconVisible = true;
            this.buttonAdaline.IconZoom = 90D;
            this.buttonAdaline.IsTab = false;
            this.buttonAdaline.Location = new System.Drawing.Point(1039, 115);
            this.buttonAdaline.Name = "buttonAdaline";
            this.buttonAdaline.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonAdaline.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonAdaline.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdaline.selected = false;
            this.buttonAdaline.Size = new System.Drawing.Size(241, 48);
            this.buttonAdaline.TabIndex = 21;
            this.buttonAdaline.Text = "Entrenar Adaline";
            this.buttonAdaline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdaline.Textcolor = System.Drawing.Color.White;
            this.buttonAdaline.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaline.Click += new System.EventHandler(this.Adaline_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLimpiar.BorderRadius = 0;
            this.buttonLimpiar.ButtonText = "Limpiar";
            this.buttonLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLimpiar.Iconimage = null;
            this.buttonLimpiar.Iconimage_right = null;
            this.buttonLimpiar.Iconimage_right_Selected = null;
            this.buttonLimpiar.Iconimage_Selected = null;
            this.buttonLimpiar.IconMarginLeft = 0;
            this.buttonLimpiar.IconMarginRight = 0;
            this.buttonLimpiar.IconRightVisible = true;
            this.buttonLimpiar.IconRightZoom = 0D;
            this.buttonLimpiar.IconVisible = true;
            this.buttonLimpiar.IconZoom = 90D;
            this.buttonLimpiar.IsTab = false;
            this.buttonLimpiar.Location = new System.Drawing.Point(1038, 280);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonLimpiar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLimpiar.selected = false;
            this.buttonLimpiar.Size = new System.Drawing.Size(241, 48);
            this.buttonLimpiar.TabIndex = 20;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpiar.Textcolor = System.Drawing.Color.White;
            this.buttonLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Competir
            // 
            this.Competir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Competir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Competir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Competir.BorderRadius = 0;
            this.Competir.ButtonText = "Competir";
            this.Competir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Competir.DisabledColor = System.Drawing.Color.Gray;
            this.Competir.Iconcolor = System.Drawing.Color.Transparent;
            this.Competir.Iconimage = null;
            this.Competir.Iconimage_right = null;
            this.Competir.Iconimage_right_Selected = null;
            this.Competir.Iconimage_Selected = null;
            this.Competir.IconMarginLeft = 0;
            this.Competir.IconMarginRight = 0;
            this.Competir.IconRightVisible = true;
            this.Competir.IconRightZoom = 0D;
            this.Competir.IconVisible = true;
            this.Competir.IconZoom = 90D;
            this.Competir.IsTab = false;
            this.Competir.Location = new System.Drawing.Point(1038, 226);
            this.Competir.Name = "Competir";
            this.Competir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Competir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Competir.OnHoverTextColor = System.Drawing.Color.White;
            this.Competir.selected = false;
            this.Competir.Size = new System.Drawing.Size(241, 48);
            this.Competir.TabIndex = 19;
            this.Competir.Text = "Competir";
            this.Competir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Competir.Textcolor = System.Drawing.Color.White;
            this.Competir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Competir.Click += new System.EventHandler(this.Competir_Click);
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "Entrenar Perceptron";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = null;
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 90D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(1039, 61);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(241, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Entrenar Perceptron";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPerceptron
            // 
            this.buttonPerceptron.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPerceptron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPerceptron.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPerceptron.BorderRadius = 0;
            this.buttonPerceptron.ButtonText = "Inicializador";
            this.buttonPerceptron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPerceptron.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPerceptron.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPerceptron.Iconimage = null;
            this.buttonPerceptron.Iconimage_right = null;
            this.buttonPerceptron.Iconimage_right_Selected = null;
            this.buttonPerceptron.Iconimage_Selected = null;
            this.buttonPerceptron.IconMarginLeft = 0;
            this.buttonPerceptron.IconMarginRight = 0;
            this.buttonPerceptron.IconRightVisible = true;
            this.buttonPerceptron.IconRightZoom = 0D;
            this.buttonPerceptron.IconVisible = true;
            this.buttonPerceptron.IconZoom = 90D;
            this.buttonPerceptron.IsTab = false;
            this.buttonPerceptron.Location = new System.Drawing.Point(1039, 7);
            this.buttonPerceptron.Name = "buttonPerceptron";
            this.buttonPerceptron.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.buttonPerceptron.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.buttonPerceptron.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPerceptron.selected = false;
            this.buttonPerceptron.Size = new System.Drawing.Size(241, 48);
            this.buttonPerceptron.TabIndex = 6;
            this.buttonPerceptron.Text = "Inicializador";
            this.buttonPerceptron.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPerceptron.Textcolor = System.Drawing.Color.White;
            this.buttonPerceptron.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerceptron.Click += new System.EventHandler(this.buttonPerceptron_Click);
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
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuFlatButton buttonLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton Competir;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPerceptron;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdaline;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuCustomLabel textoxEpocasMaximas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEpocasMaximas;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxLR;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ErrorCmp;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonEntrenarRegresionLogistica;
    }
}

