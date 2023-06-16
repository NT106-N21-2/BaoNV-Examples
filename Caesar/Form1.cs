namespace Caesar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		readonly string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			string plainText = rtbPlaintext.Text;
			string cipherText = "";
			int shift = (int)nbShift.Value;

			for (int i = 0; i < plainText.Length; i++)
			{
				bool isLower = char.IsLower(plainText[i]);
				int index = alphabet.IndexOf(char.ToUpper(plainText[i]));
				var newIndex = (index + shift) % alphabet.Length;
				cipherText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
			}
			rtbCiphertext.Text = cipherText;
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			string cipherText = rtbCiphertext.Text;
			string plainText = "";
			int shift = (int)nbShift.Value;

			for (int i = 0; i < cipherText.Length; i++)
			{
				bool isLower = char.IsLower(cipherText[i]);
				int index = alphabet.IndexOf(char.ToUpper(cipherText[i]));
				var newIndex = index - shift >= 0 ? index - shift : alphabet.Length - index - shift;
				plainText += isLower ? char.ToLower(alphabet[newIndex]) : alphabet[newIndex];
			}
			rtbPlaintext.Text = plainText;
		}
	}
}