﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProject
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5? frm = new Form5();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12? frm = new Form12();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
