namespace ZKI_Main
{
    partial class PolybiusForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(69, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(125, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(69, 368);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 1;
            button1.Text = "Шифр";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(69, 403);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 2;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(69, 199);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(125, 120);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(265, 52);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(299, 267);
            richTextBox3.TabIndex = 4;
            richTextBox3.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(695, 12);
            button3.Name = "button3";
            button3.Size = new Size(93, 29);
            button3.TabIndex = 5;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // PolybiusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "PolybiusForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button3;
    }
}