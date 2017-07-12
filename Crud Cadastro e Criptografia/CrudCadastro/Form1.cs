using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayerCrudCadastro;
using DevExpress.XtraSplashScreen;

namespace CrudCadastro
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        public byte[] byteArray = new byte[0];

        private void frm_Cadastro_Load(object sender, EventArgs e)
        {
            ConfgInicial();
            BusinessLogicLayerCrudCadastro.Class1 bu = new Class1();
            DataTable dtcidades = bu.BUListaCidades();

            cmb_cidade.DataSource = dtcidades;
            cmb_cidade.ValueMember = "pk_idcidade";
            cmb_cidade.DisplayMember = "str_nomeCidade";


            dt_DadosCadastro.DataSource = bu.BUListaDadosDataTable();

        }

        private void txt_Salvar_Click(object sender, EventArgs e)
        {

            BusinessLogicLayerCrudCadastro.Class1 bu = new Class1();
            if (bu.BUInsertCadastro(txt_Nome.Text, Convert.ToInt32(txt_Idade.Text), txt_Cnpj.Text,Convert.ToInt32(cmb_cidade.SelectedValue), byteArray))
            {
                MessageBox.Show("Cadastro Efetuado com sucesso");
                Limpacampos();
                ConfgInicial();
                dt_DadosCadastro.DataSource = bu.BUListaDadosDataTable();
            }
            else
            {
                MessageBox.Show("Erro ao Efetuar Cadastro");
            }
            
        }

        private void txt_Excluir_Click(object sender, EventArgs e)
        {
            BusinessLogicLayerCrudCadastro.Class1 bu = new Class1();
            if (bu.BUDeleteCadastro(Convert.ToInt32(txt_IdCadastro.Text)))
            {
                MessageBox.Show("Cadastro Excluido com sucesso");
                Limpacampos();
                ConfgInicial();
            }
            else
            {
                MessageBox.Show("Erro ao Efetuar Exclusão");
            }

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            BusinessLogicLayerCrudCadastro.Class1 bu = new Class1();
            SqlDataReader sql = bu.BUPesquisa(Convert.ToInt32(txt_Pesquisar.Text));

            txt_IdCadastro.Text = sql["pk_idcadsatro"].ToString();
            txt_Nome.Text = sql["str_nome"].ToString();
            txt_Idade.Text = sql["int_idade"].ToString();
            txt_Cnpj.Text = sql["str_CpfCnpj"].ToString();
            cmb_cidade.SelectedValue = sql["fk_idcidade"].ToString();

            var byteFigura = new Byte[0];
            byteFigura = (Byte[]) (sql["img_FotoCadastro"]);
            var mstbyteFigura = new MemoryStream(byteFigura);
            ptb_Foto.Image = Image.FromStream(mstbyteFigura);
        }

        private void txt_Alterar_Click(object sender, EventArgs e)
        {
            Liberacampos();
        }

        private void txt_Novo_Click(object sender, EventArgs e)
        {
            var aguarde = new frm_Aguarde();
            //System.Threading.Thread.Sleep(10000);
            aguarde.Show();
            Limpacampos();
            Liberacampos();
            aguarde.Close();
        }

        public void ConfgInicial()
        {
            txt_IdCadastro.Enabled = false;
            txt_Nome.Enabled = false;
            txt_Idade.Enabled = false;
            txt_Cnpj.Enabled = false;
            cmb_cidade.Enabled = false;
            btn_AdicionarFoto.Enabled = false;
        }

        public void Liberacampos()
        {
            txt_IdCadastro.Enabled = false;
            txt_Nome.Enabled = true;
            txt_Idade.Enabled = true;
            txt_Cnpj.Enabled = true;
            cmb_cidade.Enabled = true;
            btn_AdicionarFoto.Enabled = true;
        }

        public void Limpacampos()
        {
            txt_IdCadastro.Clear();
            txt_Nome.Clear();
            txt_Idade.Clear();
            txt_Cnpj.Clear();
            btn_AdicionarFoto.Enabled = true;
            txt_Pesquisar.Clear();
        }

        private void btn_AdicionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abreimagem = new OpenFileDialog();
            abreimagem.Title = "Foto";
            abreimagem.Filter = "JPG Files|*.jpg";
            abreimagem.InitialDirectory = @"C:\";
            abreimagem.ShowDialog();
            ptb_Foto.Image = Image.FromFile(abreimagem.FileName);

            Image img = ptb_Foto.Image;

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Close();
                byteArray = stream.ToArray();
            }
        }
    }
}