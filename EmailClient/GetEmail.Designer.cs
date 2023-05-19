namespace EmailClient
{
	partial class GetEmail
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
			tbUsername = new TextBox();
			label1 = new Label();
			label2 = new Label();
			tbPassword = new TextBox();
			btnLogin = new Button();
			SuspendLayout();
			// 
			// tbUsername
			// 
			tbUsername.Location = new Point(121, 12);
			tbUsername.Name = "tbUsername";
			tbUsername.Size = new Size(203, 23);
			tbUsername.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 20);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 1;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 54);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(121, 46);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(203, 23);
			tbPassword.TabIndex = 0;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(330, 12);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 57);
			btnLogin.TabIndex = 2;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// GetEmail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLogin);
			Controls.Add(label2);
			Controls.Add(tbPassword);
			Controls.Add(label1);
			Controls.Add(tbUsername);
			Name = "GetEmail";
			Text = "GetEmail";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tbUsername;
		private Label label1;
		private Label label2;
		private TextBox tbPassword;
		private Button btnLogin;
	}
}