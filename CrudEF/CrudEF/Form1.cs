using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudEF.Models;

namespace CrudEF
{
    public partial class CrudCharles : Form
    {
        #region **  Construtor **
        public CrudCharles()
        {
            InitializeComponent();
        }
        #endregion

        #region **  Propriedades  **

        public int idcod { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }
        public string sexo { get; private set; }
        public int bairro { get; private set; }
        public string apelido { get; private set; }
        public int qualFiltroUSar { get; private set; }
        public int filtro { get; private set; }
        private int ConfigSalvar ;

        private readonly BDEstudoContext _contexto = new BDEstudoContext();
        
       #endregion

       #region **  Eventos Form **

        private void CrudCharles_Load(object sender, EventArgs e)
        {
            configInicial();
            carregaGrid();
            SetaFilto();
            
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            SetaFilto();
            configpesquisar();

            Cliente cliente = null;

            // passar queryble
            if (rbCod.Checked)
            {

                int num = int.Parse(txt_pesquisa.Text);

                cliente = _contexto.Clientes.Include("Bairro").FirstOrDefault(p => p.pk_intCod == num);

            }
            else if (rbApelido.Checked)
            {
                cliente = _contexto.Clientes.FirstOrDefault(p => p.StrApelido == txt_pesquisa.Text);

            }
            else if (rbNome.Checked)
            {
                cliente = _contexto.Clientes.FirstOrDefault(p => p.strNOME == txt_pesquisa.Text);
                
            }

            
            if (cliente != null) txt_cod.Text = Convert.ToString( cliente.pk_intCod);
            if (cliente != null) txt_nome.Text = Convert.ToString(cliente.strNOME);
            if (cliente != null) txt_apelido.Text = Convert.ToString(cliente.StrApelido);
            if (cliente != null) txt_idade.Text = Convert.ToString(cliente.intIdade);
            if (cliente != null) txt_sexo.Text = Convert.ToString(cliente.strSexo);
            if (cliente != null) txt_bairro.Text = Convert.ToString(cliente.fk_intBairro);
           
        }
    
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            configAdiciona();
            ConfigSalvar = 1;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            configEditar();
            ConfigSalvar = 2;

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            configInicial();
            idcod = int.Parse(txt_cod.Text);

            Cliente deleteCliente = _contexto.Clientes.First(i => i.pk_intCod == this.idcod);

            _contexto.Clientes.Remove(deleteCliente);
            _contexto.SaveChanges();
            carregaGrid();
            
            MessageBox.Show("Cadastro removido com sucesso");
            LimpaCampo();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // dados
            
            nome = txt_nome.Text;
            idade = int.Parse(txt_idade.Text);
            sexo = txt_sexo.Text;
            bairro = int.Parse(txt_bairro.Text);
            apelido = txt_apelido.Text;

            if (ConfigSalvar == 1)
            {
                CadastraUsuario();                
            }
            else if (ConfigSalvar == 2)
            {
                EditaUsuario();
            }
            else
            {
                MessageBox.Show("erro ao Salvar Verifique");
            }
                        
            LimpaCampo();
            carregaGrid();
            configInicial();            
        }

        #endregion

        #region **  configuracoes dos campos **

            public void configInicial()
            {
                txt_cod.Enabled = false;
                txt_nome.Enabled = false;
                txt_idade.Enabled = false;
                txt_sexo.Enabled = false;
                txt_bairro.Enabled = false;
                txt_apelido.Enabled = false;
                btn_Salvar.Enabled = false;
                btn_editar.Enabled = false;
                btn_excluir.Enabled = false;
            }
                   
            public void configpesquisar()
            {
                txt_cod.Enabled = false;
                txt_nome.Enabled = false;
                txt_idade.Enabled = false;
                txt_sexo.Enabled = false;
                txt_bairro.Enabled = false;
                txt_apelido.Enabled = false;
                btn_Salvar.Enabled = false;                
                btn_editar.Enabled = true;
                btn_excluir.Enabled = true;
                btn_adicionar.Enabled = true;
            }

            public void configAdiciona()
            {
                txt_cod.Enabled = false;
                txt_nome.Enabled = true;
                txt_idade.Enabled = true;
                txt_sexo.Enabled = true;
                txt_bairro.Enabled = true;
                txt_apelido.Enabled = true;
                btn_adicionar.Enabled = true;
                btn_Salvar.Enabled = true;
                btn_editar.Enabled = false;
                btn_excluir.Enabled = false;

            }

            public void configEditar()
            {
                txt_cod.Enabled = false;
                txt_nome.Enabled = true;
                txt_idade.Enabled = true;
                txt_sexo.Enabled = true;
                txt_bairro.Enabled = true;
                txt_apelido.Enabled = true;
                btn_adicionar.Enabled = true;
                btn_Salvar.Enabled = true;
                btn_editar.Enabled = true;
                btn_excluir.Enabled = true;

            }

            public void LimpaCampo()
            {
                txt_cod.Text = null;
                txt_nome.Text = null;
                txt_idade.Text = null;
                txt_sexo.Text = null;
                txt_bairro.Text = null;
                txt_apelido.Text = null;
                txt_pesquisa.Text = null;

            }

        #endregion

        #region **  Metodos **

        private void SetaFilto()
        {
            if (rbCod.Checked)
            {
                filtro = 1;
            }
            else if(rbApelido.Checked)
            {
                filtro = 2;
            }
            else if(rbNome.Checked)
            {
                filtro = 3;
            }
            
        }

        private void EditaUsuario()
        {
            this.idcod = int.Parse(txt_cod.Text);

            Cliente readCliente = _contexto.Clientes.First(i => i.pk_intCod == this.idcod);
            
            readCliente.strNOME = this.nome;
            readCliente.fk_intBairro = this.bairro;
            readCliente.intIdade = this.idade;
            readCliente.strSexo = this.sexo;
            _contexto.SaveChanges();
            
            MessageBox.Show("Dados atualizado com sucesso");
        }

        private void CadastraUsuario()
        {
            Cliente newCliente = new Cliente() { fk_intBairro = this.bairro, strNOME = this.nome, intIdade = this.idade, strSexo = this.sexo };
            _contexto.Clientes.Add(newCliente);
            _contexto.SaveChanges();
            carregaGrid();

            MessageBox.Show("Usuário Inserido com Sucesso inseridos com sucesso");
        }

        private void carregaGrid()
        {
            IEnumerable<vw_Cliente> listmovimentos = from i in _contexto.ClientesVwClientes select i;
            dtView.DataSource = listmovimentos.ToList();
            
        }

        #endregion
    }
}
