using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server server = new Server(8080);
            server.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Server server = new Server(8081);
            server.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
