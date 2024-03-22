using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZKI_Main
{
    public partial class RanecForm : Form
    {
        Dictionary<string, char> charToBinary = new Dictionary<string, char>();
        public RanecForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // от 0 до 255, чтобы представить все возможные байты
            for (int i = 0; i < 256; i++)
            {
                char c = Encoding.GetEncoding("Windows-1251").GetChars(new byte[] { (byte)i })[0];
                string binary = Convert.ToString(i, 2).PadLeft(8, '0');
                charToBinary.Add(binary, c);
            }
        }
        List<int> PrivateKey = new List<int>();
        List<int> PublicKey = new List<int>();
        int n = 0;
        int m = 0;
        int n_1 = 0;
        //int sum = 0;
        public int SumPrivateKey(List<int> PrivateKey)
        {
            int sum = 0;
            for (int i = 0; i < PrivateKey.Count; i++)
            {
                sum += PrivateKey[i];
            }
            return sum;
        }

        private bool IsDataRight()
        {
            if (n != 0 && m != 0 && n_1 != 0 && PrivateKey.Count != 0)
                return true;
            return false;
        }
        StringBuilder message;
        string[] binCode;
        string[,] sumWeight;
        int[] C_I;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsDataRight())
                    MessageBox.Show("Неверные данные для шифровки");
                else
                {
                    message = new StringBuilder(textBox1.Text);
                    binCode = new string[message.Length];
                    sumWeight = new string[message.Length, 8];
                    C_I = new int[message.Length];
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("", "символ");
                    dataGridView1.Columns.Add("", "bincode");
                    dataGridView1.Columns.Add("", "сумма весов");
                    dataGridView1.Columns.Add("", "c_i");
                    for (int i = 0; i < 8; i++)
                    {
                        PublicKey.Add((PrivateKey[i] * n) % m);
                        textBox3.Text += PublicKey[i] + " ";
                    }
                    int ind = 0;
                    foreach (char c in message.ToString())
                    {
                        StringBuilder sb = new StringBuilder();
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                        byte b = Encoding.GetEncoding("windows-1251").GetBytes(new char[] { c })[0];
                        string bC = Convert.ToString(b, 2).PadLeft(8, '0');
                        binCode[ind] = bC;
                        string sW = "";
                        int c_i = 0;
                        for (int j = 0; j < 8; j++)
                        {
                            if (binCode[ind][j] != '0')
                            {
                                sumWeight[ind, j] = PublicKey[j].ToString();
                                c_i += PublicKey[j];
                            }
                            else
                                sumWeight[ind, j] = "0";
                            sW += sumWeight[ind, j] + " ";
                        }
                        C_I[ind] = c_i % m;
                        dataGridView1.Rows.Add(message[ind], binCode[ind], sW, C_I[ind]);
                        ind++;
                    }
                    for (int i = 0; i < C_I.Length; i++)
                    {
                        textBox7.Text += C_I[i] + " ";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Заполните поля");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                PrivateKey.Clear();
                PrivateKey.Add(int.Parse(textBox2.Text));
                for (int i = 1; i < 8; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < PrivateKey.Count; j++)
                    {
                        sum += PrivateKey[j];
                    }
                    PrivateKey.Add(sum + 1);
                    textBox2.Text += " " + PrivateKey[i].ToString();
                }
                if (!IsSeqRight(PrivateKey))
                {
                    textBox2.BackColor = Color.Red;
                    PrivateKey.Clear();
                }
                else
                {
                    textBox2.BackColor = Color.Green;
                }
            }
        }
        public bool IsSeqRight(List<int> PrivateKey)
        {
            if (PrivateKey.Count != 8)
                return false;
            int s = 0;
            for (int i = 0; i < PrivateKey.Count; i++)
            {
                if (PrivateKey[i] < s + 1)
                    return false;
                s += PrivateKey[i];
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                PrivateKey.Clear();
                string str = textBox2.Text;
                string[] arr = str.Split(' ').ToArray();
                foreach (var a in arr)
                {
                    PrivateKey.Add(int.Parse(a));
                }
                if (!IsSeqRight(PrivateKey))
                {
                    textBox2.BackColor = Color.Red;
                    PrivateKey.Clear();
                }
                else
                {
                    textBox2.BackColor = Color.Green;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("RanecFiles\\PrivateKey.txt");
            line = sr.ReadLine();
            sr.Close();
            PrivateKey.Clear();
            string[] arr = line.Split(' ').ToArray();
            foreach (var a in arr)
            {
                PrivateKey.Add(int.Parse(a));
                textBox2.Text += a.ToString() + " ";
            }
            if (!IsSeqRight(PrivateKey))
            {
                textBox2.BackColor = Color.Red;
                PrivateKey.Clear();
            }
            else
            {
                textBox2.BackColor = Color.Green;
            }
        }

        public bool IsMRight(int m)
        {
            if (m <= PrivateKey.Sum())
                return false;
            return true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int tmp = SumPrivateKey(PrivateKey) * 2 + random.Next(2, 10);
            textBox6.Text = tmp.ToString();
            if (!IsMRight(tmp))
            {
                textBox6.BackColor = Color.Red;
                m = 0;
            }
            else
            {
                textBox6.BackColor = Color.Green;
                m = tmp;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            try
            {
                tmp = int.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("m должен быть числом");
            }
            if (!IsMRight(tmp))
            {
                textBox6.BackColor = Color.Red;
                m = 0;
            }
            else
            {
                textBox6.BackColor = Color.Green;
                m = tmp;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("RanecFiles\\m.txt");
            line = sr.ReadLine();
            sr.Close();
            int tmp = int.Parse(line);
            textBox6.Text = m.ToString();
            if (!IsMRight(tmp))
            {
                textBox6.BackColor = Color.Red;
                m = 0;
            }
            else
            {
                textBox6.BackColor = Color.Green;
                m = tmp;
            }
        }

        public bool IsNRight(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
            if (c == 2 && m % n != 0)
            {
                return true;
            }
            return false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Random random = new Random();
                int tmp = random.Next(1, 100);
                if (IsNRight(tmp))
                {
                    n = tmp;
                    textBox4.Text = n.ToString();
                    textBox4.BackColor = Color.Green;
                    break;
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!IsNRight(int.Parse(textBox4.Text)))
            {
                textBox4.BackColor = Color.Red;
                n = 0;
            }
            else
            {
                textBox4.BackColor = Color.Green;
                n = int.Parse(textBox4.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("RanecFiles\\n.txt");
            line = sr.ReadLine();
            sr.Close();
            int tmp = int.Parse(line);
            textBox4.Text = tmp.ToString();
            if (!IsNRight(tmp))
            {
                textBox4.BackColor = Color.Red;
                n = 0;
            }
            else
            {
                textBox4.BackColor = Color.Green;
                n = tmp;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            while (true)
            {
                n_1 = Random.Shared.Next(1, 1000);
                if ((n * n_1) % m == 1)
                {
                    textBox5.Text = n_1.ToString();
                    textBox5.BackColor = Color.Green;
                    break;
                }
            }
        }

        private bool isN_1Right(int n_1)
        {
            if ((n * n_1) % m == 1)
                return true;
            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (isN_1Right(Convert.ToInt32(textBox5.Text)))
            {
                n_1 = Convert.ToInt32(textBox5.Text);
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
                n_1 = 0;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader("RanecFiles\\n_1.txt");
            line = sr.ReadLine();
            sr.Close();
            int tmp = int.Parse(line);
            if (IsNRight(tmp))
            {
                textBox5.Text = tmp.ToString();
                n_1 = tmp;
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.Text = tmp.ToString();
                n_1 = 0;
                textBox5.BackColor = Color.Red;
            }

        }

        int[] A_I;

        private void button14_Click(object sender, EventArgs e)
        {
            if (!IsDataRight())
                MessageBox.Show("Неверные данные для шифровки");
            else
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Add("", "c_i");
                dataGridView1.Columns.Add("", "a_i");
                dataGridView1.Columns.Add("", "сумма весов");
                dataGridView1.Columns.Add("", "bincode");
                dataGridView1.Columns.Add("", "символ");
                string[] tmpC_I = textBox9.Text.Split(' ');
                A_I = new int[tmpC_I.Length];
                for (int i = 0; i < tmpC_I.Length; i++)
                {
                    C_I[i] = Convert.ToInt32(tmpC_I[i]);
                    A_I[i] = (C_I[i] * n_1) % m;
                    string sW = "";
                    string bC = "";
                    int a_i = A_I[i];
                    for (int j = 7; j >= 0; j--)
                    {
                        if (a_i - PrivateKey[j] >= 0)
                        {
                            a_i -= PrivateKey[j];
                            sW = sW.Insert(0, PrivateKey[j].ToString() + " ");
                            bC = bC.Insert(0, "1 ");
                        }
                        else
                        {
                            sW = sW.Insert(0, "0 ");
                            bC = bC.Insert(0, "0 ");
                        }
                    }
                    dataGridView1.Rows.Add(C_I[i], A_I[i], sW, bC, charToBinary[bC.Replace(" ", "")]);
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("RanecFiles\\PrivateKey.txt");
            string pK = "";
            for (int i = 0; i < PrivateKey.Count; i++)
            {
                pK += PrivateKey[i] + " ";
            }
            sw.WriteLine(pK);
            sw.Close();
            sw = new StreamWriter("RanecFiles\\n.txt");
            sw.WriteLine(n.ToString());
            sw.Close();
            sw = new StreamWriter("RanecFiles\\m.txt");
            sw.WriteLine(m.ToString());
            sw.Close();
            sw = new StreamWriter("RanecFiles\\n_1.txt");
            sw.WriteLine(n_1.ToString());
            sw.Close();
        }
    }
}

