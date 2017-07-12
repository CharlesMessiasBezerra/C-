using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaFinal
{
    public partial class CadastroContas : Form
    {
        private Form1 appPrincipal;
        public CadastroContas(Form1 appPrincipal)
        {
            this.appPrincipal = appPrincipal;
            InitializeComponent();
        }

        private void botaoAdiciona_Click(object sender, EventArgs e)
        {

            if (ComboTipo.SelectedIndex == 0)
            {
                appPrincipal.AdicionaConta(new ContaCorrente(textoNome.Text, Convert.ToInt32(textoNumero.Text),
                    Convert.ToInt32(textoIdade.Text), textoBairro.Text, texoCidade.Text,
                    Convert.ToDouble(textoSaldo.Text)));
            }
            else
            {
                appPrincipal.AdicionaConta( new ContaPoupanca(textoNome.Text, Convert.ToInt32(textoNumero.Text),
                    Convert.ToInt32(textoIdade.Text), textoBairro.Text, texoCidade.Text,
                    Convert.ToDouble(textoSaldo.Text)));
            }
          
           MessageBox.Show("Usuario cadastrado com sucesso");
           this.Hide();
        }

        private void CadastroContas_Load(object sender, EventArgs e)
        {
            ComboTipo.Items.Add("Conta Corrente");
            ComboTipo.Items.Add("Conta Poupança");
            
        }
    }
}
