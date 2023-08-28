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
            BorrowerDetailpanel = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            CloseBtn = new PictureBox();
            label1 = new Label();
            CIFNumber = new TextBox();
            lable2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            BorrowerDetailpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            SuspendLayout();
            // 
            // BorrowerDetailpanel
            // 
            BorrowerDetailpanel.Controls.Add(label5);
            BorrowerDetailpanel.Controls.Add(textBox4);
            BorrowerDetailpanel.Controls.Add(label4);
            BorrowerDetailpanel.Controls.Add(textBox3);
            BorrowerDetailpanel.Controls.Add(label3);
            BorrowerDetailpanel.Controls.Add(textBox2);
            BorrowerDetailpanel.Controls.Add(lable2);
            BorrowerDetailpanel.Controls.Add(CIFNumber);
            BorrowerDetailpanel.Location = new Point(185, 87);
            BorrowerDetailpanel.Name = "BorrowerDetailpanel";
            BorrowerDetailpanel.Size = new Size(952, 649);
            BorrowerDetailpanel.TabIndex = 0;
            BorrowerDetailpanel.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(12, 108);
            button1.Name = "button1";
            button1.Size = new Size(151, 43);
            button1.TabIndex = 1;
            button1.Text = "Borrower Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 166);
            button2.Name = "button2";
            button2.Size = new Size(151, 43);
            button2.TabIndex = 2;
            button2.Text = "Borrower Office";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 224);
            button3.Name = "button3";
            button3.Size = new Size(151, 34);
            button3.TabIndex = 3;
            button3.Text = "Borrower Salary";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 278);
            button4.Name = "button4";
            button4.Size = new Size(151, 42);
            button4.TabIndex = 4;
            button4.Text = "EMI Calculation";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 337);
            button5.Name = "button5";
            button5.Size = new Size(151, 34);
            button5.TabIndex = 5;
            button5.Text = "Guarantor Details";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 14;
            label1.Text = "Personal Loan";
            // 
            // CIFNumber
            // 
            CIFNumber.Location = new Point(591, 41);
            CIFNumber.Name = "CIFNumber";
            CIFNumber.Size = new Size(218, 23);
            CIFNumber.TabIndex = 0;
            // 
            // lable2
            // 
            lable2.AutoSize = true;
            lable2.Location = new Point(514, 44);
            lable2.Name = "lable2";
            lable2.Size = new Size(71, 15);
            lable2.TabIndex = 1;
            lable2.Text = "CIF Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 112);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 107);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(564, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 44);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "SB Account No";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 23);
            textBox4.TabIndex = 6;
            // 
            // PersonalLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1184, 761);
            Controls.Add(label1);
            Controls.Add(CloseBtn);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BorrowerDetailpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalLoan";
            Text = "PersonalLoan";
            BorrowerDetailpanel.ResumeLayout(false);
            BorrowerDetailpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BorrowerDetailpanel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private PictureBox CloseBtn;
        private TextBox CIFNumber;
        private Label label1;
        private Label lable2;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
    }
}