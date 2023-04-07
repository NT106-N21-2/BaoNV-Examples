using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab1
{
	partial class PetrolCalculator
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
			cbVehicle = new System.Windows.Forms.ComboBox();
			cbFuel = new System.Windows.Forms.ComboBox();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			btnCalculate = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// cbVehicle
			// 
			cbVehicle.FormattingEnabled = true;
			cbVehicle.Location = new System.Drawing.Point(108, 12);
			cbVehicle.Name = "cbVehicle";
			cbVehicle.Size = new System.Drawing.Size(121, 23);
			cbVehicle.TabIndex = 0;
			cbVehicle.SelectedIndexChanged += cbVehicle_SelectedIndexChanged;
			// 
			// cbFuel
			// 
			cbFuel.FormattingEnabled = true;
			cbFuel.Location = new System.Drawing.Point(108, 41);
			cbFuel.Name = "cbFuel";
			cbFuel.Size = new System.Drawing.Size(121, 23);
			cbFuel.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 20);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(51, 15);
			label1.TabIndex = 2;
			label1.Text = "Chọn xe";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(12, 49);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(84, 15);
			label2.TabIndex = 3;
			label2.Text = "Loại nhiên liệu";
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new System.Drawing.Point(235, 11);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new System.Drawing.Size(75, 53);
			btnCalculate.TabIndex = 4;
			btnCalculate.Text = "Tính";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += btnCalculate_Click;
			// 
			// PetrolCalculator
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(318, 79);
			Controls.Add(btnCalculate);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cbFuel);
			Controls.Add(cbVehicle);
			Name = "PetrolCalculator";
			Text = "PetrolCalculator";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ComboBox cbVehicle;
		private System.Windows.Forms.ComboBox cbFuel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCalculate;
	}
}