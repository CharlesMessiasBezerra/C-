namespace Compilador
{
    partial class FrmCompilador
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.tbpResult = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tbcResult = new System.Windows.Forms.TabControl();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtAbrirCaminho = new System.Windows.Forms.TextBox();
            this.btnAbriCode = new System.Windows.Forms.Button();
            this.tbpResult.SuspendLayout();
            this.tbcResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(16, 110);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(877, 241);
            this.txtCode.TabIndex = 0;
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(702, 357);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(75, 23);
            this.btnCompilar.TabIndex = 2;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // tbpResult
            // 
            this.tbpResult.BackColor = System.Drawing.Color.DimGray;
            this.tbpResult.Controls.Add(this.txtResult);
            this.tbpResult.Location = new System.Drawing.Point(4, 22);
            this.tbpResult.Name = "tbpResult";
            this.tbpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResult.Size = new System.Drawing.Size(870, 176);
            this.tbpResult.TabIndex = 1;
            this.tbpResult.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtResult.Location = new System.Drawing.Point(3, 3);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(864, 170);
            this.txtResult.TabIndex = 0;
            // 
            // tbcResult
            // 
            this.tbcResult.Controls.Add(this.tbpResult);
            this.tbcResult.Location = new System.Drawing.Point(12, 386);
            this.tbcResult.Name = "tbcResult";
            this.tbcResult.SelectedIndex = 0;
            this.tbcResult.Size = new System.Drawing.Size(878, 202);
            this.tbcResult.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(783, 357);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtAbrirCaminho
            // 
            this.txtAbrirCaminho.Location = new System.Drawing.Point(58, 53);
            this.txtAbrirCaminho.Name = "txtAbrirCaminho";
            this.txtAbrirCaminho.Size = new System.Drawing.Size(621, 20);
            this.txtAbrirCaminho.TabIndex = 5;
            // 
            // btnAbriCode
            // 
            this.btnAbriCode.Location = new System.Drawing.Point(686, 53);
            this.btnAbriCode.Name = "btnAbriCode";
            this.btnAbriCode.Size = new System.Drawing.Size(119, 23);
            this.btnAbriCode.TabIndex = 6;
            this.btnAbriCode.Text = "Abrir";
            this.btnAbriCode.UseVisualStyleBackColor = true;
            this.btnAbriCode.Click += new System.EventHandler(this.btnAbriCode_Click);
            // 
            // FrmCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 615);
            this.Controls.Add(this.btnAbriCode);
            this.Controls.Add(this.txtAbrirCaminho);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.tbcResult);
            this.Controls.Add(this.txtCode);
            this.Name = "FrmCompilador";
            this.Text = "                                                                                 " +
    "                         ....................::::: Compilador :::::............." +
    ".......";
            this.Load += new System.EventHandler(this.FrmCompilador_Load);
            this.tbpResult.ResumeLayout(false);
            this.tbpResult.PerformLayout();
            this.tbcResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.TabPage tbpResult;
        private System.Windows.Forms.TabControl tbcResult;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtAbrirCaminho;
        private System.Windows.Forms.Button btnAbriCode;
        private System.Windows.Forms.TextBox txtResult;
    }
}

