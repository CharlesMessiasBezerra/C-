using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private Conta[] contas = new Conta[50];
        private int numeroDeContas = 0;

        public void AdicionaConta(Conta c)
        {
            contas[numeroDeContas] = c;
            comboCliente1.Items.Add(c.nome);
            comboCliente2.Items.Add(c.nome);
            numeroDeContas++;
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BotaoAdiciona_Click(object sender, EventArgs e)
        {
            CadastroContas cadastro = new CadastroContas(this);
            cadastro.ShowDialog();
            cadastro.Close();
                        
        }

        private void BotaoSacar_Click(object sender, EventArgs e)
        {
            int i = comboCliente1.SelectedIndex;
            Conta conta1 = contas[i];
            conta1.saca(Convert.ToDouble(TextoValor.Text));
            textoSaldo1.Text = Convert.ToString(conta1.saldo);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
         
            Conta c1 = new Conta("Huguinho",2334,23,"Centro","Serrana",25);
            Conta c2 = new Conta("Zezino", 2334, 20, "Jd Bela Vista", "Serrana",77);
            Conta c3 = new Conta("Luizinho", 2334, 23, "Centro", "Serrana",54);

            AdicionaConta(c1);
            AdicionaConta(c2);
            AdicionaConta(c3);                     
            
        }

        private void comboCliente1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboCliente1.SelectedIndex;
            textoNumero1.Text = Convert.ToString(contas[i].numero);
            textoIdade1.Text = Convert.ToString(contas[i].idade);
            texoCidade1.Text = contas[i].cidade;
            textoBairro1.Text = contas[i].bairro;
            textoSaldo1.Text = Convert.ToString(contas[i].saldo);

        }

        private void comboCliente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboCliente2.SelectedIndex;
            textoNumero2.Text = Convert.ToString(contas[i].numero);
            textoIdade2.Text = Convert.ToString(contas[i].idade);
            texoCidade2.Text = contas[i].cidade;
            textoBairro2.Text = contas[i].bairro;
            textoSaldo2.Text = Convert.ToString(contas[i].saldo);
        }

        private void BotaoTranfere_Click(object sender, EventArgs e)
        {
            int i = comboCliente1.SelectedIndex;
            Conta conta1 = contas[i];
            i = comboCliente2.SelectedIndex;
            Conta conta2 = contas[i];

            conta1.tranferencia(conta2, Convert.ToDouble(TextoValor.Text));

            textoSaldo1.Text = Convert.ToString(conta1.saldo);
            textoSaldo2.Text = Convert.ToString(conta2.saldo);

        }

        private void BotaoDeposita_Click(object sender, EventArgs e)
        {
            int i = comboCliente1.SelectedIndex;
            Conta conta1 = contas[i];
            
            conta1.deposita(Convert.ToDouble(TextoValor.Text));
            textoSaldo1.Text = Convert.ToString(conta1.saldo);
            
        }
    }
}
