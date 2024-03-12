namespace BMI_Calculator
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
            age = new Label();
            Gender = new Label();
            weight = new Label();
            Height = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // age
            // 
            age.AutoSize = true;
            age.ForeColor = Color.White;
            age.Location = new Point(38, 122);
            age.Name = "age";
            age.Size = new Size(51, 26);
            age.TabIndex = 0;
            age.Text = "Age";
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Location = new Point(38, 172);
            Gender.Name = "Gender";
            Gender.Size = new Size(84, 26);
            Gender.TabIndex = 1;
            Gender.Text = "Gender";
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(38, 222);
            weight.Name = "weight";
            weight.Size = new Size(131, 26);
            weight.TabIndex = 2;
            weight.Text = "Weight (cm)";
            weight.Click += label1_Click;
            // 
            // Height
            // 
            Height.AutoSize = true;
            Height.Location = new Point(38, 273);
            Height.Name = "Height";
            Height.Size = new Size(77, 26);
            Height.TabIndex = 3;
            Height.Text = "Height";
            // 
            // button1
            // 
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(145, 323);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.RosyBrown;
            button2.Location = new Point(216, 464);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Gray;
            button3.Location = new Point(69, 464);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(69, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 30);
            textBox1.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 80);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 24);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 0;
            label1.Text = "BMI CALCULATOR";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDark;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(95, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlDark;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(175, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlDark;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(121, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 30);
            textBox4.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(128, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 30);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(233, 170);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 30);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(394, 535);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Height);
            Controls.Add(weight);
            Controls.Add(Gender);
            Controls.Add(age);
            Font = new Font("Gadugi", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label age;
        private Label Gender;
        private Label weight;
        private Label Height;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
