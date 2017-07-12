namespace CrudEF
{
    partial class CrudCharles
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dtView = new System.Windows.Forms.DataGridView();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apelido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.rbApelido = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCod = new System.Windows.Forms.RadioButton();
            this.btn_Salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(211, 63);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 0;
            this.btn_Pesquisar.Text = "Pesuisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(79, 330);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(90, 20);
            this.txt_cod.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(156, 482);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(239, 482);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(320, 482);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dtView
            // 
            this.dtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtView.Location = new System.Drawing.Point(12, 12);
            this.dtView.Name = "dtView";
            this.dtView.Size = new System.Drawing.Size(504, 168);
            this.dtView.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(79, 356);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(408, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(79, 406);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(135, 20);
            this.txt_sexo.TabIndex = 7;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(79, 382);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(90, 20);
            this.txt_idade.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(79, 432);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(288, 20);
            this.txt_bairro.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Apelido:";
            // 
            // txt_apelido
            // 
            this.txt_apelido.Location = new System.Drawing.Point(231, 382);
            this.txt_apelido.Name = "txt_apelido";
            this.txt_apelido.Size = new System.Drawing.Size(256, 20);
            this.txt_apelido.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pesquisa);
            this.groupBox1.Controls.Add(this.rbApelido);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbCod);
            this.groupBox1.Controls.Add(this.btn_Pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(62, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(59, 63);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(135, 20);
            this.txt_pesquisa.TabIndex = 18;
            // 
            // rbApelido
            // 
            this.rbApelido.AutoSize = true;
            this.rbApelido.Location = new System.Drawing.Point(254, 29);
            this.rbApelido.Name = "rbApelido";
            this.rbApelido.Size = new System.Drawing.Size(60, 17);
            this.rbApelido.TabIndex = 4;
            this.rbApelido.Text = "Apelido";
            this.rbApelido.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(152, 29);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 3;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCod
            // 
            this.rbCod.AutoSize = true;
            this.rbCod.Checked = true;
            this.rbCod.Location = new System.Drawing.Point(44, 29);
            this.rbCod.Name = "rbCod";
            this.rbCod.Size = new System.Drawing.Size(44, 17);
            this.rbCod.TabIndex = 2;
            this.rbCod.TabStop = true;
            this.rbCod.Text = "Cod";
            this.rbCod.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(75, 482);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 18;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // CrudCharles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 558);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_apelido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.dtView);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_cod);
            this.Name = "CrudCharles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrudCharles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dtView;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apelido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.RadioButton rbApelido;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCod;
        private System.Windows.Forms.Button btn_Salvar;
    }
}

