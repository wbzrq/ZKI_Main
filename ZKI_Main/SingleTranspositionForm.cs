using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZKI_Main
{
    public partial class SingleTranspositionForm : Form
    {
        public SingleTranspositionForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox6.Text = "7 1 3 2 5 4 9 8 6";
                richTextBox5.Text = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10";
                string word = richTextBox7.Text;
                Array1 array = new Array1();
                array.Write(word);
                richTextBox1.Text = array.Print();
                richTextBox7.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Введены некоректные данные");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "1 2 3 4 5 6 7 8 9";
            richTextBox4.Text = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10";
            string word = richTextBox7.Text;
            Array1 array = new Array1();
            array.Write(word);
            ArrayCol1 arrayCol = new ArrayCol1();
            string arrRes = arrayCol.Print(array);
            richTextBox2.Text = arrRes;
            string result = arrRes.Replace(" ", "");
            string result1 = result.Replace("\n", "");
            StreamWriter sw = new StreamWriter("C:\\MCB\\ЗКИ\\ZKI_Main\\single.txt");
            sw.WriteLine("дешифрование: ");
            sw.WriteLine(result1);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox3.Text = "7 1 3 2 5 4 9 8 6";
            richTextBox4.Text = "1\n2\n3\n4\n5\n6\n7\n8\n9\n10";
            string word = richTextBox7.Text;
            Array1 array = new Array1();
            array.Write(word);
            string arrRes = array.Print();
            richTextBox2.Text = arrRes;
            string result = arrRes.Replace(" ", "");
            string result1 = result.Replace("\n", "");
            StreamWriter sw = new StreamWriter("C:\\MCB\\ЗКИ\\ZKI_Main\\single.txt");
            sw.WriteLine("шифрование: ");
            sw.WriteLine(result1);
            sw.Close();
        }

        private void richTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true; // Запрещаем обработку введенного символа
            }
        }
    }

    public class Array1
    {
        char[,] arr = new char[10, 9];
        public char this[int i, int j]
        {
            get => arr[i, j];
            set => arr[i, j] = value;
        }
        public string Print()
        {
            int rows = 10;
            int columns = 9;
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
            int rows = 10;
            int columns = 9;
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

    public class ArrayCol1
    {
        char[,] arrCol = new char[10, 9];
        public char this[int i, int j]
        {
            get => arrCol[i, j];
            set => arrCol[i, j] = value;
        }

        public string Print(Array1 arr)
        {
            int rows = 10;
            int columns = 9;
            for (int i = 0; i < rows; i++)
            {
                arrCol[i, 0] = arr[i, 1];
                arrCol[i, 1] = arr[i, 3];
                arrCol[i, 2] = arr[i, 2];
                arrCol[i, 3] = arr[i, 5];
                arrCol[i, 4] = arr[i, 4];
                arrCol[i, 5] = arr[i, 8];
                arrCol[i, 6] = arr[i, 0];
                arrCol[i, 7] = arr[i, 7];
                arrCol[i, 8] = arr[i, 5];
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
}
