namespace TechCos_LRG
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            LoginInfoPanel = new Panel();
            AdminLoginPanel = new Panel();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            backAdminBtn = new PictureBox();
            AdminSubmitBtn = new Button();
            PasswordAdminLoginTxtField = new TextBox();
            UsernameAdminLoginTxtField = new TextBox();
            UserloginPanel = new Panel();
            label6 = new Label();
            backUserBtn = new PictureBox();
            UserSubmitBtn = new Button();
            PasswordUserLoginTxtField = new TextBox();
            UsernameUserLoginTxtField = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginInfoPanel.SuspendLayout();
            AdminLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backAdminBtn).BeginInit();
            UserloginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backUserBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(257, 59);
            label1.TabIndex = 0;
            label1.Text = "Login To Continue";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 78);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 1;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 137);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 2;
            button2.Text = "User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(1044, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Super User";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(1143, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Help?";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginInfoPanel
            // 
            LoginInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LoginInfoPanel.Controls.Add(label1);
            LoginInfoPanel.Controls.Add(button1);
            LoginInfoPanel.Controls.Add(button2);
            LoginInfoPanel.Location = new Point(1020, 240);
            LoginInfoPanel.Name = "LoginInfoPanel";
            LoginInfoPanel.Size = new Size(434, 183);
            LoginInfoPanel.TabIndex = 6;
            // 
            // AdminLoginPanel
            // 
            AdminLoginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AdminLoginPanel.Controls.Add(label7);
            AdminLoginPanel.Controls.Add(label3);
            AdminLoginPanel.Controls.Add(label2);
            AdminLoginPanel.Controls.Add(backAdminBtn);
            AdminLoginPanel.Controls.Add(AdminSubmitBtn);
            AdminLoginPanel.Controls.Add(PasswordAdminLoginTxtField);
            AdminLoginPanel.Controls.Add(UsernameAdminLoginTxtField);
            AdminLoginPanel.Location = new Point(1035, 224);
            AdminLoginPanel.Name = "AdminLoginPanel";
            AdminLoginPanel.Size = new Size(416, 208);
            AdminLoginPanel.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(80, 18);
            label7.Name = "label7";
            label7.Size = new Size(124, 28);
            label7.TabIndex = 9;
            label7.Text = "Admin Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 104);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 57);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 7;
            label2.Text = "Username ";
            // 
            // backAdminBtn
            // 
            backAdminBtn.Image = Properties.Resources.icons8_back_arrow_100;
            backAdminBtn.Location = new Point(17, 18);
            backAdminBtn.Name = "backAdminBtn";
            backAdminBtn.Size = new Size(37, 34);
            backAdminBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backAdminBtn.TabIndex = 6;
            backAdminBtn.TabStop = false;
            backAdminBtn.Click += backAdminBtn_Click;
            // 
            // AdminSubmitBtn
            // 
            AdminSubmitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AdminSubmitBtn.Location = new Point(145, 162);
            AdminSubmitBtn.Name = "AdminSubmitBtn";
            AdminSubmitBtn.Size = new Size(128, 43);
            AdminSubmitBtn.TabIndex = 4;
            AdminSubmitBtn.Text = "Continue";
            AdminSubmitBtn.UseVisualStyleBackColor = true;
            AdminSubmitBtn.Click += AdminSubmitBtn_Click;
            // 
            // PasswordAdminLoginTxtField
            // 
            PasswordAdminLoginTxtField.Location = new Point(233, 107);
            PasswordAdminLoginTxtField.Name = "PasswordAdminLoginTxtField";
            PasswordAdminLoginTxtField.Size = new Size(100, 23);
            PasswordAdminLoginTxtField.TabIndex = 3;
            // 
            // UsernameAdminLoginTxtField
            // 
            UsernameAdminLoginTxtField.Location = new Point(233, 60);
            UsernameAdminLoginTxtField.Name = "UsernameAdminLoginTxtField";
            UsernameAdminLoginTxtField.Size = new Size(100, 23);
            UsernameAdminLoginTxtField.TabIndex = 2;
            // 
            // UserloginPanel
            // 
            UserloginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserloginPanel.Controls.Add(label6);
            UserloginPanel.Controls.Add(backUserBtn);
            UserloginPanel.Controls.Add(UserSubmitBtn);
            UserloginPanel.Controls.Add(PasswordUserLoginTxtField);
            UserloginPanel.Controls.Add(UsernameUserLoginTxtField);
            UserloginPanel.Controls.Add(label4);
            UserloginPanel.Controls.Add(label5);
            UserloginPanel.Location = new Point(1052, 212);
            UserloginPanel.Name = "UserloginPanel";
            UserloginPanel.Size = new Size(416, 208);
            UserloginPanel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(69, 13);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 6;
            label6.Text = "User Login";
            // 
            // backUserBtn
            // 
            backUserBtn.Image = Properties.Resources.icons8_back_arrow_100;
            backUserBtn.Location = new Point(18, 13);
            backUserBtn.Name = "backUserBtn";
            backUserBtn.Size = new Size(37, 34);
            backUserBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backUserBtn.TabIndex = 5;
            backUserBtn.TabStop = false;
            backUserBtn.Click += backUserBtn_Click;
            // 
            // UserSubmitBtn
            // 
            UserSubmitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserSubmitBtn.Location = new Point(145, 162);
            UserSubmitBtn.Name = "UserSubmitBtn";
            UserSubmitBtn.Size = new Size(128, 43);
            UserSubmitBtn.TabIndex = 4;
            UserSubmitBtn.Text = "Continue";
            UserSubmitBtn.UseVisualStyleBackColor = true;
            UserSubmitBtn.Click += UserSubmitBtn_Click;
            // 
            // PasswordUserLoginTxtField
            // 
            PasswordUserLoginTxtField.Location = new Point(233, 108);
            PasswordUserLoginTxtField.Name = "PasswordUserLoginTxtField";
            PasswordUserLoginTxtField.Size = new Size(150, 23);
            PasswordUserLoginTxtField.TabIndex = 3;
            // 
            // UsernameUserLoginTxtField
            // 
            UsernameUserLoginTxtField.Location = new Point(233, 57);
            UsernameUserLoginTxtField.Name = "UsernameUserLoginTxtField";
            UsernameUserLoginTxtField.Size = new Size(150, 23);
            UsernameUserLoginTxtField.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 105);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 54);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 0;
            label5.Text = "Username ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 761);
            Controls.Add(AdminLoginPanel);
            Controls.Add(UserloginPanel);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(LoginInfoPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Loan Report Generator - TechCos Inc";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginInfoPanel.ResumeLayout(false);
            AdminLoginPanel.ResumeLayout(false);
            AdminLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backAdminBtn).EndInit();
            UserloginPanel.ResumeLayout(false);
            UserloginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backUserBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private Panel LoginInfoPanel;
        private Panel AdminLoginPanel;
        private TextBox textBox1;
        private Button AdminSubmitBtn;
        private TextBox PasswordAdminLoginTxtField;
        private TextBox UsernameAdminLoginTxtField;
        private TextBox textBox2;
        private Panel UserloginPanel;
        private Button UserSubmitBtn;
        private TextBox PasswordUserLoginTxtField;
        private TextBox textBox3;
        private TextBox UsernameUserLoginTxtField;
        private Label label4;
        private Label label5;
        private PictureBox backUserBtn;
        private PictureBox backAdminBtn;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
    }
}