using System.Runtime.Serialization.Formatters.Binary;

namespace lab2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text File|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
				StreamReader reader = new StreamReader(fileStream);
				int lineCount = 0;
				while (reader.ReadLine() != null)
				{
					lineCount++;
				}
				fileStream.Close();
				MessageBox.Show(String.Format("There are {0} lines in {1}", lineCount.ToString(), openFileDialog.FileName));
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text File|*.txt";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				int[] myArray = new int[1000];
				for (int i = 0; i < myArray.Length; i++)
				{
					myArray[i] = i;
					binaryWriter.Write(myArray[i]);
				}
				binaryWriter.Close();
				fileStream.Close();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text File|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;

				FileInfo fileInfo = new FileInfo(filePath);
			}
		}

		[Serializable]
		class Student
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Phone { get; set; }
			public double Course1 { get; set; }
		}

		private void button4_Click(object sender, EventArgs e)
		{
			List<Student> students = new List<Student>(){
				new Student(){ Id = 1, Name="Nguyen Van B", Course1=1},
				new Student(){ Id = 2, Name="Nguyen Van C", Course1=1},
				new Student(){ Id = 3, Name="Nguyen Van D", Course1=1},
				new Student(){ Id = 4, Name="Nguyen Van E", Course1=1},
			};

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				FileStream fileStream = File.Create(filePath);

				binaryFormatter.Serialize(fileStream, students);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				string filePath = openFileDialog.FileName;
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				FileStream fileStream = File.OpenRead(filePath);
				List<Student> students = binaryFormatter.Deserialize(fileStream) as List<Student>;
				foreach (var student in students)
				{
					student.Name
				}
			}
		}
	}
}