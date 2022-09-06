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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox2.Text;
            int m = Convert.ToInt32(n);
            String str = textBox1.Text; ;
            for(int i=1;i<m;i++)
            {
                str = str +" " + textBox1.Text;
            }
            Form14? frm = new Form14(str);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string n = textBox5.Text;
            int m = Convert.ToInt32(n);
            String str = textBox3.Text; ;
            for (int i = 1; i < m; i++)
            {
                str = str + " " + textBox3.Text;
            }
            Form14? frm = new Form14(str);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string n = textBox4.Text;
            int m = Convert.ToInt32(n);
            String str = textBox7.Text; ;
            for (int i = 1; i < m; i++)
            {
                str = str + " " + textBox7.Text;
            }
            Form14? frm = new Form14(str);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n = textBox8.Text;
            int m = Convert.ToInt32(n);
            String str = textBox6.Text; ;
            for (int i = 1; i < m; i++)
            {
                str = str + " " + textBox6.Text;
            }
            Form14? frm = new Form14(str);
            frm.ShowDialog();
            frm = null;
            this.Show();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
