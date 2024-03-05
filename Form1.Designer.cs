namespace Notatnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(727, 346);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(748, 87);
            button1.Name = "button1";
            button1.Size = new Size(67, 26);
            button1.TabIndex = 1;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(748, 55);
            button2.Name = "button2";
            button2.Size = new Size(67, 26);
            button2.TabIndex = 2;
            button2.Text = "Open";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(748, 375);
            button3.Name = "button3";
            button3.Size = new Size(67, 26);
            button3.TabIndex = 3;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += exit;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = Color.Red;
            colorDialog1.FullOpen = true;
            colorDialog1.HelpRequest += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button4
            // 
            button4.Location = new Point(169, 12);
            button4.Name = "button4";
            button4.Size = new Size(49, 37);
            button4.TabIndex = 4;
            button4.Text = "Color";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(15, 12);
            button5.Name = "button5";
            button5.Size = new Size(42, 37);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Image = Properties.Resources.left;
            button6.Location = new Point(63, 12);
            button6.Name = "button6";
            button6.Size = new Size(48, 37);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = Properties.Resources.right;
            button7.Location = new Point(117, 12);
            button7.Name = "button7";
            button7.Size = new Size(46, 37);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.Link;
            button8.Location = new Point(224, 12);
            button8.Name = "button8";
            button8.Size = new Size(49, 37);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(279, 12);
            button9.Name = "button9";
            button9.Size = new Size(49, 37);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += druk;
            // 
            // button10
            // 
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(334, 12);
            button10.Name = "button10";
            button10.Size = new Size(49, 37);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 413);
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
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        public ColorDialog colorDialog1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
