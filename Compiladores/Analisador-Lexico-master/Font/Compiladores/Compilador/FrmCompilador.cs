using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{


    public partial class FrmCompilador : Form
    {

        #region Variaveis Publicas 

        /// <summary>
        /// The code
        /// </summary>
        string code;

        /// <summary>
        /// The sintaxe
        /// </summary>
        Hashtable Sintaxe;
              
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCompilador"/> class.
        /// </summary>
        public FrmCompilador()
        {
            InitializeComponent();                        
        }

        #endregion

        #region Eventos do Form

        /// <summary>
        /// Handles the Click event of the btnCompilar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCompilar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(txtCode.Text)))
            {

                StreamReader codigo = new StreamReader(txtAbrirCaminho.Text);

                AnalisadorLexico analisadorLexico = new AnalisadorLexico(Convert.ToString(txtCode.Text));
                analisadorLexico.realizaAnaliseLexica(codigo);

               
                foreach (string t in analisadorLexico.lstErros)
                {
                    txtResult.Text = txtResult.Text + t + "\r\n\n";
                }

                if (!(txtResult.Text == "")) {

                    txtResult.Text = txtResult.Text + "\r\n\n";
                    txtResult.Text = txtResult.Text + "\r\n\n";
                    txtResult.Text = txtResult.Text + "============================================"+ "\r\n\n";
                    txtResult.Text = txtResult.Text + "=============   Analise Lexica  ============" + "\r\n\n";
                    txtResult.Text = txtResult.Text + "============================================" + "\r\n\n";
                    txtResult.Text = txtResult.Text + "\r\n\n";
                    txtResult.Text = txtResult.Text + "\r\n\n";

                }

                foreach (Token t in analisadorLexico.lstToken ) {
                    txtResult.Text = txtResult.Text + " id : " + t.id +" Tipo : " + t.tipo  + "\r\n\n";
                }
               

            }
        }

        /// <summary>
        /// Handles the Click event of the btnAbriCode control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAbriCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Code";
            dlg.Filter = "files (*.txt)| *.TXT";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtAbrirCaminho.Text = dlg.FileName;

                System.IO.StreamReader reader = new System.IO.StreamReader(dlg.FileName);

                code = "";
                while (!reader.EndOfStream)
                {
                    code = code + reader.ReadLine() + "\r\n\n";
                }

                txtCode.Text = code;
            }

        }

        /// <summary>
        /// Handles the Load event of the FrmCompilador control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmCompilador_Load(object sender, EventArgs e)
        {

            // Teste Remover apos o final
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Code";
            dlg.Filter = "files (*.txt)| *.TXT";


            dlg.FileName = "D:\\Dev\\TFS\\Compiladores\\Compilador\\Exemplos de Codigo\\Programa_1_Erro_Comentario.txt";
            txtAbrirCaminho.Text = dlg.FileName;

            System.IO.StreamReader reader = new System.IO.StreamReader(dlg.FileName);

            code = "";
            while (!reader.EndOfStream)
            {
                code = code + reader.ReadLine() + "\r\n\n";
            }

            txtCode.Text = code;

        }

        /// <summary>
        /// Handles the Click event of the btnLimpar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtAbrirCaminho.Text = "";
            txtResult.Text = "";
        }

        #endregion

    }
}