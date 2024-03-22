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
    public partial class CezarGamForm : Form
    {
        public CezarGamForm()
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
                MessageBox.Show("Ключ должен быть числом");
            }
        }

        StringBuilder englishAlphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        StringBuilder gammaWord;
        StringBuilder gammaCypher = new StringBuilder();
        int[] wordGamma;

        int[] gamma;
        private void timer1_Tick(object sender, EventArgs e)
        {
            gamma = new int[gammaWord.Length];
            Random random = new Random();
            textBox5.Text = String.Empty;
            for (int i = 0; i < gammaWord.Length; i++)
            {
                gamma[i] = random.Next(1, 37);
                textBox5.Text += gamma[i] + " ";
            }

            wordGamma = new int[gammaWord.Length];
            textBox4.Text = String.Empty;
            gammaCypher = new StringBuilder();
            textBox6.Text = String.Empty;
            for (int i = 0; i < gammaWord.Length; i++)
            {
                for (int j = 0; j < englishAlphabet.Length; j++)
                {
                    if (gammaWord[i] == englishAlphabet[j])
                    {
                        wordGamma[i] = j + 1;
                        textBox4.Text += j + 1 + " ";
                    }
                }
                int y = 0;
                int z = wordGamma[i];
                int x = gamma[i];
                int M = englishAlphabet.Length;
                y = (x + z) % M;
                gammaCypher.Append(englishAlphabet[y]);
                textBox6.Text = gammaCypher.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gammaWord = new StringBuilder();
            string wordCez = textBox2.Text;
            for (int i = 0; i < wordCez.Length; i++)
            {
                for (int j = 0; j < englishAlphabet.Length; j++)
                {

                    if (wordCez[i] == englishAlphabet[j])
                    {
                        if (j + keyCez >= 35)
                        {

                            gammaWord.Append(englishAlphabet[(j + keyCez) - 35 * ((j + keyCez) / 35)]);
                        }
                        else
                        {
                            gammaWord.Append(englishAlphabet[j + keyCez]);
                        }

                    }
                }
            }
            timer1.Start();
            textBox3.Text = gammaWord.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder word = new StringBuilder(textBox9.Text);
            StringBuilder dWord = new StringBuilder();
            textBox7.Text = String.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                int I = 0;
                for (int j = 0; j < englishAlphabet.Length; j++)
                {
                    if (word[i] == englishAlphabet[j])
                    {
                        I = j;
                    }
                }
                int z = (I + englishAlphabet.Length - gamma[i]) % englishAlphabet.Length;
                //dWord.Append(word[z - 1]);
                textBox7.Text += englishAlphabet[z - 1];
            }

            textBox8.Text = String.Empty;
            StringBuilder cezDWord = new StringBuilder();
            for (int i = 0; i < dWord.Length; i++)
            {
                for (int j = 0; j < englishAlphabet.Length; j++)
                {

                    if (dWord[i] == englishAlphabet[j])
                    {
                        if (j - keyCez < 0)
                        {

                            cezDWord.Append(englishAlphabet[35 - (j - keyCez)]);
                        }
                        else
                        {
                            cezDWord.Append(englishAlphabet[j - keyCez]);
                        }

                    }
                }
            }
            textBox8.Text = cezDWord.ToString();
        }
    }
}
