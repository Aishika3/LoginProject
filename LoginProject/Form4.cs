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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox3.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox2.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox1.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox6.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox7.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox8.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox9.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }
    }
}
