using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3? frm = new Form3();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4? frm2 = new Form4();
            this.Hide();
            frm2.ShowDialog();
            frm2 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11? frm = new Form11();
            this.Hide();
            frm.ShowDialog();
            frm = null;
            this.Show();
        }
    }
}
