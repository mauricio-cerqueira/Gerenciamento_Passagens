﻿using System;
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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmar f4 = new confirmar();
            this.Hide();
            f4.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            historico f6 = new historico();
            this.Hide();
            f6.ShowDialog();
            this.Close();
        }
    }
}
