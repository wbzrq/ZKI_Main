using System.Windows.Forms;

namespace ZKI_Main
{
    public partial class DoubleTranspositionForm : Form
    {
        public DoubleTranspositionForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Array arr = new Array();
            string word = richTextBox1.Text;
            if (word.Length == 16)
            {
                richTextBox1.ReadOnly = true;
                arr.Write(word);
                richTextBox2.Text = arr.Print();
                richTextBox3.Text = "4 3 2 1";
                richTextBox4.Text = "2\n3\n4\n1\n";
            }
            else
            {
                MessageBox.Show("Вы ввели недостаточно символов");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array arr = new Array();
            string word = richTextBox1.Text;
            arr.Write(word);
            ArrayCol arrCol = new ArrayCol();
            richTextBox2.Text = arrCol.Print(arr);
            richTextBox3.Text = "1 2 3 4";
            richTextBox4.Text = "2\n3\n4\n1\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array arr = new Array();
            ArrayCol arrCol = new ArrayCol();
            ArrayRow arrRow = new ArrayRow();
            string word = richTextBox1.Text;
            arr.Write(word);
            arrCol.Print(arr);
            richTextBox2.Text = arrRow.Print(arrCol);
            richTextBox3.Text = "1 2 3 4";
            richTextBox4.Text = "1\n2\n3\n4\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

public class Array
{
    char[,] arr = new char[4, 4];
    public char this[int i, int j]
    {
        get => arr[i, j];
        set => arr[i, j] = value;
    }
    public string Print()
    {
        int rows = 4;
        int columns = 4;
        string result = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result += arr[i, j] + " ";
            }
            result += "\n";
        }
        return result;
    }
    public void Write(string word)
    {
        int rows = 4;
        int columns = 4;
        int l = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                arr[i, j] = word[l];
                l++;
            }
        }
    }
}

public class ArrayCol
{
    char[,] arrCol = new char[4, 4];
    public char this[int i, int j]
    {
        get => arrCol[i, j];
        set => arrCol[i, j] = value;
    }

    public string Print(Array arr)
    {
        int rows = 4;
        int columns = 4;
        for (int i = 0; i < rows; i++)
        {
            arrCol[i, 0] = arr[i, 3];
            arrCol[i, 1] = arr[i, 2];
            arrCol[i, 2] = arr[i, 1];
            arrCol[i, 3] = arr[i, 0];
        }
        string result = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result += arrCol[i, j] + " ";
            }
            result += "\n";
        }
        return result;
    }
}

public class ArrayRow
{
    char[,] arrRow = new char[4, 4];
    public char this[int i, int j]
    {
        get => arrRow[i, j];
        set => arrRow[i, j] = value;
    }

    public string Print(ArrayCol arr)
    {
        int rows = 4;
        int columns = 4;
        for (int i = 0; i < columns; i++)
        {
            arrRow[0, i] = arr[3, i];
            arrRow[1, i] = arr[0, i];
            arrRow[2, i] = arr[1, i];
            arrRow[3, i] = arr[2, i];
        }
        string result = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result += arrRow[i, j] + " ";
            }
            result += "\n";
        }
        return result;
    }
}