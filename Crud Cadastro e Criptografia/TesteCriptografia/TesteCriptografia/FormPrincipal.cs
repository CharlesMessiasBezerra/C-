using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCriptografia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultadoEncriptacao.Text =
                    CriptografiaHelper.Encriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        txtTextoAEncriptar.Text);
            }
            catch (Exception ex)
            {
                txtResultadoEncriptacao.Text =
                    "Erro: " + ex.Message;
            }
        }

        private void btnDecriptar_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultadoDecriptacao.Text =
                    CriptografiaHelper.Decriptar(
                        txtChave.Text,
                        txtVetorInicializacao.Text,
                        txtTextoADecriptar.Text);
            }
            catch (Exception ex)
            {
                txtResultadoDecriptacao.Text =
                    "Erro: " + ex.Message;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}