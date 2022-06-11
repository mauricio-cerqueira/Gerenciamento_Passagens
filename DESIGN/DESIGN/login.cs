using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGN
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txt_senha.UseSystemPasswordChar = true;
        }
        
        // Abre form para registro
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            registrar f2 = new registrar();
            this.Hide();
            f2.ShowDialog();
            this.Close();
            
        }
        
        // abre form principal
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ConexaoBanco.Login(txt_cpf.Text, txt_senha.Text) == true)
            {
                main_page f3 = new main_page();
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
            
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
