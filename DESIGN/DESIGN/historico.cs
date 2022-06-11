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
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main_page f3 = new main_page();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    }
}
