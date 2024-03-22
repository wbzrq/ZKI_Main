namespace ZKI_Main
{
    partial class SingleTranspositionForm
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 145);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(144, 237);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(252, 185);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 1;
            button1.Text = "Зашифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(252, 220);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 2;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(379, 145);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(171, 237);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(379, 113);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(171, 26);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(556, 145);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(45, 237);
            richTextBox4.TabIndex = 5;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(162, 145);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(40, 237);
            richTextBox5.TabIndex = 7;
            richTextBox5.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(12, 113);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(144, 26);
            richTextBox6.TabIndex = 6;
            richTextBox6.Text = "";
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(12, 12);
            richTextBox7.MaxLength = 90;
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(381, 60);
            richTextBox7.TabIndex = 8;
            richTextBox7.Text = "";
            richTextBox7.KeyPress += richTextBox7_KeyPress;
            // 
            // button3
            // 
            button3.Location = new Point(12, 78);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 9;
            button3.Text = "Запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SingleTranspositionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(button3);
            Controls.Add(richTextBox7);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "SingleTranspositionForm";
            Text = "SingleTranspositionForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private Button button3;
    }
}