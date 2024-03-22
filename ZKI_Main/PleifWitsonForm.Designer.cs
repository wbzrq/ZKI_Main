namespace ZKI_Main
{
    partial class PleifWitsonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            label5 = new Label();
            richTextBox5 = new RichTextBox();
            button4 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            richTextBox4 = new RichTextBox();
            button5 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(170, 72);
            button2.Name = "button2";
            button2.Size = new Size(119, 51);
            button2.TabIndex = 24;
            button2.Text = "Первый ключ\r\nУитсона";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 7);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 23;
            label2.Text = "фраза для шифрования плейфера";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(2, 72);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 7);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 20;
            label1.Text = "Ключ плейфера";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(2, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 19;
            // 
            // button3
            // 
            button3.Location = new Point(300, 72);
            button3.Name = "button3";
            button3.Size = new Size(119, 51);
            button3.TabIndex = 25;
            button3.Text = "Второй ключ\r\nУитсона";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(657, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(131, 153);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 192);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(131, 148);
            richTextBox2.TabIndex = 27;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(158, 192);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(131, 148);
            richTextBox3.TabIndex = 28;
            richTextBox3.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 435);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 42;
            label5.Text = "полученное сообщение";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(406, 458);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(291, 42);
            richTextBox5.TabIndex = 41;
            richTextBox5.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(404, 202);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 40;
            button4.Text = "принять";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 320);
            label6.Name = "label6";
            label6.Size = new Size(251, 20);
            label6.TabIndex = 39;
            label6.Text = "фраза для дешифрования Уитсона";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(404, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(249, 27);
            textBox4.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 252);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 37;
            label4.Text = "полученное сообщение";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(406, 275);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(291, 42);
            richTextBox4.TabIndex = 36;
            richTextBox4.Text = "";
            // 
            // button5
            // 
            button5.Location = new Point(406, 385);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 35;
            button5.Text = "принять";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 130);
            label3.Name = "label3";
            label3.Size = new Size(235, 20);
            label3.TabIndex = 34;
            label3.Text = "фраза для шифрования Уитсона";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(404, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 33;
            // 
            // PleifWitsonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(label5);
            Controls.Add(richTextBox5);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(richTextBox4);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "PleifWitsonForm";
            Text = "PleifWitsonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Label label5;
        private RichTextBox richTextBox5;
        private Button button4;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private RichTextBox richTextBox4;
        private Button button5;
        private Label label3;
        private TextBox textBox3;
    }
}