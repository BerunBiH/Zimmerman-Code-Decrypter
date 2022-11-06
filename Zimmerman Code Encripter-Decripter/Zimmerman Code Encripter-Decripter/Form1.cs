namespace Zimmerman_Code_Encripter_Decripter
{
    public partial class Form1 : Form
    {
        string Zimmerman;
        string[] codeNumber = { "A", "D", "F", "G", "V", "X" };
        string[,] code = new string[6, 6] {{ "B", "2", "E", "5", "R", "L" },
                                              {"I", "9", "N", "A", "1", "C" },
                                              { "3", "D", "4", "F", "6", "G" },
                                              { "7", "H", "8", "J", "0", "K" },
                                              { "M", "O", "P", "Q", "S", "T" },
                                              { "U", "V", "W", "X", "Y", "Z"}};
        string translated;
        public Form1()
        {
            InitializeComponent();
        }
        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            translated = string.Empty;
            richTextBox2.Text = string.Empty;
            if (richTextBox1.Text == string.Empty)
            {
                errorProvider1.SetError(richTextBox1, "Please enter a value");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            Zimmerman = richTextBox1.Text.ToUpper();
            Zimmerman = Zimmerman.Replace(" ", string.Empty);
            var temp1 = Zimmerman.ToCharArray();
            for (int i = 0; i < Zimmerman.Length - 1; i = i + 2)
            {
                int index1 = 0;
                int index2 = 0;
                char firstLetter = temp1[i];
                char secondLetter = temp1[i + 1];
                for (int j = 0; j < codeNumber.Length; j++)
                {
                    if (codeNumber[j].Contains(firstLetter))
                    {
                        index1 = j;

                    }
                    if (codeNumber[j].Contains(secondLetter))
                    {
                        index2 = j;
                    }
                }
                translated += code[index1, index2];
            }
            richTextBox2.Text=translated;
        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox1.Text;
            inputText = inputText.Replace(" ", string.Empty);
            inputText = inputText.ToUpper();
            char[] temp2 = inputText.ToCharArray();
            string encripted = null;
            for (int i = 0; i < temp2.Length; i++)
            {
                bool hasFoundCombo = false;
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (code[j, k].Contains(temp2[i]))
                        {
                            encripted += codeNumber[j];
                            encripted += codeNumber[k];
                            hasFoundCombo = true;
                        }
                    }
                    if (hasFoundCombo)
                        break;
                }
            }
            richTextBox2.Text=encripted;
        }
    }
}