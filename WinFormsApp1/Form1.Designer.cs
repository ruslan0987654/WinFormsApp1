namespace WinFormsApp1
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
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Ad = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Ad);
            panel1.Location = new Point(118, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 337);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(101, 273);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "hesab yarat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 9);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 6;
            label4.Text = "Register";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 31);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 31);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 181);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 129);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // Ad
            // 
            Ad.AutoSize = true;
            Ad.Location = new Point(25, 79);
            Ad.Name = "Ad";
            Ad.Size = new Size(35, 25);
            Ad.TabIndex = 0;
            Ad.Text = "Ad";
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(614, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 337);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(122, 258);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "daxil ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 9);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 6;
            label5.Text = "Login";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(101, 126);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(101, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 31);
            textBox6.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 129);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 1;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 79);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 0;
            label8.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Ad;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Button button2;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
    }
}
