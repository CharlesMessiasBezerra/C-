namespace CrudCadastro
{
    partial class frm_Cadastro
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
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.ptb_Foto = new System.Windows.Forms.PictureBox();
            this.btn_AdicionarFoto = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cnpj = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.Label();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Novo = new System.Windows.Forms.Button();
            this.txt_Excluir = new System.Windows.Forms.Button();
            this.txt_Alterar = new System.Windows.Forms.Button();
            this.txt_Salvar = new System.Windows.Forms.Button();
            this.dt_DadosCadastro = new System.Windows.Forms.DataGridView();
            this.txt_IdCadastro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DadosCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(249, 54);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(83, 20);
            this.btn_Pesquisar.TabIndex = 0;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Cliente : ";
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(22, 54);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(221, 20);
            this.txt_Pesquisar.TabIndex = 2;
            // 
            // ptb_Foto
            // 
            this.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Foto.Location = new System.Drawing.Point(379, 23);
            this.ptb_Foto.Name = "ptb_Foto";
            this.ptb_Foto.Size = new System.Drawing.Size(143, 177);
            this.ptb_Foto.TabIndex = 3;
            this.ptb_Foto.TabStop = false;
            // 
            // btn_AdicionarFoto
            // 
            this.btn_AdicionarFoto.Location = new System.Drawing.Point(379, 208);
            this.btn_AdicionarFoto.Name = "btn_AdicionarFoto";
            this.btn_AdicionarFoto.Size = new System.Drawing.Size(143, 23);
            this.btn_AdicionarFoto.TabIndex = 4;
            this.btn_AdicionarFoto.Text = "Adicionar Foto";
            this.btn_AdicionarFoto.UseVisualStyleBackColor = true;
            this.btn_AdicionarFoto.Click += new System.EventHandler(this.btn_AdicionarFoto_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(20, 81);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(302, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(20, 121);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(55, 20);
            this.txt_Idade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idade : ";
            // 
            // txt_Cnpj
            // 
            this.txt_Cnpj.Location = new System.Drawing.Point(20, 201);
            this.txt_Cnpj.Name = "txt_Cnpj";
            this.txt_Cnpj.Size = new System.Drawing.Size(302, 20);
            this.txt_Cnpj.TabIndex = 9;
            // 
            // txt_cpf
            // 
            this.txt_cpf.AutoSize = true;
            this.txt_cpf.Location = new System.Drawing.Point(17, 185);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(58, 13);
            this.txt_cpf.TabIndex = 8;
            this.txt_cpf.Text = "Cpf/Cnpj : ";
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(20, 163);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(302, 21);
            this.cmb_cidade.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cidade : ";
            // 
            // txt_Novo
            // 
            this.txt_Novo.Location = new System.Drawing.Point(22, 229);
            this.txt_Novo.Name = "txt_Novo";
            this.txt_Novo.Size = new System.Drawing.Size(75, 23);
            this.txt_Novo.TabIndex = 14;
            this.txt_Novo.Text = "Novo";
            this.txt_Novo.UseVisualStyleBackColor = true;
            this.txt_Novo.Click += new System.EventHandler(this.txt_Novo_Click);
            // 
            // txt_Excluir
            // 
            this.txt_Excluir.Location = new System.Drawing.Point(103, 229);
            this.txt_Excluir.Name = "txt_Excluir";
            this.txt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.txt_Excluir.TabIndex = 15;
            this.txt_Excluir.Text = "Excluir";
            this.txt_Excluir.UseVisualStyleBackColor = true;
            this.txt_Excluir.Click += new System.EventHandler(this.txt_Excluir_Click);
            // 
            // txt_Alterar
            // 
            this.txt_Alterar.Location = new System.Drawing.Point(184, 229);
            this.txt_Alterar.Name = "txt_Alterar";
            this.txt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.txt_Alterar.TabIndex = 16;
            this.txt_Alterar.Text = "Alterar";
            this.txt_Alterar.UseVisualStyleBackColor = true;
            this.txt_Alterar.Click += new System.EventHandler(this.txt_Alterar_Click);
            // 
            // txt_Salvar
            // 
            this.txt_Salvar.Location = new System.Drawing.Point(270, 229);
            this.txt_Salvar.Name = "txt_Salvar";
            this.txt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.txt_Salvar.TabIndex = 17;
            this.txt_Salvar.Text = "Salvar";
            this.txt_Salvar.UseVisualStyleBackColor = true;
            this.txt_Salvar.Click += new System.EventHandler(this.txt_Salvar_Click);
            // 
            // dt_DadosCadastro
            // 
            this.dt_DadosCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_DadosCadastro.Location = new System.Drawing.Point(12, 377);
            this.dt_DadosCadastro.Name = "dt_DadosCadastro";
            this.dt_DadosCadastro.Size = new System.Drawing.Size(555, 150);
            this.dt_DadosCadastro.TabIndex = 18;
            // 
            // txt_IdCadastro
            // 
            this.txt_IdCadastro.Location = new System.Drawing.Point(19, 41);
            this.txt_IdCadastro.Name = "txt_IdCadastro";
            this.txt_IdCadastro.Size = new System.Drawing.Size(56, 20);
            this.txt_IdCadastro.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Id : ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.radioButton2);
            this.groupControl1.Controls.Add(this.radioButton1);
            this.groupControl1.Controls.Add(this.txt_Pesquisar);
            this.groupControl1.Controls.Add(this.btn_Pesquisar);
            this.groupControl1.Location = new System.Drawing.Point(12, 280);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 91);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Pesquisa";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(126, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Nome";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(35, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "IdCliente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txt_IdCadastro);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.txt_Nome);
            this.groupControl2.Controls.Add(this.btn_AdicionarFoto);
            this.groupControl2.Controls.Add(this.ptb_Foto);
            this.groupControl2.Controls.Add(this.txt_Salvar);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txt_Alterar);
            this.groupControl2.Controls.Add(this.txt_Idade);
            this.groupControl2.Controls.Add(this.txt_Excluir);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txt_Novo);
            this.groupControl2.Controls.Add(this.txt_cpf);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txt_Cnpj);
            this.groupControl2.Controls.Add(this.cmb_cidade);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(555, 262);
            this.groupControl2.TabIndex = 22;
            this.groupControl2.Text = "Cadastro";
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(575, 533);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dt_DadosCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Cadastro";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frm_Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_DadosCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.PictureBox ptb_Foto;
        private System.Windows.Forms.Button btn_AdicionarFoto;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cnpj;
        private System.Windows.Forms.Label txt_cpf;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txt_Novo;
        private System.Windows.Forms.Button txt_Excluir;
        private System.Windows.Forms.Button txt_Alterar;
        private System.Windows.Forms.Button txt_Salvar;
        private System.Windows.Forms.DataGridView dt_DadosCadastro;
        private System.Windows.Forms.TextBox txt_IdCadastro;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}

