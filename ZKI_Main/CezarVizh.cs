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
    public partial class CezarVizh : Form
    {
        public CezarVizh()
        {
            InitializeComponent();
        }

        public int keyCez;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                keyCez = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ключ должен быть пенисом");
            }
        }

        string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder keyVizh = new StringBuilder();
        private void button2_Click(object sender, EventArgs e)
        {
            string wordCez = textBox2.Text;
            for (int i = 0; i < wordCez.Length; i++)
            {
                for (int j = 0; j < englishAlphabet.Length; j++)
                {

                    if (wordCez[i] == englishAlphabet[j])
                    {
                        if (j + keyCez >= 26)
                        {

                            keyVizh.Append(englishAlphabet[(j + keyCez) - 26 * ((j + keyCez) / 26)]);
                        }
                        else
                        {
                            keyVizh.Append(englishAlphabet[j + keyCez]);
                        }

                    }
                }
            }
        }
        StringBuilder keyVizh1 = new StringBuilder();
        string[,] arrVizh = new string[26, 26];
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder wordVizh = new StringBuilder(textBox3.Text);
            
            richTextBox2.Text = wordVizh.ToString() + "\n";
            int c = 0;
            for (int i = 0; i < wordVizh.Length; i++)
            {
                if (c == keyVizh.Length) c = 0;
                richTextBox2.Text += keyVizh[c];
                keyVizh1.Append(keyVizh[c]);
                c++;
            }
            StringBuilder alphabet = new StringBuilder(englishAlphabet);
            

            richTextBox3.Text += alphabet;

            for (int i = 0; i < alphabet.Length; i++)
            {
                richTextBox4.Text += alphabet[i] + "\n";
            }

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    arrVizh[i, j] = alphabet[j].ToString();
                    richTextBox1.Text += arrVizh[i, j];
                }
                richTextBox1.Text += "\n";
                alphabet.Append(alphabet[0]);
                alphabet.Remove(0, 1);
            }

            string result = "";
            int i1 = 0;
            int i2 = 0;
            for (int i = 0; i < wordVizh.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (wordVizh[i] == englishAlphabet[j]) i1 = j;
                    if (keyVizh1[i] == englishAlphabet[j]) i2 = j;
                }
                result += arrVizh[i1, i2].ToString();
            }
            textBox5.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder wordVizh = new StringBuilder(textBox4.Text);
            string result = "";
            int i1 = 0;
            int i2 = 0;
            for (int i = 0; i < wordVizh.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (keyVizh1[i] == englishAlphabet[j]) i1 = j;
                }
                for (int t = 0; t < 26; t++)
                {
                    if (wordVizh[i].ToString() == arrVizh[t, i1]) i2 = t;
                }
                result += englishAlphabet[i2];
            }
            textBox6.Text = result;
        }
    }
}
