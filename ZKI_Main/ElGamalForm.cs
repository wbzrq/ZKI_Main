using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZKI_Main
{
    public partial class ElGamalForm : Form
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>()
        {
            { 29, 2 },
            { 31, 3 },
            { 37, 2 },
            { 41, 6 },
            { 43, 3 },
            { 47, 5 },
            { 53, 2 },
            { 59, 2 },
            { 61, 2 },
            { 67, 2 },
            { 71, 2 },
            { 73, 5 },
            { 79, 3 },
            { 83, 2 },
            { 89, 2 },

        };
        int[] keysArray;
        Random random = new Random();
        public string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string Message = String.Empty;
        public int[] M;
        public int G;
        public int P;
        public int X;
        public BigInteger Y;
        public int K;
        public BigInteger[] A;
        public BigInteger[] B;
        public string decrypted;

        public ElGamalForm()
        {
            InitializeComponent();
            keysArray = dictionary.Keys.ToArray();
        }

        int GetSimpleNumber()
        {
            int randomIndex = random.Next(0, keysArray.Length);
            return keysArray[randomIndex];
        }

        int GetRelativelyPrimeNumber(int number)
        {
            int[] keys = dictionary.Keys.ToArray();
            List<int> relativelyPrimeNumbers = new List<int>();

            foreach (int key in keys)
            {
                if (GCD(number, key) == 1)
                {
                    relativelyPrimeNumbers.Add(key);
                }
            }

            if (relativelyPrimeNumbers.Count > 0)
            {
                int randomIndex = random.Next(0, relativelyPrimeNumbers.Count);
                while (relativelyPrimeNumbers[randomIndex] <= 1 || relativelyPrimeNumbers[randomIndex] >= P - 1)
                {
                    randomIndex = random.Next(0, relativelyPrimeNumbers.Count);
                }
                return relativelyPrimeNumbers[randomIndex];
            }

            return -1;
        }

        int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Message = textBox1.Text;
            A = new BigInteger[Message.Length];
            B = new BigInteger[Message.Length];
            M = new int[Message.Length];
            richTextBox1.Text = String.Empty;
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = englishAlphabet.IndexOf(Message[i]) + 1;
                richTextBox1.Text += M[i] + " ";
            }
            P = GetSimpleNumber();
            textBox2.Text = P.ToString();
            G = dictionary[P];
            textBox3.Text = G.ToString();
            X = random.Next(0, P);
            textBox4.Text = X.ToString();
            Y = (BigInteger)Math.Pow(G, X) % P;
            textBox5.Text = Y.ToString();
            K = GetRelativelyPrimeNumber(P - 1);
            textBox6.Text = K.ToString();
            richTextBox2.Text = String.Empty;
            richTextBox3.Text = String.Empty;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = (BigInteger)Math.Pow(G, K) % P;
                richTextBox2.Text += A[i] + " ";
                B[i] = BigInteger.ModPow(Y, K, M[i]) % P;
                richTextBox3.Text += B[i] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = textBox1.Text;
        }
    }
}
