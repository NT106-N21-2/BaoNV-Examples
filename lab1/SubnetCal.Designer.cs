using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab1
{
	partial class SubnetCal
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
			groupBox1 = new System.Windows.Forms.GroupBox();
			button1 = new System.Windows.Forms.Button();
			label4 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			lbSubnetMask = new System.Windows.Forms.Label();
			lbNetworkAddress = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			textBox1 = new System.Windows.Forms.TextBox();
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			networkAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			firstAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			lastAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(numericUpDown1);
			groupBox1.Controls.Add(lbSubnetMask);
			groupBox1.Controls.Add(lbNetworkAddress);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(253, 162);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			// 
			// button1
			// 
			button1.Location = new System.Drawing.Point(172, 133);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 8;
			button1.Text = "Tính";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(154, 23);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(77, 15);
			label4.TabIndex = 7;
			label4.Text = "Số mạng con";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 23);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(35, 15);
			label1.TabIndex = 6;
			label1.Text = "Input";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new System.Drawing.Point(154, 45);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new System.Drawing.Size(93, 23);
			numericUpDown1.TabIndex = 1;
			// 
			// lbSubnetMask
			// 
			lbSubnetMask.AutoSize = true;
			lbSubnetMask.Location = new System.Drawing.Point(110, 106);
			lbSubnetMask.Name = "lbSubnetMask";
			lbSubnetMask.Size = new System.Drawing.Size(38, 15);
			lbSubnetMask.TabIndex = 5;
			lbSubnetMask.Text = "label4";
			// 
			// lbNetworkAddress
			// 
			lbNetworkAddress.AutoSize = true;
			lbNetworkAddress.Location = new System.Drawing.Point(110, 82);
			lbNetworkAddress.Name = "lbNetworkAddress";
			lbNetworkAddress.Size = new System.Drawing.Size(38, 15);
			lbNetworkAddress.TabIndex = 4;
			lbNetworkAddress.Text = "label1";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 106);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(78, 15);
			label3.TabIndex = 3;
			label3.Text = "Subnet mask:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(6, 82);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(98, 15);
			label2.TabIndex = 2;
			label2.Text = "Network address:";
			// 
			// textBox1
			// 
			textBox1.Location = new System.Drawing.Point(6, 45);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(142, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new System.Drawing.Point(12, 180);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new System.Drawing.Size(253, 258);
			richTextBox1.TabIndex = 1;
			richTextBox1.Text = "";
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stt, networkAddress, firstAddress, lastAddress });
			dataGridView1.Location = new System.Drawing.Point(271, 24);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new System.Drawing.Size(604, 414);
			dataGridView1.TabIndex = 2;
			// 
			// stt
			// 
			stt.HeaderText = "STT";
			stt.Name = "stt";
			// 
			// networkAddress
			// 
			networkAddress.HeaderText = "Network Address";
			networkAddress.Name = "networkAddress";
			networkAddress.Width = 150;
			// 
			// firstAddress
			// 
			firstAddress.HeaderText = "Địa chỉ đầu";
			firstAddress.Name = "firstAddress";
			firstAddress.Width = 150;
			// 
			// lastAddress
			// 
			lastAddress.HeaderText = "Địa chỉ cuối";
			lastAddress.Name = "lastAddress";
			lastAddress.Width = 150;
			// 
			// SubnetCal
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(887, 450);
			Controls.Add(dataGridView1);
			Controls.Add(richTextBox1);
			Controls.Add(groupBox1);
			Name = "SubnetCal";
			Text = "SubnetCal";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbSubnetMask;
		private System.Windows.Forms.Label lbNetworkAddress;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn stt;
		private System.Windows.Forms.DataGridViewTextBoxColumn networkAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastAddress;
	}
}