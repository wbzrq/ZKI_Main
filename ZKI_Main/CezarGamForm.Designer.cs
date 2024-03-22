namespace ZKI_Main
{
    partial class CezarGamForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            label7 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            button4 = new Button();
            label8 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 75);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 24;
            button1.Text = "принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 23;
            label1.Text = "Ключ цезаря";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(172, 75);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 27;
            button2.Text = "принять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 10);
            label2.Name = "label2";
            label2.Size = new Size(227, 20);
            label2.TabIndex = 26;
            label2.Text = "фраза для шифрования цезаря";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 10);
            label3.Name = "label3";
            label3.Size = new Size(272, 20);
            label3.TabIndex = 29;
            label3.Text = "зашифрованное сообщение цезарем";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(411, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 28;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 160);
            label4.Name = "label4";
            label4.Size = new Size(323, 20);
            label4.TabIndex = 31;
            label4.Text = "гамма сообщения, зашифрованное цезарем";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(325, 27);
            textBox4.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 228);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 33;
            label5.Text = "гамма";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 254);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(325, 27);
            textBox5.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 294);
            label6.Name = "label6";
            label6.Size = new Size(208, 20);
            label6.TabIndex = 35;
            label6.Text = "зашифрованное сообщение";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 320);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(325, 27);
            textBox6.TabIndex = 34;
            // 
            // button3
            // 
            button3.Location = new Point(12, 382);
            button3.Name = "button3";
            button3.Size = new Size(327, 29);
            button3.TabIndex = 36;
            button3.Text = "стоп";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 294);
            label7.Name = "label7";
            label7.Size = new Size(329, 20);
            label7.TabIndex = 42;
            label7.Text = "дешифрованное сообщение гаммированием";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(409, 320);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(325, 27);
            textBox7.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(411, 160);
            label9.Name = "label9";
            label9.Size = new Size(210, 20);
            label9.TabIndex = 38;
            label9.Text = "сообщение для дешифровки";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(409, 186);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(325, 27);
            textBox9.TabIndex = 37;
            // 
            // button4
            // 
            button4.Location = new Point(409, 252);
            button4.Name = "button4";
            button4.Size = new Size(327, 29);
            button4.TabIndex = 43;
            button4.Text = "дешифровать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(409, 361);
            label8.Name = "label8";
            label8.Size = new Size(209, 20);
            label8.TabIndex = 45;
            label8.Text = "дешифрованное сообщение";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(407, 387);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(325, 27);
            textBox8.TabIndex = 44;
            // 
            // CezarGamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CezarGamForm";
            Text = "CezarGamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Button button3;
        private Label label7;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox9;
        private Button button4;
        private Label label8;
        private TextBox textBox8;
    }
}