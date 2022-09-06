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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        public Form14(string value)
        {
            InitializeComponent();
            //label2.Text = value;
            this.Value= "Data received "+value;
        }
        public string Value { get; set; }

        private void Form14_Load(object sender, EventArgs e)
        {
            label2.Text = Value;
        }
    }
}
