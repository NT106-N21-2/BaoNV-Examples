using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
	public partial class PetrolCalculator : Form
	{
		class Fuel
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public double Price { get; set; }
		}

		class Vehicle
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public double FuelConsumtion { get; set; }
			public double FuelTankCapacity { get; set; }
			public List<Fuel> FuelTypes { get; set; }
		}

		public PetrolCalculator()
		{
			InitializeComponent();
			List<Fuel> fuels = new List<Fuel>(){
				new Fuel(){ Id=0, Name="Xăng RON 95-III", Price=26.830 },
				new Fuel(){ Id=1, Name="Xăng E5 RON 92-II", Price=26.070 },
				new Fuel(){ Id=2, Name="Dầu DO 0,05S-II", Price=22.310 },
			};
			List<Vehicle> vehicles = new List<Vehicle>(){
				new Vehicle(){
					Id=0,
					Name="Wave Alpha",
					FuelConsumtion=1.6,
					FuelTankCapacity=3.7,
					FuelTypes=new List<Fuel>(){fuels[0], fuels[1] }
				},
				new Vehicle(){
					Id=1,
					Name="Sirius",
					FuelConsumtion=1.99,
					FuelTankCapacity=3.8,
					FuelTypes=new List<Fuel>(){fuels[0], fuels[1] }
				},
				new Vehicle(){
					Id=3,
					Name="Vision",
					FuelConsumtion=1.87,
					FuelTankCapacity=5.2,
					FuelTypes=new List<Fuel>(){fuels[0], fuels[1] }
				},
				new Vehicle(){
					Id=4,
					Name="Lead",
					FuelConsumtion=2.02,
					FuelTankCapacity=6,
					FuelTypes=new List<Fuel>(){fuels[0]}
				},
				new Vehicle(){
					Id=5,
					Name="Winner",
					FuelConsumtion=1.7,
					FuelTankCapacity=4.5,
					FuelTypes=new List<Fuel>(){fuels[0]}
				},
				new Vehicle(){
					Id=6,
					Name="AirBlade 150",
					FuelConsumtion=2.17,
					FuelTankCapacity=4.4,
					FuelTypes=new List<Fuel>(){fuels[0]}
				},
				new Vehicle(){
					Id=7,
					Name="Xe tải 9 tấn",
					FuelConsumtion=13,
					FuelTankCapacity=70,
					FuelTypes=new List<Fuel>(){fuels[2]}
				},
			};

			cbVehicle.DataSource = vehicles;
			cbVehicle.DisplayMember = "Name";
		}

		private void cbVehicle_SelectedIndexChanged(object sender, EventArgs e)
		{
			Vehicle selectedVehicle = (Vehicle)cbVehicle.SelectedItem;
			if (selectedVehicle != null)
			{
				cbFuel.DataSource = selectedVehicle.FuelTypes;
				cbFuel.DisplayMember = "Name";
			}
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			Vehicle vehicle = (Vehicle)cbVehicle.SelectedItem;
			Fuel fuel = (Fuel)cbFuel.SelectedItem;
			if (vehicle != null && fuel != null)
			{
				double fuelConsumtion = vehicle.FuelConsumtion;
				double fuelTankCapacity = vehicle.FuelTankCapacity;
				double fuelPrice = fuel.Price;

				MessageBox.Show(fuelConsumtion.ToString() + " - " + fuelTankCapacity.ToString() + " - " + fuelPrice.ToString());
				double money = fuelTankCapacity * fuelPrice;
				double distance = fuelTankCapacity * 100 / fuelConsumtion;
				MessageBox.Show(String.Format("Số KM đi được: {0}\nSố tiền: {1}", distance, money));
			}
		}
	}
}
