namespace TechCos_LRG
{
    partial class PersonalLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            CloseBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(185, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 657);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 43);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 1;
            button1.Text = "Borrower Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 92);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 2;
            button2.Text = "Borrower Office";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 141);
            button3.Name = "button3";
            button3.Size = new Size(151, 34);
            button3.TabIndex = 3;
            button3.Text = "Borrower Salary";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 181);
            button4.Name = "button4";
            button4.Size = new Size(151, 42);
            button4.TabIndex = 4;
            button4.Text = "EMI Calculation";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 229);
            button5.Name = "button5";
            button5.Size = new Size(151, 34);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImage = Properties.Resources.cancel;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(1119, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 13;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // PersonalLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1184, 761);
            Controls.Add(CloseBtn);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalLoan";
            Text = "PersonalLoan";
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox CloseBtn;
    }
}