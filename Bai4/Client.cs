using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Client : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;
        bool connected = false;

        public Client()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, (int)numericUpDown1.Value);
            Thread t = new Thread(new ThreadStart(CheckConnection));
            t.Start();

            tcpClient.Connect(ipEndPoint);
            if (tcpClient.Connected)
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }  
        }

        private void SendMessage(string mes)
        {
            try
            {
                ns = tcpClient.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(mes);
                ns.Write(data, 0, data.Length);
            }
            catch {}
        }

        private void Reconnect()
        {
            IPAddress ipAddress1 = IPAddress.Parse(textBox1.Text);
            IPEndPoint ipEndPoint1 = new IPEndPoint(ipAddress1, (int)numericUpDown1.Value);
            IPAddress ipAddress2 = IPAddress.Parse(textBox3.Text);
            IPEndPoint ipEndPoint2 = new IPEndPoint(ipAddress2, (int)numericUpDown2.Value);

            if (!connected)
            {
                Random rnd = new Random();
                int server = rnd.Next(1, 3);
                if (server == 1)
                {
                    tcpClient = new TcpClient();
                    tcpClient.Connect(ipEndPoint1);
                } else
                {
                    tcpClient = new TcpClient();
                    tcpClient.Connect(ipEndPoint2);
                }
            }
        }

        private void CheckConnection()
        {
            while (true)
            {
                try
                {
                    SendMessage("\n\r");
                    if (tcpClient.Connected)
                    {
                        connected = true;
                        label6.Text = "Trạng thái: Đã kết nối";
                    }
                    else
                    {
                        connected = false;
                        tcpClient.Close();
                        tcpClient.Dispose();
                        label6.Text = "Trạng thái: Mất kết nối";
                        Reconnect();
                    }
                } catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMessage(textBox2.Text);
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            tcpClient.Close();
        }
    }
}
