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
    public partial class Server : Form
    {

        TcpListener tcpListener;
        IPEndPoint ipepServer;
        TcpClient tcpClient;
        Thread acceptConnection;
        Thread receiveMessage;
        Socket client;
        public Server(int port)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            numericUpDown1.Value = port;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Listen")
            {
                ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), (int)numericUpDown1.Value);
                tcpListener = new TcpListener(ipepServer);
                tcpListener.Start();
                button1.Text = "Stop";
                StartUnsafeThread();
            } else
            {
                tcpListener.Stop();
                tcpClient.Close();
                tcpClient.Dispose();
                client.Close();
                acceptConnection.Abort();
                receiveMessage.Abort();
                button1.Text = "Listen";
                numericUpDown1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                listView1.Items.Clear();
            }
        }

        private void AddConnectionDetail(string[] row)
        {
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void StartUnsafeThread()
        {
            numericUpDown1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;

            acceptConnection = new Thread(new ThreadStart(AcceptConnection));
            acceptConnection.Start();
        }

        private void ReceiveMessage(Socket client)
        {
            while (client.Connected)
            {
                try
                {
                    byte[] recv = new byte[1024];
                    client.Receive(recv);
                    string mes = Encoding.UTF8.GetString(recv).Replace("\0", "").Replace("\r", "").Replace("\n", "");
                    if (!String.IsNullOrWhiteSpace(mes))
                    {
                        richTextBox1.Text += mes + "\n";
                    }
                    
                }
                catch
                {

                }
            }
        }

        private void AcceptConnection()
        {
            while (true)
            {
                try
                {
                    tcpClient = tcpListener.AcceptTcpClient();

                    client = tcpClient.Client;
                    string[] clientInfo = { ((IPEndPoint)client.RemoteEndPoint).Address.ToString(), ((IPEndPoint)client.RemoteEndPoint).Port.ToString() };
                    AddConnectionDetail(clientInfo);
                    receiveMessage = new Thread(() => ReceiveMessage(client));
                    receiveMessage.Start();
                }
                catch
                {

                }
            }
        }
    }
}
