using SimpleTCP;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        private void Form13_Load(object sender, EventArgs e)
        {
          server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }

        private void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {
            TxtStatus.Invoke((MethodInvoker)delegate ()
            {
                TxtStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("You Said:{0}", e.MessageString));
            }
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtStatus.Text += "Server starting...";
            System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(txtHost.Text));
            server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }
    }
}
