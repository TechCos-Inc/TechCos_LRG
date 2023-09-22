namespace TechCos_LRG
{
    partial class BusinessLoan
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
            label1 = new Label();
            BNameTxt = new TextBox();
            BAddressTxt = new TextBox();
            label3 = new Label();
            AddBtn = new Button();
            CloseBtn = new PictureBox();
            generateBtn = new Button();
            BLBackBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BLBackBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // BNameTxt
            // 
            BNameTxt.Location = new Point(205, 53);
            BNameTxt.Name = "BNameTxt";
            BNameTxt.Size = new Size(163, 23);
            BNameTxt.TabIndex = 1;
            // 
            // BAddressTxt
            // 
            BAddressTxt.Location = new Point(205, 144);
            BAddressTxt.Multiline = true;
            BAddressTxt.Name = "BAddressTxt";
            BAddressTxt.Size = new Size(209, 87);
            BAddressTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 147);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(205, 458);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImage = Properties.Resources.cancel;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(1123, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 12;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(649, 417);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(75, 23);
            generateBtn.TabIndex = 13;
            generateBtn.Text = "generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // BLBackBtn
            // 
            BLBackBtn.Image = Properties.Resources.icons8_back_arrow_100;
            BLBackBtn.Location = new Point(1063, 12);
            BLBackBtn.Name = "BLBackBtn";
            BLBackBtn.Size = new Size(37, 34);
            BLBackBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            BLBackBtn.TabIndex = 14;
            BLBackBtn.TabStop = false;
            BLBackBtn.Click += BLBackBtn_Click;
            // 
            // BusinessLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(BLBackBtn);
            Controls.Add(generateBtn);
            Controls.Add(CloseBtn);
            Controls.Add(AddBtn);
            Controls.Add(BAddressTxt);
            Controls.Add(label3);
            Controls.Add(BNameTxt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BusinessLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BusinessLoan";
            Load += BusinessLoan_Load;
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)BLBackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BNameTxt;
        private TextBox BAddressTxt;
        private Label label3;
        private Button AddBtn;
        private PictureBox CloseBtn;
        private Button generateBtn;
        private PictureBox BLBackBtn;
    }
}