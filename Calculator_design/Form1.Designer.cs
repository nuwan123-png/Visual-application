namespace Calculator_design
{
    partial class devition
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
            text = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            plus = new Button();
            minos = new Button();
            multi = new Button();
            dev = new Button();
            equal = new Button();
            clear = new Button();
            CE = new Button();
            SuspendLayout();
            // 
            // text
            // 
            text.Location = new Point(82, 103);
            text.Name = "text";
            text.Size = new Size(262, 27);
            text.TabIndex = 0;
            text.TextChanged += text_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(82, 153);
            button1.Name = "button1";
            button1.Size = new Size(46, 41);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 153);
            button2.Name = "button2";
            button2.Size = new Size(46, 41);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(186, 153);
            button3.Name = "button3";
            button3.Size = new Size(46, 41);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(82, 200);
            button4.Name = "button4";
            button4.Size = new Size(46, 41);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(134, 200);
            button5.Name = "button5";
            button5.Size = new Size(46, 41);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(186, 200);
            button6.Name = "button6";
            button6.Size = new Size(46, 41);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(82, 247);
            button7.Name = "button7";
            button7.Size = new Size(46, 41);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(134, 246);
            button8.Name = "button8";
            button8.Size = new Size(46, 41);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(82, 294);
            button9.Name = "button9";
            button9.Size = new Size(98, 41);
            button9.TabIndex = 9;
            button9.Text = "0";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(186, 246);
            button10.Name = "button10";
            button10.Size = new Size(46, 41);
            button10.TabIndex = 10;
            button10.Text = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(186, 293);
            button11.Name = "button11";
            button11.Size = new Size(46, 41);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // plus
            // 
            plus.Location = new Point(238, 294);
            plus.Name = "plus";
            plus.Size = new Size(50, 42);
            plus.TabIndex = 12;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minos
            // 
            minos.Location = new Point(238, 246);
            minos.Name = "minos";
            minos.Size = new Size(50, 42);
            minos.TabIndex = 13;
            minos.Text = "-";
            minos.UseVisualStyleBackColor = true;
            minos.Click += minos_Click;
            // 
            // multi
            // 
            multi.Location = new Point(238, 198);
            multi.Name = "multi";
            multi.Size = new Size(50, 42);
            multi.TabIndex = 14;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // dev
            // 
            dev.Location = new Point(238, 153);
            dev.Name = "dev";
            dev.Size = new Size(50, 42);
            dev.TabIndex = 15;
            dev.Text = "/";
            dev.UseVisualStyleBackColor = true;
            dev.Click += dev_Click;
            // 
            // equal
            // 
            equal.Location = new Point(294, 246);
            equal.Name = "equal";
            equal.Size = new Size(50, 90);
            equal.TabIndex = 16;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // clear
            // 
            clear.Location = new Point(294, 198);
            clear.Name = "clear";
            clear.Size = new Size(50, 42);
            clear.TabIndex = 17;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // CE
            // 
            CE.Location = new Point(294, 153);
            CE.Name = "CE";
            CE.Size = new Size(50, 42);
            CE.TabIndex = 18;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += CE_Click;
            // 
            // devition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(441, 450);
            Controls.Add(CE);
            Controls.Add(clear);
            Controls.Add(equal);
            Controls.Add(dev);
            Controls.Add(multi);
            Controls.Add(minos);
            Controls.Add(plus);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(text);
            Name = "devition";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button plus;
        private Button minos;
        private Button multi;
        private Button dev;
        private Button equal;
        private Button clear;
        private Button CE;
    }
}
