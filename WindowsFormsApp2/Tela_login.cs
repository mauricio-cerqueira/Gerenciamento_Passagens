using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Tela_login : Form
    {
        public Tela_login()
        {
            InitializeComponent();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.UseSystemPasswordChar = true;
        }

    }
}
