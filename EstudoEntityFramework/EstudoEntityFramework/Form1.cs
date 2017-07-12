using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEntityFramework
{
    public partial class Form1 : Form
    {
        private int pk_intCod;
        private int fk_intBairro;
        private string strNOME;
        private int intIdade ;
        private string strSexo ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lerdados();
        }

        private void lerdados()
        {
            BDEstudoConnection context = new BDEstudoConnection();


            IEnumerable<Cliente> listmovimentos = from i in context.Cliente select i;

            lbl_count.Text = "total clientes :" + listmovimentos.Count();
            dgv_show.DataSource = listmovimentos.ToList();

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            // dados
         
         fk_intBairro = int.Parse(txt_bairro.Text);
         strNOME = txt_nome.Text;
         intIdade = int.Parse(txt_idade.Text) ;
         strSexo = txt_sexo.Text;


            BDEstudoConnection context = new BDEstudoConnection();

            Cliente newCliente = new Cliente() { fk_intBairro = this.fk_intBairro, strNOME = this.strNOME, intIdade = this.intIdade, strSexo = this.strSexo };

            context.Cliente.Add(newCliente);

            context.SaveChanges();

            lerdados();

            MessageBox.Show("Dados inseridos com sucesso");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            pk_intCod = int.Parse(txt_Cod.Text);
            

            BDEstudoConnection context = new BDEstudoConnection();

            Cliente deleteCliente = context.Cliente.First(i => i.pk_intCod == this.pk_intCod);

            context.Cliente.Remove(deleteCliente);

            context.SaveChanges();
            lerdados();
            MessageBox.Show("Dados removido com sucesso");
            

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            pk_intCod = int.Parse(txt_Cod.Text);
            fk_intBairro = int.Parse(txt_bairro.Text);
            strNOME = txt_nome.Text;
            intIdade = int.Parse(txt_idade.Text);
            strSexo = txt_sexo.Text;

            BDEstudoConnection context = new BDEstudoConnection();

            Cliente readCliente = context.Cliente.First(i => i.pk_intCod == this.pk_intCod);
            readCliente.strNOME = this.strNOME;
            readCliente.fk_intBairro = this.fk_intBairro;
            readCliente.intIdade = this.intIdade;
            readCliente.strSexo = this.strSexo;

            context.SaveChanges();
            lerdados();
            MessageBox.Show("Dados atualizado com sucesso");
        }
    }
}
