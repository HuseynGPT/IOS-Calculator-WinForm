namespace IOS_Calculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            clearC = new CircularButton();
            circularButton2 = new CircularButton();
            Percentage = new CircularButton();
            Number_7 = new CircularButton();
            divide = new CircularButton();
            Number_9 = new CircularButton();
            Number_8 = new CircularButton();
            subtraction = new CircularButton();
            minus = new CircularButton();
            Number_5 = new CircularButton();
            Number_6 = new CircularButton();
            Number_4 = new CircularButton();
            plus = new CircularButton();
            Number_2 = new CircularButton();
            Number_3 = new CircularButton();
            Number_1 = new CircularButton();
            equal = new CircularButton();
            circularButton19 = new CircularButton();
            Number_0 = new CircularButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // clearC
            // 
            clearC.BackColor = Color.Silver;
            clearC.FlatAppearance.BorderSize = 0;
            clearC.FlatStyle = FlatStyle.Flat;
            clearC.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearC.ForeColor = Color.White;
            clearC.Location = new Point(12, 146);
            clearC.Name = "clearC";
            clearC.Size = new Size(66, 58);
            clearC.TabIndex = 0;
            clearC.Text = "C";
            clearC.UseVisualStyleBackColor = false;
            clearC.Click += clearC_Click_1;
            // 
            // circularButton2
            // 
            circularButton2.BackColor = Color.Silver;
            circularButton2.FlatAppearance.BorderSize = 0;
            circularButton2.FlatStyle = FlatStyle.Flat;
            circularButton2.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            circularButton2.ForeColor = Color.White;
            circularButton2.Location = new Point(84, 146);
            circularButton2.Name = "circularButton2";
            circularButton2.Size = new Size(66, 58);
            circularButton2.TabIndex = 1;
            circularButton2.Text = "+/-";
            circularButton2.UseVisualStyleBackColor = false;
            circularButton2.Click += circularButton2_Click;
            // 
            // Percentage
            // 
            Percentage.BackColor = Color.Silver;
            Percentage.FlatAppearance.BorderSize = 0;
            Percentage.FlatStyle = FlatStyle.Flat;
            Percentage.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(156, 146);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(66, 58);
            Percentage.TabIndex = 2;
            Percentage.Text = "%";
            Percentage.UseVisualStyleBackColor = false;
            Percentage.Click += Percentage_Click;
            // 
            // Number_7
            // 
            Number_7.BackColor = Color.FromArgb(64, 64, 64);
            Number_7.FlatAppearance.BorderSize = 0;
            Number_7.FlatStyle = FlatStyle.Flat;
            Number_7.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_7.ForeColor = Color.White;
            Number_7.Location = new Point(12, 210);
            Number_7.Name = "Number_7";
            Number_7.Size = new Size(66, 58);
            Number_7.TabIndex = 3;
            Number_7.Text = "7";
            Number_7.UseVisualStyleBackColor = false;
            Number_7.Click += Number_7_Click_1;
            // 
            // divide
            // 
            divide.BackColor = Color.Orange;
            divide.FlatAppearance.BorderSize = 0;
            divide.FlatStyle = FlatStyle.Flat;
            divide.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            divide.ForeColor = Color.White;
            divide.Location = new Point(228, 146);
            divide.Name = "divide";
            divide.Size = new Size(66, 58);
            divide.TabIndex = 4;
            divide.Text = "÷";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // Number_9
            // 
            Number_9.BackColor = Color.FromArgb(64, 64, 64);
            Number_9.FlatAppearance.BorderSize = 0;
            Number_9.FlatStyle = FlatStyle.Flat;
            Number_9.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_9.ForeColor = Color.White;
            Number_9.Location = new Point(156, 210);
            Number_9.Name = "Number_9";
            Number_9.Size = new Size(66, 58);
            Number_9.TabIndex = 5;
            Number_9.Text = "9";
            Number_9.UseVisualStyleBackColor = false;
            Number_9.Click += Number_9_Click_1;
            // 
            // Number_8
            // 
            Number_8.BackColor = Color.FromArgb(64, 64, 64);
            Number_8.FlatAppearance.BorderSize = 0;
            Number_8.FlatStyle = FlatStyle.Flat;
            Number_8.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_8.ForeColor = Color.White;
            Number_8.Location = new Point(84, 210);
            Number_8.Name = "Number_8";
            Number_8.Size = new Size(66, 58);
            Number_8.TabIndex = 5;
            Number_8.Text = "8";
            Number_8.UseVisualStyleBackColor = false;
            Number_8.Click += Number_8_Click;
            // 
            // subtraction
            // 
            subtraction.BackColor = Color.Orange;
            subtraction.FlatAppearance.BorderSize = 0;
            subtraction.FlatStyle = FlatStyle.Flat;
            subtraction.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            subtraction.ForeColor = Color.White;
            subtraction.Location = new Point(227, 210);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(66, 58);
            subtraction.TabIndex = 6;
            subtraction.Text = "x";
            subtraction.UseVisualStyleBackColor = false;
            subtraction.Click += subtraction_Click;
            // 
            // minus
            // 
            minus.BackColor = Color.Orange;
            minus.FlatAppearance.BorderSize = 0;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            minus.ForeColor = Color.White;
            minus.Location = new Point(227, 274);
            minus.Name = "minus";
            minus.Size = new Size(66, 58);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // Number_5
            // 
            Number_5.BackColor = Color.FromArgb(64, 64, 64);
            Number_5.FlatAppearance.BorderSize = 0;
            Number_5.FlatStyle = FlatStyle.Flat;
            Number_5.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_5.ForeColor = Color.White;
            Number_5.Location = new Point(84, 274);
            Number_5.Name = "Number_5";
            Number_5.Size = new Size(66, 58);
            Number_5.TabIndex = 8;
            Number_5.Text = "5";
            Number_5.UseVisualStyleBackColor = false;
            Number_5.Click += Number_5_Click;
            // 
            // Number_6
            // 
            Number_6.BackColor = Color.FromArgb(64, 64, 64);
            Number_6.FlatAppearance.BorderSize = 0;
            Number_6.FlatStyle = FlatStyle.Flat;
            Number_6.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_6.ForeColor = Color.White;
            Number_6.Location = new Point(156, 274);
            Number_6.Name = "Number_6";
            Number_6.Size = new Size(66, 58);
            Number_6.TabIndex = 9;
            Number_6.Text = "6";
            Number_6.UseVisualStyleBackColor = false;
            Number_6.Click += Number_6_Click_2;
            // 
            // Number_4
            // 
            Number_4.BackColor = Color.FromArgb(64, 64, 64);
            Number_4.FlatAppearance.BorderSize = 0;
            Number_4.FlatStyle = FlatStyle.Flat;
            Number_4.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_4.ForeColor = Color.White;
            Number_4.Location = new Point(12, 274);
            Number_4.Name = "Number_4";
            Number_4.Size = new Size(66, 58);
            Number_4.TabIndex = 7;
            Number_4.Text = "4";
            Number_4.UseVisualStyleBackColor = false;
            Number_4.Click += Number_4_Click_1;
            // 
            // plus
            // 
            plus.BackColor = Color.Orange;
            plus.FlatAppearance.BorderSize = 0;
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            plus.ForeColor = Color.White;
            plus.Location = new Point(227, 338);
            plus.Name = "plus";
            plus.Size = new Size(66, 58);
            plus.TabIndex = 14;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // Number_2
            // 
            Number_2.BackColor = Color.FromArgb(64, 64, 64);
            Number_2.FlatAppearance.BorderSize = 0;
            Number_2.FlatStyle = FlatStyle.Flat;
            Number_2.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_2.ForeColor = Color.White;
            Number_2.Location = new Point(84, 338);
            Number_2.Name = "Number_2";
            Number_2.Size = new Size(66, 58);
            Number_2.TabIndex = 12;
            Number_2.Text = "2";
            Number_2.UseVisualStyleBackColor = false;
            Number_2.Click += Number_2_Click;
            // 
            // Number_3
            // 
            Number_3.BackColor = Color.FromArgb(64, 64, 64);
            Number_3.FlatAppearance.BorderSize = 0;
            Number_3.FlatStyle = FlatStyle.Flat;
            Number_3.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_3.ForeColor = Color.White;
            Number_3.Location = new Point(156, 338);
            Number_3.Name = "Number_3";
            Number_3.Size = new Size(66, 58);
            Number_3.TabIndex = 13;
            Number_3.Text = "3";
            Number_3.UseVisualStyleBackColor = false;
            Number_3.Click += Number_3_Click;
            // 
            // Number_1
            // 
            Number_1.BackColor = Color.FromArgb(64, 64, 64);
            Number_1.FlatAppearance.BorderSize = 0;
            Number_1.FlatStyle = FlatStyle.Flat;
            Number_1.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_1.ForeColor = Color.White;
            Number_1.Location = new Point(12, 338);
            Number_1.Name = "Number_1";
            Number_1.Size = new Size(66, 58);
            Number_1.TabIndex = 11;
            Number_1.Text = "1";
            Number_1.UseVisualStyleBackColor = false;
            Number_1.Click += Number_1_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.Orange;
            equal.FlatAppearance.BorderSize = 0;
            equal.FlatStyle = FlatStyle.Flat;
            equal.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            equal.ForeColor = Color.White;
            equal.Location = new Point(227, 402);
            equal.Name = "equal";
            equal.Size = new Size(66, 58);
            equal.TabIndex = 18;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // circularButton19
            // 
            circularButton19.BackColor = Color.FromArgb(64, 64, 64);
            circularButton19.FlatAppearance.BorderSize = 0;
            circularButton19.FlatStyle = FlatStyle.Flat;
            circularButton19.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            circularButton19.ForeColor = Color.White;
            circularButton19.Location = new Point(156, 402);
            circularButton19.Name = "circularButton19";
            circularButton19.Size = new Size(66, 58);
            circularButton19.TabIndex = 17;
            circularButton19.Text = ".";
            circularButton19.UseVisualStyleBackColor = false;
            circularButton19.Click += circularButton19_Click;
            // 
            // Number_0
            // 
            Number_0.BackColor = Color.FromArgb(64, 64, 64);
            Number_0.FlatAppearance.BorderSize = 0;
            Number_0.FlatStyle = FlatStyle.Flat;
            Number_0.Font = new Font("Arial Narrow", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Number_0.ForeColor = Color.White;
            Number_0.Location = new Point(12, 402);
            Number_0.Name = "Number_0";
            Number_0.Size = new Size(128, 58);
            Number_0.TabIndex = 15;
            Number_0.Text = "0";
            Number_0.UseVisualStyleBackColor = false;
            Number_0.Click += Number_0_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(12, 60);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(281, 64);
            textBox1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(305, 489);
            Controls.Add(textBox1);
            Controls.Add(equal);
            Controls.Add(circularButton19);
            Controls.Add(Number_0);
            Controls.Add(plus);
            Controls.Add(Number_2);
            Controls.Add(Number_3);
            Controls.Add(Number_1);
            Controls.Add(minus);
            Controls.Add(Number_5);
            Controls.Add(Number_6);
            Controls.Add(Number_4);
            Controls.Add(subtraction);
            Controls.Add(Number_8);
            Controls.Add(Number_9);
            Controls.Add(divide);
            Controls.Add(Number_7);
            Controls.Add(Percentage);
            Controls.Add(circularButton2);
            Controls.Add(clearC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularButton clearC;
        private CircularButton circularButton2;
        private CircularButton Percentage;
        private CircularButton Number_7;
        private CircularButton divide;
        private CircularButton Number_9;
        private CircularButton Number_8;
        private CircularButton subtraction;
        private CircularButton minus;
        private CircularButton Number_5;
        private CircularButton Number_6;
        private CircularButton Number_4;
        private CircularButton plus;
        private CircularButton Number_2;
        private CircularButton Number_3;
        private CircularButton Number_1;
        private CircularButton equal;
        private CircularButton circularButton19;
        private CircularButton Number_0;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
    }
}