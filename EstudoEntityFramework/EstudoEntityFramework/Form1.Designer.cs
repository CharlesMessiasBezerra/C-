namespace EstudoEntityFramework
{
    partial class Form1
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
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.txt_Cod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show
            // 
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(15, 219);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.Size = new System.Drawing.Size(581, 196);
            this.dgv_show.TabIndex = 0;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(521, 203);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(75, 13);
            this.lbl_count.TabIndex = 1;
            this.lbl_count.Text = "TotalRegistros";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(224, 427);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 2;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(353, 427);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(484, 427);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(66, 62);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(269, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome : ";
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(16, 86);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(43, 13);
            this.lbl_bairro.TabIndex = 8;
            this.lbl_bairro.Text = "Bairro : ";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(66, 86);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(269, 20);
            this.txt_bairro.TabIndex = 7;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(16, 111);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(43, 13);
            this.lbl_idade.TabIndex = 10;
            this.lbl_idade.Text = "Idade : ";
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(66, 111);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(80, 20);
            this.txt_idade.TabIndex = 9;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Location = new System.Drawing.Point(16, 137);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(40, 13);
            this.lbl_Sexo.TabIndex = 12;
            this.lbl_Sexo.Text = "Sexo : ";
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(66, 137);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(80, 20);
            this.txt_sexo.TabIndex = 11;
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Location = new System.Drawing.Point(16, 36);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(35, 13);
            this.lbl_cod.TabIndex = 14;
            this.lbl_cod.Text = "Cod : ";
            // 
            // txt_Cod
            // 
            this.txt_Cod.Location = new System.Drawing.Point(66, 36);
            this.txt_Cod.Name = "txt_Cod";
            this.txt_Cod.Size = new System.Drawing.Size(80, 20);
            this.txt_Cod.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 465);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.txt_Cod);
            this.Controls.Add(this.lbl_Sexo);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.dgv_show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.TextBox txt_Cod;
    }
}

