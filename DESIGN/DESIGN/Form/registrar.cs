using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DESIGN.Data;
using System.Windows.Forms;

namespace DESIGN
{
    public partial class registrar : Form
    {
        ConexaoBanco conexao = new ConexaoBanco();
        FuncoesPassagem fnPassagem = new FuncoesPassagem();

        public registrar()
        {
            InitializeComponent();
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            login_form f1 = new login_form();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            lblNome.Text = "";
            lblSobrenome.Text = "";
            lblCPF.Text = "";
            lblTelefone.Text = "";
            lblSenha.Text = "";
            fnPassagem.RegistraPassageiro(txtCPF.Text, txtNome.Text, txtSobrenome.Text, txtSenha.Text, txtTelefone.Text);
            txtCPF.Text = "";
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtSenha.Text = "";
            txtTelefone.Text = "";

            login_form f1 = new login_form();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
