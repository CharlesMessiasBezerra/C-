namespace PDI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PcbImagem = new System.Windows.Forms.PictureBox();
            this.btnAbrirImagem = new System.Windows.Forms.Button();
            this.GpbImagem = new System.Windows.Forms.GroupBox();
            this.lblPY = new System.Windows.Forms.Label();
            this.lblPX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CtHist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEqualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GbFuncoes = new System.Windows.Forms.GroupBox();
            this.btnOriginal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).BeginInit();
            this.GpbImagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcbImagem
            // 
            this.PcbImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbImagem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PcbImagem.InitialImage = ((System.Drawing.Image)(resources.GetObject("PcbImagem.InitialImage")));
            this.PcbImagem.Location = new System.Drawing.Point(15, 19);
            this.PcbImagem.Name = "PcbImagem";
            this.PcbImagem.Size = new System.Drawing.Size(389, 450);
            this.PcbImagem.TabIndex = 0;
            this.PcbImagem.TabStop = false;
            this.PcbImagem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbImagem_MouseMove);
            // 
            // btnAbrirImagem
            // 
            this.btnAbrirImagem.Location = new System.Drawing.Point(10, 19);
            this.btnAbrirImagem.Name = "btnAbrirImagem";
            this.btnAbrirImagem.Size = new System.Drawing.Size(144, 23);
            this.btnAbrirImagem.TabIndex = 1;
            this.btnAbrirImagem.Text = "Carregar Imagem";
            this.btnAbrirImagem.UseVisualStyleBackColor = true;
            this.btnAbrirImagem.Click += new System.EventHandler(this.btnAbrirImagem_Click);
            // 
            // GpbImagem
            // 
            this.GpbImagem.AutoSize = true;
            this.GpbImagem.Controls.Add(this.PcbImagem);
            this.GpbImagem.Location = new System.Drawing.Point(0, 21);
            this.GpbImagem.Name = "GpbImagem";
            this.GpbImagem.Size = new System.Drawing.Size(420, 485);
            this.GpbImagem.TabIndex = 2;
            this.GpbImagem.TabStop = false;
            this.GpbImagem.Text = "Imagem";
            // 
            // lblPY
            // 
            this.lblPY.AutoSize = true;
            this.lblPY.Location = new System.Drawing.Point(190, 44);
            this.lblPY.Name = "lblPY";
            this.lblPY.Size = new System.Drawing.Size(59, 13);
            this.lblPY.TabIndex = 5;
            this.lblPY.Text = "Pocição Y:";
            // 
            // lblPX
            // 
            this.lblPX.AutoSize = true;
            this.lblPX.Location = new System.Drawing.Point(37, 44);
            this.lblPX.Name = "lblPX";
            this.lblPX.Size = new System.Drawing.Size(64, 13);
            this.lblPX.TabIndex = 4;
            this.lblPX.Text = "Posição  X: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPX);
            this.groupBox1.Controls.Add(this.lblPY);
            this.groupBox1.Controls.Add(this.CtHist);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(439, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 485);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histograma";
            // 
            // CtHist
            // 
            chartArea2.Name = "ChartArea1";
            this.CtHist.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.CtHist.Legends.Add(legend2);
            this.CtHist.Location = new System.Drawing.Point(15, 68);
            this.CtHist.Name = "CtHist";
            this.CtHist.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.CtHist.Series.Add(series4);
            this.CtHist.Series.Add(series5);
            this.CtHist.Series.Add(series6);
            this.CtHist.Size = new System.Drawing.Size(377, 385);
            this.CtHist.TabIndex = 1;
            this.CtHist.Text = "chart1";
            title4.Name = "Red";
            title5.Name = "Green";
            title6.Name = "Blue";
            this.CtHist.Titles.Add(title4);
            this.CtHist.Titles.Add(title5);
            this.CtHist.Titles.Add(title6);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 460);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEqualizar
            // 
            this.btnEqualizar.Location = new System.Drawing.Point(10, 77);
            this.btnEqualizar.Name = "btnEqualizar";
            this.btnEqualizar.Size = new System.Drawing.Size(144, 23);
            this.btnEqualizar.TabIndex = 4;
            this.btnEqualizar.Text = "Equalizar";
            this.btnEqualizar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Carregar Imagem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GbFuncoes
            // 
            this.GbFuncoes.Controls.Add(this.btnOriginal);
            this.GbFuncoes.Controls.Add(this.btnAbrirImagem);
            this.GbFuncoes.Controls.Add(this.button2);
            this.GbFuncoes.Controls.Add(this.btnEqualizar);
            this.GbFuncoes.Location = new System.Drawing.Point(857, 21);
            this.GbFuncoes.Name = "GbFuncoes";
            this.GbFuncoes.Size = new System.Drawing.Size(163, 483);
            this.GbFuncoes.TabIndex = 6;
            this.GbFuncoes.TabStop = false;
            this.GbFuncoes.Text = "Funcionalidade";
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(10, 47);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(144, 23);
            this.btnOriginal.TabIndex = 6;
            this.btnOriginal.Text = "Imagem Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 516);
            this.Controls.Add(this.GbFuncoes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GpbImagem);
            this.Name = "frmMain";
            this.Text = "..:: PDI ::..";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagem)).EndInit();
            this.GpbImagem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CtHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbFuncoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbImagem;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.GroupBox GpbImagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CtHist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPY;
        private System.Windows.Forms.Label lblPX;
        private System.Windows.Forms.Button btnEqualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox GbFuncoes;
        private System.Windows.Forms.Button btnOriginal;
    }
}

