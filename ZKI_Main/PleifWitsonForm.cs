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
    public partial class PleifWitsonForm : Form
    {
        public PleifWitsonForm()
        {
            InitializeComponent();
        }

        StringBuilder keyPleif;
        string[,] arrPleif = new string[6, 5];
        StringBuilder Alphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ -.,");
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder pleifAlphabet = Alphabet;

            keyPleif = new StringBuilder(textBox1.Text);
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
                    richTextBox1.Text += keyPleif[count].ToString() + " ";
                    count++;
                }
                richTextBox1.Text += "\n";
            }
        }

        public string GenerateWitsonKey(string word)
        {
            StringBuilder pleifWord = new StringBuilder(word);
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
            return pleifCipher.ToString();
        }

        string[,] arrWitson1 = new string[6, 5];
        string[,] arrWitson2 = new string[6, 5];

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder witsonKey = new StringBuilder(GenerateWitsonKey(textBox2.Text));
            //MessageBox.Show(witsonKey.ToString());

            StringBuilder pleifAlphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ -.,");
            //keyPleif = new StringBuilder(textBox1.Text);
            int length = witsonKey.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (witsonKey[i] == witsonKey[j])
                    {
                        witsonKey.Remove(j, 1);
                        length--;
                    }
                }
            }
            MessageBox.Show(witsonKey.ToString());

            length = pleifAlphabet.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < witsonKey.Length; j++)
                {
                    if (pleifAlphabet[i] == witsonKey[j])
                    {
                        pleifAlphabet.Remove(i, 1);
                        length--;
                    }
                }
            }
            witsonKey.Append(pleifAlphabet);
            //MessageBox.Show(witsonKey.ToString());
            //richTextBox4.Text += keyPleif.ToString();
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrWitson1[i, j] = witsonKey[count].ToString();
                    richTextBox2.Text += witsonKey[count].ToString() + " ";
                    count++;
                }
                richTextBox2.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder witsonKey = new StringBuilder(GenerateWitsonKey(textBox2.Text));

            StringBuilder pleifAlphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ -.,");

            int length = witsonKey.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (witsonKey[i] == witsonKey[j])
                    {
                        witsonKey.Remove(j, 1);
                        length--;
                    }
                }
            }

            length = pleifAlphabet.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < witsonKey.Length; j++)
                {
                    if (pleifAlphabet[i] == witsonKey[j])
                    {
                        pleifAlphabet.Remove(i, 1);
                        length--;
                    }
                }
            }
            witsonKey.Append(pleifAlphabet);
            //MessageBox.Show(witsonKey.ToString());
            //richTextBox4.Text += keyPleif.ToString();
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrWitson2[i, j] = witsonKey[count].ToString();
                    richTextBox3.Text += witsonKey[count].ToString() + " ";
                    count++;
                }
                richTextBox3.Text += "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder wordWits = new StringBuilder(textBox3.Text);

            StringBuilder cipherWits = new StringBuilder();
            for (int i = 0; i < wordWits.Length; i += 2)
            {
                int m1 = 0;
                int n1 = 0;
                int m2 = 0;
                int n2 = 0;
                for (int m = 0; m < 6; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        if (wordWits[i].ToString() == arrWitson1[m, n])
                        {
                            m1 = m;
                            n1 = n;
                        }
                        if (wordWits[i + 1].ToString() == arrWitson2[m, n])
                        {
                            m2 = m;
                            n2 = n;
                        }
                    }

                }
                if (m1 == m2)
                {
                    cipherWits.Append(arrWitson2[m1, n1]);
                    cipherWits.Append(arrWitson1[m2, n2]);
                }
                else
                {
                    cipherWits.Append(arrWitson2[m1, n2]);
                    cipherWits.Append(arrWitson1[m2, n1]);
                }

            }
            richTextBox4.Text = cipherWits.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StringBuilder wordWits = new StringBuilder(textBox4.Text);
            StringBuilder decipherWits = new StringBuilder();

            for (int i = 0; i < wordWits.Length; i += 2)
            {
                int m1 = 0;
                int n1 = 0;
                int m2 = 0;
                int n2 = 0;
                for (int m = 0; m < 6; m++)
                {
                    for (int n = 0; n < 5; n++)
                    {
                        if (wordWits[i].ToString() == arrWitson2[m, n])
                        {
                            m1 = m;
                            n1 = n;
                        }
                        if (wordWits[i + 1].ToString() == arrWitson1[m, n])
                        {
                            m2 = m;
                            n2 = n;
                        }
                    }

                }
                if (m1 == m2)
                {
                    
                    decipherWits.Append(arrWitson1[m2, n1]);
                    decipherWits.Append(arrWitson2[m1, n2]);
                }
                else
                {
                    decipherWits.Append(arrWitson1[m1, n2]);
                    decipherWits.Append(arrWitson2[m2, n1]);
                    
                }

            }
            richTextBox5.Text = decipherWits.ToString();
        }
    }
}
