using System.Net;
using System.Security.Policy;

namespace Lab4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string getHTML(string szUrl)
		{
			// Create a request for the URL.
			WebRequest request = WebRequest.Create(szUrl);
			// Get the response. 
			WebResponse response = request.GetResponse();
			// Get the stream containing content returned by the server. 
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access. 
			StreamReader reader = new StreamReader(dataStream);
			// Read the content. 
			string responseFromServer = reader.ReadToEnd();
			// Close the response. 
			response.Close();
			return responseFromServer;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			webView21.Source = new Uri(textBox1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var html = getHTML(textBox1.Text);
			ViewSource viewSource = new ViewSource(html);
			viewSource.Show();
		}
	}
}