using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Net.Pop3;

namespace EmailClient
{
	public partial class GetEmail : Form
	{
		public GetEmail()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var client = new ImapClient();
			var popClient = new Pop3Client();
			client.Connect("imap.gmail.com", 993, true); // imap host, port, use ssl.
			client.Authenticate(tbUsername.Text, tbPassword.Text); // gmail accout, app password.
			
			var inbox = client.Inbox;
			inbox.Open(FolderAccess.ReadOnly);

			for (int i = inbox.Count - 1; i >= inbox.Count-1-10 ; i--)
			{
				var message = inbox.GetMessage(i);
			}
		}
	}
}
