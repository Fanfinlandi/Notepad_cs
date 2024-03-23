﻿namespace Notatnik
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
            saveFileDialog1 = new SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            button8 = new Button();
            button10 = new Button();
            button11 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(15, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(816, 346);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
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
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button4.Location = new Point(173, 12);
            button4.Name = "button4";
            button4.Size = new Size(49, 37);
            button4.TabIndex = 4;
            button4.Text = "Color";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Image = Properties.Resources.Link;
            button8.Location = new Point(228, 12);
            button8.Name = "button8";
            button8.Size = new Size(49, 37);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.Image = Properties.Resources.broom;
            button10.Location = new Point(338, 12);
            button10.Name = "button10";
            button10.Size = new Size(49, 37);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Image = Properties.Resources.bold;
            button11.Location = new Point(283, 12);
            button11.Name = "button11";
            button11.Size = new Size(49, 37);
            button11.TabIndex = 11;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Save", "Open", "Print" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(73, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "File";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Center", "Left", "Right", "Text" });
            comboBox2.Location = new Point(91, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(76, 23);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "Edit";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(843, 413);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(859, 452);
            MinimumSize = new Size(859, 452);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        public ColorDialog colorDialog1;
        private Button button8;
        private Button button10;
        private Button button11;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
