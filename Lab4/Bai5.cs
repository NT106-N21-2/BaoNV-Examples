using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class Bai5 : Form
	{
		public Bai5()
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

		class User
		{
			[JsonPropertyName("id")]
			public int Id { get; set; }
			[JsonPropertyName("email")]
			public string Email { get; set; }
			[JsonPropertyName("first_name")]
			public string FirstName { get; set; }
			[JsonPropertyName("last_name")]
			public string LastName { get; set; }
			[JsonPropertyName("avatar")]
			public string Avatar { get; set; }
		}

		class UserPagination
		{
			[JsonPropertyName("page")]
			public int Page { get; set; }
			[JsonPropertyName("per_page")]
			public int PerPage { get; set; }
			[JsonPropertyName("total")]
			public int Total { get; set; }
			[JsonPropertyName("total_pages")]
			public int TotalPages { get; set; }
			[JsonPropertyName("data")]
			public List<User> Data { get; set; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var response = getHTML("https://reqres.in/api/users?page=1");
			var data = JsonSerializer.Deserialize<UserPagination>(response);

			var total = data.Total;
			foreach (var item in data.Data)
			{
				Label lbName = new Label();
				lbName.Text = item.FirstName + " " + item.LastName;
				lbName.Location = new Point(0, item.Id * 100);
				panel1.Controls.Add(lbName);
			}
		}
	}
}
