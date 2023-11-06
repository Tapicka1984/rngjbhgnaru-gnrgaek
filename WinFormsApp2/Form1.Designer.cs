namespace WinFormsApp2
{
    partial class Form1
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
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 47);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(37, 131);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(358, 47);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(335, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(335, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(358, 129);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button4;
    }
}