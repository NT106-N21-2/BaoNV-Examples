namespace Telnet
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
			btnListenTelnet = new Button();
			richTextBox1 = new RichTextBox();
			SuspendLayout();
			// 
			// btnListenTelnet
			// 
			btnListenTelnet.Location = new Point(346, 12);
			btnListenTelnet.Name = "btnListenTelnet";
			btnListenTelnet.Size = new Size(75, 23);
			btnListenTelnet.TabIndex = 0;
			btnListenTelnet.Text = "Listen";
			btnListenTelnet.UseVisualStyleBackColor = true;
			btnListenTelnet.Click += btnListenTelnet_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			richTextBox1.Location = new Point(12, 42);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(409, 396);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(433, 450);
			Controls.Add(richTextBox1);
			Controls.Add(btnListenTelnet);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button btnListenTelnet;
		private RichTextBox richTextBox1;
	}
}