using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Telnet
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}

		private void btnListenTelnet_Click(object sender, EventArgs e)
		{
			Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
			serverThread.Start();
			serverThread.IsBackground = true;
		}

		private void StartUnsafeThread()
		{
			int bytesReceievd = 0;
			byte[] recv = new byte[1];

			Socket clientSocket;
			Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
			listenerSocket.Bind(ipEndPoint);
			listenerSocket.Listen(-1);

			clientSocket = listenerSocket.Accept();
			while (clientSocket.Connected)
			{
				string text = "";
				do
				{
					bytesReceievd = clientSocket.Receive(recv);
					text += Encoding.ASCII.GetString(recv);
				} while (text[text.Length - 1] != '\n');
				richTextBox1.Text += text + "\n";
			}
			listenerSocket.Close();
		}
	}
}