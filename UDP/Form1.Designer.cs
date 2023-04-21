namespace UDP
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tbHost = new TextBox();
			btnSend = new Button();
			SuspendLayout();
			// 
			// tbHost
			// 
			tbHost.Location = new Point(12, 12);
			tbHost.Name = "tbHost";
			tbHost.Size = new Size(401, 23);
			tbHost.TabIndex = 0;
			// 
			// btnSend
			// 
			btnSend.Location = new Point(173, 41);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(75, 23);
			btnSend.TabIndex = 1;
			btnSend.Text = "Send";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(425, 75);
			Controls.Add(btnSend);
			Controls.Add(tbHost);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbHost;
		private Button btnSend;
	}
}