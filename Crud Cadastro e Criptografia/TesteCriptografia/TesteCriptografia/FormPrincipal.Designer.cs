namespace TesteCriptografia
{
    partial class FormPrincipal
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
            this.grpConfiguracoes = new System.Windows.Forms.GroupBox();
            this.txtVetorInicializacao = new System.Windows.Forms.TextBox();
            this.lblVetorInicializacao = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.lblChave = new System.Windows.Forms.Label();
            this.grpEncriptacao = new System.Windows.Forms.GroupBox();
            this.txtResultadoEncriptacao = new System.Windows.Forms.TextBox();
            this.lblResultadoEncriptacao = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtTextoAEncriptar = new System.Windows.Forms.TextBox();
            this.lblTextoAEncriptar = new System.Windows.Forms.Label();
            this.grpDecriptacao = new System.Windows.Forms.GroupBox();
            this.txtResultadoDecriptacao = new System.Windows.Forms.TextBox();
            this.lblResultadoDecriptacao = new System.Windows.Forms.Label();
            this.btnDecriptar = new System.Windows.Forms.Button();
            this.txtTextoADecriptar = new System.Windows.Forms.TextBox();
            this.lblTextoADecriptar = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpConfiguracoes.SuspendLayout();
            this.grpEncriptacao.SuspendLayout();
            this.grpDecriptacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConfiguracoes
            // 
            this.grpConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpConfiguracoes.Controls.Add(this.txtVetorInicializacao);
            this.grpConfiguracoes.Controls.Add(this.lblVetorInicializacao);
            this.grpConfiguracoes.Controls.Add(this.txtChave);
            this.grpConfiguracoes.Controls.Add(this.lblChave);
            this.grpConfiguracoes.Location = new System.Drawing.Point(4, 3);
            this.grpConfiguracoes.Name = "grpConfiguracoes";
            this.grpConfiguracoes.Size = new System.Drawing.Size(442, 74);
            this.grpConfiguracoes.TabIndex = 0;
            this.grpConfiguracoes.TabStop = false;
            this.grpConfiguracoes.Text = "Configurações";
            // 
            // txtVetorInicializacao
            // 
            this.txtVetorInicializacao.Location = new System.Drawing.Point(274, 37);
            this.txtVetorInicializacao.MaxLength = 16;
            this.txtVetorInicializacao.Name = "txtVetorInicializacao";
            this.txtVetorInicializacao.Size = new System.Drawing.Size(146, 20);
            this.txtVetorInicializacao.TabIndex = 3;
            // 
            // lblVetorInicializacao
            // 
            this.lblVetorInicializacao.AutoSize = true;
            this.lblVetorInicializacao.Location = new System.Drawing.Point(271, 20);
            this.lblVetorInicializacao.Name = "lblVetorInicializacao";
            this.lblVetorInicializacao.Size = new System.Drawing.Size(111, 13);
            this.lblVetorInicializacao.TabIndex = 2;
            this.lblVetorInicializacao.Text = "Vetor de Inicialização:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(21, 37);
            this.txtChave.MaxLength = 32;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(247, 20);
            this.txtChave.TabIndex = 1;
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(18, 20);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(41, 13);
            this.lblChave.TabIndex = 0;
            this.lblChave.Text = "Chave:";
            // 
            // grpEncriptacao
            // 
            this.grpEncriptacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEncriptacao.Controls.Add(this.txtResultadoEncriptacao);
            this.grpEncriptacao.Controls.Add(this.lblResultadoEncriptacao);
            this.grpEncriptacao.Controls.Add(this.btnEncriptar);
            this.grpEncriptacao.Controls.Add(this.txtTextoAEncriptar);
            this.grpEncriptacao.Controls.Add(this.lblTextoAEncriptar);
            this.grpEncriptacao.Location = new System.Drawing.Point(4, 83);
            this.grpEncriptacao.Name = "grpEncriptacao";
            this.grpEncriptacao.Size = new System.Drawing.Size(442, 140);
            this.grpEncriptacao.TabIndex = 1;
            this.grpEncriptacao.TabStop = false;
            this.grpEncriptacao.Text = "Encriptação";
            // 
            // txtResultadoEncriptacao
            // 
            this.txtResultadoEncriptacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultadoEncriptacao.Location = new System.Drawing.Point(21, 109);
            this.txtResultadoEncriptacao.Name = "txtResultadoEncriptacao";
            this.txtResultadoEncriptacao.ReadOnly = true;
            this.txtResultadoEncriptacao.Size = new System.Drawing.Size(399, 20);
            this.txtResultadoEncriptacao.TabIndex = 4;
            // 
            // lblResultadoEncriptacao
            // 
            this.lblResultadoEncriptacao.AutoSize = true;
            this.lblResultadoEncriptacao.Location = new System.Drawing.Point(18, 93);
            this.lblResultadoEncriptacao.Name = "lblResultadoEncriptacao";
            this.lblResultadoEncriptacao.Size = new System.Drawing.Size(58, 13);
            this.lblResultadoEncriptacao.TabIndex = 3;
            this.lblResultadoEncriptacao.Text = "Resultado:";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(21, 63);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 2;
            this.btnEncriptar.Text = "&Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtTextoAEncriptar
            // 
            this.txtTextoAEncriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoAEncriptar.Location = new System.Drawing.Point(21, 37);
            this.txtTextoAEncriptar.Name = "txtTextoAEncriptar";
            this.txtTextoAEncriptar.Size = new System.Drawing.Size(399, 20);
            this.txtTextoAEncriptar.TabIndex = 1;
            // 
            // lblTextoAEncriptar
            // 
            this.lblTextoAEncriptar.AutoSize = true;
            this.lblTextoAEncriptar.Location = new System.Drawing.Point(18, 21);
            this.lblTextoAEncriptar.Name = "lblTextoAEncriptar";
            this.lblTextoAEncriptar.Size = new System.Drawing.Size(116, 13);
            this.lblTextoAEncriptar.TabIndex = 0;
            this.lblTextoAEncriptar.Text = "Texto a ser encriptado:";
            // 
            // grpDecriptacao
            // 
            this.grpDecriptacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecriptacao.Controls.Add(this.txtResultadoDecriptacao);
            this.grpDecriptacao.Controls.Add(this.lblResultadoDecriptacao);
            this.grpDecriptacao.Controls.Add(this.btnDecriptar);
            this.grpDecriptacao.Controls.Add(this.txtTextoADecriptar);
            this.grpDecriptacao.Controls.Add(this.lblTextoADecriptar);
            this.grpDecriptacao.Location = new System.Drawing.Point(4, 229);
            this.grpDecriptacao.Name = "grpDecriptacao";
            this.grpDecriptacao.Size = new System.Drawing.Size(442, 140);
            this.grpDecriptacao.TabIndex = 2;
            this.grpDecriptacao.TabStop = false;
            this.grpDecriptacao.Text = "Decriptação";
            // 
            // txtResultadoDecriptacao
            // 
            this.txtResultadoDecriptacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultadoDecriptacao.Location = new System.Drawing.Point(21, 109);
            this.txtResultadoDecriptacao.Name = "txtResultadoDecriptacao";
            this.txtResultadoDecriptacao.ReadOnly = true;
            this.txtResultadoDecriptacao.Size = new System.Drawing.Size(399, 20);
            this.txtResultadoDecriptacao.TabIndex = 4;
            // 
            // lblResultadoDecriptacao
            // 
            this.lblResultadoDecriptacao.AutoSize = true;
            this.lblResultadoDecriptacao.Location = new System.Drawing.Point(18, 93);
            this.lblResultadoDecriptacao.Name = "lblResultadoDecriptacao";
            this.lblResultadoDecriptacao.Size = new System.Drawing.Size(58, 13);
            this.lblResultadoDecriptacao.TabIndex = 3;
            this.lblResultadoDecriptacao.Text = "Resultado:";
            // 
            // btnDecriptar
            // 
            this.btnDecriptar.Location = new System.Drawing.Point(21, 63);
            this.btnDecriptar.Name = "btnDecriptar";
            this.btnDecriptar.Size = new System.Drawing.Size(75, 23);
            this.btnDecriptar.TabIndex = 2;
            this.btnDecriptar.Text = "&Decriptar";
            this.btnDecriptar.UseVisualStyleBackColor = true;
            this.btnDecriptar.Click += new System.EventHandler(this.btnDecriptar_Click);
            // 
            // txtTextoADecriptar
            // 
            this.txtTextoADecriptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoADecriptar.Location = new System.Drawing.Point(21, 37);
            this.txtTextoADecriptar.Name = "txtTextoADecriptar";
            this.txtTextoADecriptar.Size = new System.Drawing.Size(399, 20);
            this.txtTextoADecriptar.TabIndex = 1;
            // 
            // lblTextoADecriptar
            // 
            this.lblTextoADecriptar.AutoSize = true;
            this.lblTextoADecriptar.Location = new System.Drawing.Point(18, 21);
            this.lblTextoADecriptar.Name = "lblTextoADecriptar";
            this.lblTextoADecriptar.Size = new System.Drawing.Size(116, 13);
            this.lblTextoADecriptar.TabIndex = 0;
            this.lblTextoADecriptar.Text = "Texto a ser decriptado:";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(364, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 415);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpDecriptacao);
            this.Controls.Add(this.grpEncriptacao);
            this.Controls.Add(this.grpConfiguracoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Criptografia - Utilizando a Classe Rijndael";
            this.grpConfiguracoes.ResumeLayout(false);
            this.grpConfiguracoes.PerformLayout();
            this.grpEncriptacao.ResumeLayout(false);
            this.grpEncriptacao.PerformLayout();
            this.grpDecriptacao.ResumeLayout(false);
            this.grpDecriptacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguracoes;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.TextBox txtVetorInicializacao;
        private System.Windows.Forms.Label lblVetorInicializacao;
        private System.Windows.Forms.GroupBox grpEncriptacao;
        private System.Windows.Forms.TextBox txtResultadoEncriptacao;
        private System.Windows.Forms.Label lblResultadoEncriptacao;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtTextoAEncriptar;
        private System.Windows.Forms.Label lblTextoAEncriptar;
        private System.Windows.Forms.GroupBox grpDecriptacao;
        private System.Windows.Forms.TextBox txtResultadoDecriptacao;
        private System.Windows.Forms.Label lblResultadoDecriptacao;
        private System.Windows.Forms.Button btnDecriptar;
        private System.Windows.Forms.TextBox txtTextoADecriptar;
        private System.Windows.Forms.Label lblTextoADecriptar;
        private System.Windows.Forms.Button btnSair;

    }
}

