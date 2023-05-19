namespace EmailClient
{
	partial class SendMail
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbTo = new TextBox();
			btnSend = new Button();
			rtbBody = new RichTextBox();
			SuspendLayout();
			// 
			// tbTo
			// 
			tbTo.Location = new Point(12, 35);
			tbTo.Name = "tbTo";
			tbTo.Size = new Size(695, 23);
			tbTo.TabIndex = 0;
			// 
			// btnSend
			// 
			btnSend.Location = new Point(713, 34);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(75, 23);
			btnSend.TabIndex = 1;
			btnSend.Text = "Send";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// rtbBody
			// 
			rtbBody.Location = new Point(12, 64);
			rtbBody.Name = "rtbBody";
			rtbBody.Size = new Size(776, 374);
			rtbBody.TabIndex = 2;
			rtbBody.Text = "";
			// 
			// SendMail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(rtbBody);
			Controls.Add(btnSend);
			Controls.Add(tbTo);
			Name = "SendMail";
			Text = "SendMail";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbTo;
		private Button btnSend;
		private RichTextBox rtbBody;
	}
}