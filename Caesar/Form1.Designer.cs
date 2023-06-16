using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Caesar
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
			rtbPlaintext = new RichTextBox();
			groupBox1 = new GroupBox();
			nbShift = new NumericUpDown();
			btnDecrypt = new Button();
			btnEncrypt = new Button();
			label2 = new Label();
			label3 = new Label();
			label1 = new Label();
			rtbCiphertext = new RichTextBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nbShift).BeginInit();
			SuspendLayout();
			// 
			// rtbPlaintext
			// 
			rtbPlaintext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			rtbPlaintext.Location = new Point(68, 55);
			rtbPlaintext.Name = "rtbPlaintext";
			rtbPlaintext.Size = new Size(701, 96);
			rtbPlaintext.TabIndex = 0;
			rtbPlaintext.Text = "";
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(nbShift);
			groupBox1.Controls.Add(btnDecrypt);
			groupBox1.Controls.Add(btnEncrypt);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(rtbCiphertext);
			groupBox1.Controls.Add(rtbPlaintext);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(776, 289);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Caesar";
			// 
			// nbShift
			// 
			nbShift.Location = new Point(68, 26);
			nbShift.Name = "nbShift";
			nbShift.Size = new Size(120, 23);
			nbShift.TabIndex = 4;
			// 
			// btnDecrypt
			// 
			btnDecrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnDecrypt.Location = new Point(407, 157);
			btnDecrypt.Name = "btnDecrypt";
			btnDecrypt.Size = new Size(75, 23);
			btnDecrypt.TabIndex = 2;
			btnDecrypt.Text = "Decrypt";
			btnDecrypt.UseVisualStyleBackColor = true;
			btnDecrypt.Click += btnDecrypt_Click;
			// 
			// btnEncrypt
			// 
			btnEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			btnEncrypt.Location = new Point(283, 157);
			btnEncrypt.Name = "btnEncrypt";
			btnEncrypt.Size = new Size(75, 23);
			btnEncrypt.TabIndex = 2;
			btnEncrypt.Text = "Encrypt";
			btnEncrypt.UseVisualStyleBackColor = true;
			btnEncrypt.Click += btnEncrypt_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(5, 186);
			label2.Name = "label2";
			label2.Size = new Size(62, 15);
			label2.TabIndex = 1;
			label2.Text = "Ciphertext";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom;
			label3.AutoSize = true;
			label3.Location = new Point(6, 34);
			label3.Name = "label3";
			label3.Size = new Size(31, 15);
			label3.TabIndex = 1;
			label3.Text = "Shift";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(5, 55);
			label1.Name = "label1";
			label1.Size = new Size(53, 15);
			label1.TabIndex = 1;
			label1.Text = "Plaintext";
			// 
			// rtbCiphertext
			// 
			rtbCiphertext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			rtbCiphertext.Location = new Point(68, 186);
			rtbCiphertext.Name = "rtbCiphertext";
			rtbCiphertext.Size = new Size(701, 96);
			rtbCiphertext.TabIndex = 0;
			rtbCiphertext.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 313);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nbShift).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox rtbPlaintext;
		private GroupBox groupBox1;
		private Button btnDecrypt;
		private Button btnEncrypt;
		private Label label2;
		private Label label3;
		private Label label1;
		private RichTextBox rtbCiphertext;
		private NumericUpDown nbShift;
	}
}