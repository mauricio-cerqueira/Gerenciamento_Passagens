using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGN
{
    public partial class confirmar : Form
    {
        public confirmar()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            main_page f3 = new main_page();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            agendado f5 = new agendado();
            main_page f3 = new main_page();
            this.Hide();
            f5.ShowDialog();
            this.Close();
            f5.Hide();
            f3.ShowDialog();
            f5.Close();

        }
    }
}
