using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmailClient
{
	public partial class SendMail : Form
	{
		public SendMail()
		{
			InitializeComponent();
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			var smtpClient = new SmtpClient();
			smtpClient.Connect("smtp.gmail.com", 465, true);
			try
			{
				smtpClient.Authenticate("nvbao4566@gmail.com", "vyquzpllvhohenjo");
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Test test", "nvbao4566@gmail.com"));
			message.To.Add(new MailboxAddress("", tbTo.Text));
			message.Subject = "Subject";
			message.Body = new TextPart("plain")
			{
				Text = rtbBody.Text
			};

			smtpClient.Send(message);
		}
	}
}
