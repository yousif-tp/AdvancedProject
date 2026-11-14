namespace AdvancedProject
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
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(731, 291);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(601, 319);
            button1.Name = "button1";
            button1.Size = new Size(217, 46);
            button1.TabIndex = 1;
            button1.Text = "Encode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1286, 151);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(178, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(816, 396);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(648, 351);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1099, 146);
            label1.Name = "label1";
            label1.Size = new Size(181, 53);
            label1.TabIndex = 4;
            label1.Text = "Shift Alphabet by:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(42, 115);
            label2.Name = "label2";
            label2.Size = new Size(187, 76);
            label2.TabIndex = 5;
            label2.Text = "Input Text :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(560, 530);
            label3.Name = "label3";
            label3.Size = new Size(226, 61);
            label3.TabIndex = 6;
            label3.Text = "Output Text :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 759);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
