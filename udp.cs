using System.Net.Sockets;
using System.Text;

namespace UDP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Form2 form = new Form2();
			form.Show();
			tbHost.Text = "127.0.0.1";
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			UdpClient udpClient = new UdpClient();
			Byte[] sendBytes = Encoding.UTF8.GetBytes("Lập trình mạng căn bản");

			udpClient.Send(sendBytes, sendBytes.Length, tbHost.Text, 8080);

            #udp server
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}