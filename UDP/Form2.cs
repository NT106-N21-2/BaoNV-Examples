using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
			Thread udpServerThread = new Thread(new ThreadStart(ServerThread));
			udpServerThread.Start();
			udpServerThread.IsBackground = true;
		}

		public void ServerThread()
		{
			UdpClient udpClient = new UdpClient(8080);
			IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

			while (true)
			{
				Byte[] receivedBytes = udpClient.Receive(ref remoteEndPoint);

				string mesg = Encoding.UTF8.GetString(receivedBytes);

				richTextBox1.Text += mesg + "\n";
			}
		}
	}
}
