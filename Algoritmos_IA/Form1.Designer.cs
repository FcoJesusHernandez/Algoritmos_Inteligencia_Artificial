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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plano = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCoordenadaXClick = new System.Windows.Forms.Label();
            this.labelCoordenadaYClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plano)).BeginInit();
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
            this.plano.Paint += new System.Windows.Forms.PaintEventHandler(this.plano_Paint);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 664);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoordenadaXClick;
        private System.Windows.Forms.Label labelCoordenadaYClick;
    }
}

