using System.IO;

namespace ZKI_Main
{
    public partial class PolybiusForm : Form
    {
        public PolybiusForm()
        {
            InitializeComponent();
            char[,] arr = new char[6, 6] { { 'd', 'e', 'b', 'u', 'g', 'i' },
                                           { 'n', 'a', 'c', 'f', 'h', 'j' },
                                           { 'k', 'l', 'm', 'o', 'p', 'q' },
                                           { 'r', 's', 't', 'v', 'w', 'x' },
                                           { 'y', 'z', '0', '1', '2', '3' },
                                           { '4', '5', '6', '7', '8', '9' } };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    richTextBox3.Text += arr[i, j].ToString() + " ";
                }
                richTextBox3.Text += "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] arr = new char[6, 6] { { 'd', 'e', 'b', 'u', 'g', 'i' },
                                           { 'n', 'a', 'c', 'f', 'h', 'j' },
                                           { 'k', 'l', 'm', 'o', 'p', 'q' },
                                           { 'r', 's', 't', 'v', 'w', 'x' },
                                           { 'y', 'z', '0', '1', '2', '3' },
                                           { '4', '5', '6', '7', '8', '9' } };
            string word = richTextBox1.Text;
            int l = word.Length;
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            string result = "";

            for (int a = 0; a < l; a++)
            {
                int posI;
                int posJ;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (word[a] == arr[i, j])
                        {
                            posI = i + 1;
                            posJ = j + 1;
                            result += posI.ToString() + posJ.ToString();
                            break;
                        }
                    }
                }

            }
            StreamWriter sw = new StreamWriter("C:\\MCB\\ÇÊÈ\\ZKI_MAIN\\polybius.txt");
            sw.WriteLine("רטפנ");
            sw.WriteLine(result);
            sw.Close();
            richTextBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[,] arr = new char[6, 6] { { 'd', 'e', 'b', 'u', 'g', 'i' },
                                           { 'n', 'a', 'c', 'f', 'h', 'j' },
                                           { 'k', 'l', 'm', 'o', 'p', 'q' },
                                           { 'r', 's', 't', 'v', 'w', 'x' },
                                           { 'y', 'z', '0', '1', '2', '3' },
                                           { '4', '5', '6', '7', '8', '9' } };
            string cipher = richTextBox1.Text;
            int l = cipher.Length;
            string result = "";

            for (int a = 0; a <= l; a += 2)
            {
                if (a >= l)
                {
                    break;
                }
                int pos1 = Convert.ToInt32(cipher[a].ToString()) - 1;
                int pos2 = Convert.ToInt32(cipher[a + 1].ToString()) - 1;
                result += arr[pos1, pos2];
            }
            StreamWriter sw = new StreamWriter("C:\\MCB\\ÇÊÈ\\ZKI_MAIN\\polybius.txt");
            sw.WriteLine("הורטפנמגאםטו:");
            sw.WriteLine(result);
            sw.Close();
            richTextBox2.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}