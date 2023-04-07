using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
	public partial class SubnetCal : Form
	{
		public SubnetCal()
		{
			InitializeComponent();
			lbSubnetMask.Text = "";
			lbNetworkAddress.Text = "";
			textBox1.Text = "192.168.100.0/24";
			numericUpDown1.Value = 5;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string input = textBox1.Text;
			if (input.Split("/").Length == 2)
			{
				string networkAddress = input.Split("/")[0];
				string subnetMask = input.Split("/")[1];
				lbNetworkAddress.Text = networkAddress;
				lbSubnetMask.Text = subnetMask;
			}
		}

		static IPAddress IncrementIPAddress(IPAddress address)
		{
			uint ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
			ipAddress += 1;
			return new IPAddress(BitConverter.GetBytes(ipAddress));
		}

		static IPAddress DecrementIPAddress(IPAddress address)
		{
			uint ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
			ipAddress -= 1;
			return new IPAddress(BitConverter.GetBytes(ipAddress));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			string originalSubnet = lbNetworkAddress.Text;
			int subnetMaskBits = int.Parse(lbSubnetMask.Text);
			int subnets = (int)numericUpDown1.Value;


			byte[] subnetBytes = IPAddress.Parse(originalSubnet).GetAddressBytes();
			uint originalSubnetBinary = ((uint)subnetBytes[0] << 24) +
										((uint)subnetBytes[1] << 16) +
										((uint)subnetBytes[2] << 8) +
										(uint)subnetBytes[3];

			int newSubnetMaskBits = (int)Math.Ceiling(Math.Log(subnets, 2)) + subnetMaskBits;
			int numSubnets = 1 << (newSubnetMaskBits - subnetMaskBits);
			int hostsPerSubnet = 1 << (32 - newSubnetMaskBits);
			IPAddress mask = new IPAddress(BitConverter.GetBytes(~0u << (32 - newSubnetMaskBits)).Reverse().ToArray());

			for (int i = 0; i < numSubnets; i++)
			{
				uint newSubnetBinary = originalSubnetBinary + ((uint)i * (uint)hostsPerSubnet);
				byte[] newSubnetBytes = new byte[4];
				newSubnetBytes[0] = (byte)(newSubnetBinary >> 24);
				newSubnetBytes[1] = (byte)(newSubnetBinary >> 16);
				newSubnetBytes[2] = (byte)(newSubnetBinary >> 8);
				newSubnetBytes[3] = (byte)newSubnetBinary;


				IPAddress firstAddress = new IPAddress(newSubnetBytes);
				IPAddress lastAddress = new IPAddress(newSubnetBytes);
				string newSubnetString = new IPAddress(newSubnetBytes).ToString();

				for (int j = 0; i < 32 - mask.GetAddressBytes().Length * 8; i++)
				{
					firstAddress = IncrementIPAddress(firstAddress);
				}

				for (int j = 0; i < 32 - mask.GetAddressBytes().Length * 8; i++)
				{
					lastAddress = DecrementIPAddress(lastAddress);
				}

				string[] row = {
					i.ToString(),
					newSubnetString
				};
				dataGridView1.Rows.Add(row);
			}
		}
	}
}
