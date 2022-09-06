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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            String Name = textBox1.Text;
            label1.Text = Name;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String Name = textBox2.Text;
            label11.Text = Name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label11.Text = "";
            label12.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox3.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox4.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox10.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox11.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox12.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox13.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form14? frm = new Form14(textBox14.Text);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
