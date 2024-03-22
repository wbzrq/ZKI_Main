using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZKI_Main
{
    public partial class VizhPleifForm : Form
    {
        public VizhPleifForm()
        {
            InitializeComponent();
        }

        public string keyVizh;
        private void button1_Click(object sender, EventArgs e)
        {
            keyVizh = textBox1.Text;
        }

        string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        StringBuilder pleifAlphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ -.,");
        StringBuilder keyVizh1 = new StringBuilder();
        string[,] arrVizh = new string[26, 26];
        StringBuilder keyPleif = new StringBuilder();
        string[,] arrPleif = new string[6, 5];
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder wordVizh = new StringBuilder(textBox2.Text);

            //richTextBox2.Text = wordVizh.ToString() + "\n";
            int c = 0;
            for (int i = 0; i < wordVizh.Length; i++)
            {
                if (c == keyVizh.Length) c = 0;
                //richTextBox2.Text += keyVizh[c];
                keyVizh1.Append(keyVizh[c]);
                c++;
            }
            StringBuilder alphabet = new StringBuilder(englishAlphabet);


            richTextBox2.Text += alphabet;

            for (int i = 0; i < alphabet.Length; i++)
            {
                richTextBox3.Text += alphabet[i] + "\n";
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

            //string result = "";
            int i1 = 0;
            int i2 = 0;
            for (int i = 0; i < wordVizh.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (wordVizh[i] == englishAlphabet[j]) i1 = j;
                    if (keyVizh1[i] == englishAlphabet[j]) i2 = j;
                }
                keyPleif.Append(arrVizh[i1, i2]);
            }

            int length = keyPleif.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (keyPleif[i] == keyPleif[j])
                    {
                        keyPleif.Remove(j, 1);
                        length--;
                    }
                }
            }

            length = pleifAlphabet.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < keyPleif.Length; j++)
                {
                    if (pleifAlphabet[i] == keyPleif[j])
                    {
                        pleifAlphabet.Remove(i, 1);
                        length--;
                    }
                }
            }
            keyPleif.Append(pleifAlphabet);
            //richTextBox4.Text += keyPleif.ToString();
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrPleif[i, j] = keyPleif[count].ToString();
                    richTextBox4.Text += keyPleif[count].ToString() + " ";
                    count++;
                }
                richTextBox4.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("ahtung");
            StringBuilder pleifWord = new StringBuilder(textBox3.Text);
            StringBuilder pleifCipher = new StringBuilder();
            for (int i = 0; i < pleifWord.Length; i += 2)
            {
                int m1 = 0;
                int n1 = 0;
                int m2 = 0;
                int n2 = 0;
                for (int m = 0; m < 6; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        if (pleifWord[i].ToString() == arrPleif[m, n])
                        {
                            m1 = m;
                            n1 = n;
                        }
                        if (pleifWord[i + 1].ToString() == arrPleif[m, n])
                        {
                            m2 = m;
                            n2 = n;
                        }
                    }
                }

                if (m1 == m2)
                {
                    if (n2 == 4)
                    {
                        pleifCipher.Append(arrPleif[m2, n1 + 1]);
                        pleifCipher.Append(arrPleif[m1, 0]);

                    }
                    else if (n1 == 4)
                    {
                        pleifCipher.Append(arrPleif[m2, 0]);
                        pleifCipher.Append(arrPleif[m1, n2 + 1]);

                    }
                    else
                    {
                        pleifCipher.Append(arrPleif[m2, n1 + 1]);
                        pleifCipher.Append(arrPleif[m1, n2 + 1]);

                    }
                }
                else if (n1 == n2)
                {
                    if (m2 == 5)
                    {
                        pleifCipher.Append(arrPleif[m1 + 1, n2]);
                        pleifCipher.Append(arrPleif[0, n1]);

                    }
                    else if (m1 == 5)
                    {
                        pleifCipher.Append(arrPleif[0, n2]);
                        pleifCipher.Append(arrPleif[m2 + 1, n1]);

                    }
                    else
                    {
                        pleifCipher.Append(arrPleif[m1 + 1, n2]);
                        pleifCipher.Append(arrPleif[m2 + 1, n1]);

                    }

                }
                else
                {
                    pleifCipher.Append(arrPleif[m1, n2]);
                    pleifCipher.Append(arrPleif[m2, n1]);
                }

            }
            richTextBox5.Text = pleifCipher.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder pleifWord = new StringBuilder(textBox4.Text);
            StringBuilder pleifDecode = new StringBuilder();

            for (int i = 0; i < pleifWord.Length; i += 2)
            {
                int m1 = 0;
                int n1 = 0;
                int m2 = 0;
                int n2 = 0;
                for (int m = 0; m < 6; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        if (pleifWord[i].ToString() == arrPleif[m, n])
                        {
                            m1 = m;
                            n1 = n;
                        }
                        if (pleifWord[i + 1].ToString() == arrPleif[m, n])
                        {
                            m2 = m;
                            n2 = n;
                        }
                    }
                }

                if (m1 == m2)
                {
                    if (n2 == 0)
                    {
                        pleifDecode.Append(arrPleif[m2, n1 - 1]);
                        pleifDecode.Append(arrPleif[m1, 4]);

                    }
                    else if (n1 == 0)
                    {
                        pleifDecode.Append(arrPleif[m2, 4]);
                        pleifDecode.Append(arrPleif[m1, n2 - 1]);

                    }
                    else
                    {
                        pleifDecode.Append(arrPleif[m2, n1 - 1]);
                        pleifDecode.Append(arrPleif[m1, n2 - 1]);

                    }
                }
                else if (n1 == n2)
                {
                    if (m2 == 0)
                    {
                        pleifDecode.Append(arrPleif[m1 - 1, n2]);
                        pleifDecode.Append(arrPleif[5, n1]);

                    }
                    else if (m1 == 0)
                    {
                        pleifDecode.Append(arrPleif[5, n2]);
                        pleifDecode.Append(arrPleif[m2 - 1, n1]);

                    }
                    else
                    {
                        pleifDecode.Append(arrPleif[m1 - 1, n2]);
                        pleifDecode.Append(arrPleif[m2 - 1, n1]);

                    }

                }
                else
                {
                    pleifDecode.Append(arrPleif[m1, n2]);
                    pleifDecode.Append(arrPleif[m2, n1]);
                }

            }
            richTextBox6.Text = pleifDecode.ToString();
        }
    }
}
