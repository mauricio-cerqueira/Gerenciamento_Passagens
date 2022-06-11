using GerenciamentoPassagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoPassagens
{
    public partial class Form2 : Form
    {
        ConexaoBanco conexao = new ConexaoBanco();

        public Form2()
        {
            InitializeComponent();
            ConexaoBanco.DBConnect();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ConexaoBanco.Insert_Usuario(txtNome.Text, txtSobrenome.Text, txtCPF.Text, txtTelefone.Text, txtSenha.Text);
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
            txtSenha.Text = "";
        }
    }
}
