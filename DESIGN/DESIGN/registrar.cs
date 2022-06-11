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
    public partial class registrar : Form
    {
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
            login_form f1 = new login_form();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
