namespace ZKI_Main
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(48, 53);
            button1.Name = "button1";
            button1.Size = new Size(153, 48);
            button1.TabIndex = 0;
            button1.Text = "Квадрат полибия";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(48, 107);
            button2.Name = "button2";
            button2.Size = new Size(153, 48);
            button2.TabIndex = 1;
            button2.Text = "Двойная перестановка";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 161);
            button3.Name = "button3";
            button3.Size = new Size(153, 48);
            button3.TabIndex = 2;
            button3.Text = "Одиночная перестановка";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(48, 215);
            button4.Name = "button4";
            button4.Size = new Size(153, 48);
            button4.TabIndex = 3;
            button4.Text = "Цезарь + Виженера";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(48, 269);
            button5.Name = "button5";
            button5.Size = new Size(153, 48);
            button5.TabIndex = 4;
            button5.Text = "Виженера + Плейфер";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(341, 53);
            button6.Name = "button6";
            button6.Size = new Size(153, 48);
            button6.TabIndex = 5;
            button6.Text = "Плейфер + Уитсон";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(341, 107);
            button7.Name = "button7";
            button7.Size = new Size(153, 48);
            button7.TabIndex = 6;
            button7.Text = "Цезарь + Гаммирование";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(341, 161);
            button8.Name = "button8";
            button8.Size = new Size(153, 48);
            button8.TabIndex = 7;
            button8.Text = "Эль Гамаля";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(341, 215);
            button9.Name = "button9";
            button9.Size = new Size(153, 48);
            button9.TabIndex = 8;
            button9.Text = "Рюкзак";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}